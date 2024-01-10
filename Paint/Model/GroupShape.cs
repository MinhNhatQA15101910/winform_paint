using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Paint.Model
{
    // A group of many Shapes
    public class GroupShape : Shape, IEnumerable
    {
        private readonly List<Shape> Shapes = new List<Shape>();

        public GroupShape()
        {
            Name = "Group";
        }

        public Shape this[int index]
        {
            get
            {
                return Shapes[index];
            }
            set
            {
                Shapes[index] = value;
            }
        }
        private GraphicsPath[] GraphicsPaths
        {
            get
            {
                GraphicsPath[] paths = new GraphicsPath[Shapes.Count];

                for (int i = 0; i < Shapes.Count; i++)
                {
                    GraphicsPath path = new GraphicsPath();
                    if (Shapes[i] is MyLine)
                    {
                        MyLine line = Shapes[i] as MyLine;
                        path.AddLine(line.PointHead, line.PointTail);
                    }
                    else if (Shapes[i] is MyCurve)
                    {
                        MyCurve curve = Shapes[i] as MyCurve;
                        path.AddCurve(curve.Points.ToArray());
                    }
                    else if (Shapes[i] is MyEllipse)
                    {
                        MyEllipse ellipse = Shapes[i] as MyEllipse;
                        path.AddEllipse(
                            new Rectangle(
                                ellipse.PointHead.X, 
                                ellipse.PointHead.Y, 
                                ellipse.PointTail.X - ellipse.PointHead.X, 
                                ellipse.PointTail.Y - ellipse.PointHead.Y
                            )
                        );
                    }
                    else if (Shapes[i] is MyRectangle)
                    {
                        MyRectangle rect = Shapes[i] as MyRectangle;
                        path.AddRectangle(
                            new Rectangle(
                                rect.PointHead.X, 
                                rect.PointHead.Y,
                                rect.PointTail.X - rect.PointHead.X,
                                rect.PointTail.Y - rect.PointHead.Y
                                )
                            );
                    }
                    else if (Shapes[i] is MyPolygon)
                    {
                        MyPolygon polygon = Shapes[i] as MyPolygon;
                        path.AddPolygon(polygon.Points.ToArray());
                    }
                    else if (Shapes[i] is GroupShape)
                    {
                        GroupShape group = Shapes[i] as GroupShape;
                        for (int j = 0; j < group.GraphicsPaths.Length; j++)
                        {
                            path.AddPath(group.GraphicsPaths[j], false);
                        }
                    }
                    paths[i] = path;
                }
                return paths;
            }
        }
        public void AddShape(Shape shape)
        {
            Shapes.Add(shape);
        }
        public override object Clone()
        {
            GroupShape group = new GroupShape
            {
                PointHead = PointHead,
                PointTail = PointTail,
                IsSelected = IsSelected,
                Name = Name,
                Color = Color,
                ContourWidth = ContourWidth,
            };
            for (int i = 0; i < Shapes.Count; i++)
            {
                group.Shapes.Add(Shapes[i].Clone() as Shape);
            }
            return group;
        }
        public override void DrawShape(Graphics g)
        {
            GraphicsPath[] paths = GraphicsPaths;
            for (int i = 0; i < paths.Length; i++)
            {
                using (GraphicsPath path = paths[i])
                {
                    if (Shapes[i] is MyRectangle || Shapes[i] is MyEllipse || Shapes[i] is MyPolygon)
                    {
                        if (Shapes[i].IsFill)
                        {
                            using (Brush brush = new SolidBrush(Shapes[i].Color))
                            {
                                g.FillPath(brush, path);
                            }
                        }
                        else
                        {
                            using (Pen pen = new Pen(Shapes[i].Color, Shapes[i].ContourWidth))
                            {
                                g.DrawPath(pen, path);
                            }
                        }
                    }
                    else if (Shapes[i] is GroupShape)
                    {
                        GroupShape group = Shapes[i] as GroupShape;
                        group.DrawShape(g);
                    }
                    else
                    {
                        using (Pen pen = new Pen(Shapes[i].Color, Shapes[i].ContourWidth))
                        {
                            g.DrawPath(pen, path);
                        }
                    }
                }
            }
        }
        public override bool IsHit(Point p)
        {
            GraphicsPath[] paths = GraphicsPaths;
            for (int i = 0; i < paths.Length; i++)
            {
                using (GraphicsPath path = paths[i])
                {
                    if (Shapes[i] is MyRectangle || Shapes[i] is MyEllipse) 
                    {
                        if (((MyRectangle)Shapes[i]).IsFill)
                        {
                            using (Brush brush = new SolidBrush(Color.Black))
                            {
                                if (path.IsVisible(p))
                                {
                                    return true;
                                }
                            }
                        }
                        else
                        {
                            using (Pen pen = new Pen(Color.Black, ContourWidth + 3))
                            {
                                if (path.IsOutlineVisible(p, pen))
                                {
                                    return true;
                                }
                            }
                        }
                    }
                    else if (!(Shapes[i] is GroupShape))
                    {
                        using (Pen pen = new Pen(Color.Black, ContourWidth + 3))
                        {
                            if (path.IsOutlineVisible(p, pen))
                            {
                                return true;
                            }
                        }
                    }
                    else if (Shapes[i] is GroupShape)
                    {
                        GroupShape group = Shapes[i] as GroupShape;
                        return group.IsHit(p);
                    }
                }
            }
            return false;
        }
        protected override GraphicsPath GraphicsPath
        {
            get { throw new NotImplementedException(); }
        }
        public IEnumerator GetEnumerator()
        {
            return Shapes.GetEnumerator();
        }
        public int Count
        {
            get
            {
                return Shapes.Count;
            }
        }
        public override void MoveShape(Point distance)
        {
            for (int i = 0; i < Shapes.Count; i++)
            {
                if (Shapes[i] is GroupShape)
                {
                    GroupShape group = Shapes[i] as GroupShape;
                    group.MoveShape(distance);
                }
                else
                {
                    Shapes[i].MoveShape(distance);
                }
            }
            base.MoveShape(distance);
        }
    }
}
