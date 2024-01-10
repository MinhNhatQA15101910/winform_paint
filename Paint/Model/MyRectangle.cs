using System.Drawing;
using System.Drawing.Drawing2D;

namespace Paint.Model
{
    public class MyRectangle : Shape
    {
        public MyRectangle()
        {
            Name = "Rectangle";
        }

        public override object Clone()
        {
            return new MyRectangle
            {
                PointHead = PointHead,
                PointTail = PointTail,
                ContourWidth = ContourWidth,
                IsSelected = IsSelected,
                Color = Color,
                Name = Name
            };
        }

        public override void DrawShape(Graphics g)
        {
            using (GraphicsPath path = GraphicsPath)
            {
                if (IsFill)
                {
                    using (Brush b = new SolidBrush(Color))
                    {
                        g.FillPath(b, path);
                    }
                }
                else
                {
                    using (Pen p = new Pen(Color, ContourWidth))
                    {
                        g.DrawPath(p, path);
                    }
                }
            }
        }

        public override bool IsHit(Point p)
        {
            bool inside = false;
            using (GraphicsPath path = GraphicsPath)
            {
                if (IsFill)
                {
                    inside = path.IsVisible(p);
                }
                else
                {
                    using (Pen pen = new Pen(Color, ContourWidth + 3))
                    {
                        inside = path.IsOutlineVisible(p, pen);
                    }
                }
            }

            return inside;
        }

        protected override GraphicsPath GraphicsPath
        {
            get
            {
                GraphicsPath path = new GraphicsPath();

                if (PointTail.X < PointHead.X && PointTail.Y < PointHead.Y)
                {
                    path.AddRectangle(
                        new Rectangle(
                            PointTail,
                            new Size(PointHead.X - PointTail.X, PointHead.Y - PointTail.Y)
                            )
                        );
                }
                else if (PointHead.X > PointTail.X && PointHead.Y < PointTail.Y)
                {
                    path.AddRectangle(
                        new Rectangle(
                            new Point(PointTail.X, PointHead.Y),
                            new Size(PointHead.X - PointTail.X, PointTail.Y - PointHead.Y)
                            )
                        );
                }
                else if (PointHead.X < PointTail.X && PointHead.Y > PointTail.Y)
                {
                    path.AddRectangle(
                        new Rectangle(
                            new Point(PointHead.X, PointTail.Y),
                            new Size(PointTail.X - PointHead.X, PointHead.Y - PointTail.Y)
                            )
                        );
                }
                else
                {
                    path.AddRectangle(
                        new Rectangle(
                            PointHead,
                            new Size(PointTail.X - PointHead.X, PointTail.Y - PointHead.Y)
                            )
                        );
                }

                return path;
            }
        }
    }
}
