using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Paint.Model
{
    // A group of many shapes
    public class GroupShape:Shape, IEnumerable
    {
        private readonly List<Shape> shapes;

        public GroupShape()
        {
            name = "Group";
            shapes = new List<Shape>();
        }

        public Shape this[int index]
        {
            get
            {
                return shapes[index];
            }
            set
            {
                shapes[index] = value;
            }
        }
        private GraphicsPath[] graphicsPaths
        {
            get
            {
                GraphicsPath[] paths = new GraphicsPath[shapes.Count];

                for (int i = 0; i < shapes.Count; i++)
                {
                    GraphicsPath path = new GraphicsPath();
                    if (shapes[i] is MyLine)
                    {
                        MyLine line = shapes[i] as MyLine;
                        path.AddLine(line.pointHead, line.pointTail);
                    }
                    else if (shapes[i] is MyCurve)
                    {
                        MyCurve curve = shapes[i] as MyCurve;
                        path.AddCurve(curve.Points.ToArray());
                    }
                    else if (shapes[i] is MyEllipse)
                    {
                        MyEllipse ellipse = shapes[i] as MyEllipse;
                        path.AddEllipse(
                            new Rectangle(
                                ellipse.pointHead.X, 
                                ellipse.pointHead.Y, 
                                ellipse.pointTail.X - ellipse.pointHead.X, 
                                ellipse.pointTail.Y - ellipse.pointHead.Y
                            )
                        );
                    }
                    else if (shapes[i] is MyRectangle)
                    {
                        MyRectangle rect = shapes[i] as MyRectangle;
                        path.AddRectangle(
                            new Rectangle(
                                rect.pointHead.X, 
                                rect.pointHead.Y,
                                rect.pointTail.X - rect.pointHead.X,
                                rect.pointTail.Y - rect.pointHead.Y
                                )
                            );
                    }
                    else if (shapes[i] is MyPolygon)
                    {
                        MyPolygon polygon = shapes[i] as MyPolygon;
                        path.AddPolygon(polygon.Points.ToArray());
                    }
                    else if (shapes[i] is GroupShape)
                    {
                        GroupShape group = shapes[i] as GroupShape;
                        for (int j = 0; j < group.graphicsPaths.Length; j++)
                        {
                            path.AddPath(group.graphicsPaths[j], false);
                        }
                    }
                    paths[i] = path;
                }
                return paths;
            }
        }
        public void AddShape(Shape shape)
        {
            shapes.Add(shape);
        }
        public override object Clone()
        {
            GroupShape group = new GroupShape
            {
                pointHead = pointHead,
                pointTail = pointTail,
                isSelected = isSelected,
                name = name,
                color = color,
                contourWidth = contourWidth,
            };
            for (int i = 0; i < shapes.Count; i++)
            {
                group.shapes.Add(shapes[i].Clone() as Shape);
            }
            return group;
        }
        public override void DrawShape(Graphics g)
        {
            GraphicsPath[] paths = graphicsPaths;
            for (int i = 0; i < paths.Length; i++)
            {
                using (GraphicsPath path = paths[i])
                {
                    if (shapes[i] is MyRectangle || shapes[i] is MyEllipse || shapes[i] is MyPolygon)
                    {
                        if (shapes[i].isFill)
                        {
                            using (Brush brush = new SolidBrush(shapes[i].color))
                            {
                                g.FillPath(brush, path);
                            }
                        }
                        else
                        {
                            using (Pen pen = new Pen(shapes[i].color, shapes[i].contourWidth))
                            {
                                g.DrawPath(pen, path);
                            }
                        }
                    }
                    else if (shapes[i] is GroupShape)
                    {
                        GroupShape group = shapes[i] as GroupShape;
                        group.DrawShape(g);
                    }
                    else
                    {
                        using (Pen pen = new Pen(shapes[i].color, shapes[i].contourWidth))
                        {
                            g.DrawPath(pen, path);
                        }
                    }
                }
            }
        }
        public override bool isHit(Point p)
        {
            GraphicsPath[] paths = graphicsPaths;
            for (int i = 0; i < paths.Length; i++)
            {
                using (GraphicsPath path = paths[i])
                {
                    if (shapes[i] is MyRectangle || shapes[i] is MyEllipse) 
                    {
                        if (((MyRectangle)shapes[i]).isFill)
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
                            using (Pen pen = new Pen(Color.Black, contourWidth + 3))
                            {
                                if (path.IsOutlineVisible(p, pen))
                                {
                                    return true;
                                }
                            }
                        }
                    }
                    else if (!(shapes[i] is GroupShape))
                    {
                        using (Pen pen = new Pen(Color.Black, contourWidth + 3))
                        {
                            if (path.IsOutlineVisible(p, pen))
                            {
                                return true;
                            }
                        }
                    }
                    else if (shapes[i] is GroupShape)
                    {
                        GroupShape group = shapes[i] as GroupShape;
                        return group.isHit(p);
                    }
                }
            }
            return false;
        }
        protected override GraphicsPath graphicsPath
        {
            get { throw new NotImplementedException(); }
        }
        public IEnumerator GetEnumerator()
        {
            return shapes.GetEnumerator();
        }
        public int Count
        {
            get
            {
                return shapes.Count;
            }
        }
        public override void MoveShape(Point distance)
        {
            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i] is GroupShape)
                {
                    GroupShape group = shapes[i] as GroupShape;
                    group.MoveShape(distance);
                }
                else
                {
                    shapes[i].MoveShape(distance);
                }
            }
            base.MoveShape(distance);
        }
    }
}
