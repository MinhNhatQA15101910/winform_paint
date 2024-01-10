using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Paint.Model
{
    public class MyPolygon : Shape
    {
        public List<Point> Points { get; set; } = new List<Point>();

        public MyPolygon()
        {
            Name = "Polygon";
        }

        public override object Clone()
        {
            MyPolygon polygon = new MyPolygon
            {
                PointHead = PointHead,
                PointTail = PointTail,
                IsSelected = IsSelected,
                Name = Name,
                Color = Color,
                ContourWidth = ContourWidth,
                IsFill = IsFill
            };
            Points.ForEach(point => polygon.Points.Add(point));
            return polygon;
        }

        public override void DrawShape(Graphics g)
        {
            using (GraphicsPath path = GraphicsPath)
            {
                if (!IsFill)
                {
                    using (Pen pen = new Pen(Color, ContourWidth))
                    {
                        g.DrawPath(pen, path);
                    }
                }
                else
                {
                    using (Brush brush = new SolidBrush(Color))
                    {
                        if (Points.Count < 3)
                        {
                            using (Pen pen = new Pen(Color, ContourWidth))
                            {
                                g.DrawPath(pen, path);
                            }
                        }
                        else
                        {
                            g.FillPath(brush, path);
                        }
                    }
                }
            }
        }
        public override bool IsHit(Point p)
        {
            bool inside = false;
            using (GraphicsPath path = GraphicsPath)
            {
                if (!IsFill)
                {
                    using (Pen pen = new Pen(Color, ContourWidth + 3))
                    {
                        inside = path.IsOutlineVisible(p, pen);
                    }
                }
                else
                {
                    inside = path.IsVisible(p);
                }
            }
            return inside;
        }
        protected override GraphicsPath GraphicsPath
        {
            get
            {
                GraphicsPath path = new GraphicsPath();
                if (Points.Count < 3)
                {
                    path.AddLine(Points[0], Points[1]);
                }
                else
                {
                    path.AddPolygon(Points.ToArray());
                }

                return path;
            }
        }
        public override void MoveShape(Point distance)
        {
            base.MoveShape(distance);
            for (int i = 0; i < Points.Count; i++)
            {
                Points[i] = new Point(Points[i].X + distance.X, Points[i].Y + distance.Y);
            }
        }
        public override int IsHitControlsPoint(Point p)
        {
            for (int i = 0; i < Points.Count; i++)
            {
                GraphicsPath path = new GraphicsPath();
                path.AddRectangle(new Rectangle(Points[i].X - 4, Points[i].Y - 4, 8, 8));

                if (path.IsVisible(p)) return i;
            }
            return -1;
        }
        public override void MoveControlPoint(Point pointCurrent, Point previous, int index)
        {
            int deltaX = pointCurrent.X - previous.X;
            int deltaY = pointCurrent.Y - previous.Y;
            Points[index] = new Point(Points[index].X + deltaX, Points[index].Y + deltaY);
        }
    }
}
