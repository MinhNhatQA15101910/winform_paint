using System.Drawing;
using System.Drawing.Drawing2D;

namespace Paint.Model
{
    public class MyRectangle : Shape
    {
        public MyRectangle()
        {
            name = "Rectangle";
        }

        public override object Clone()
        {
            return new MyRectangle
            {
                pointHead = pointHead,
                pointTail = pointTail,
                contourWidth = contourWidth,
                isSelected = isSelected,
                color = color,
                name = name
            };
        }

        public override void DrawShape(Graphics g)
        {
            using (GraphicsPath path = graphicsPath)
            {
                if (isFill)
                {
                    using (Brush b = new SolidBrush(color))
                    {
                        g.FillPath(b, path);
                    }
                }
                else
                {
                    using (Pen p = new Pen(color, contourWidth))
                    {
                        g.DrawPath(p, path);
                    }
                }
            }
        }

        public override bool isHit(Point p)
        {
            bool inside = false;
            using (GraphicsPath path = graphicsPath)
            {
                if (isFill)
                {
                    inside = path.IsVisible(p);
                }
                else
                {
                    using (Pen pen = new Pen(color, contourWidth + 3))
                    {
                        inside = path.IsOutlineVisible(p, pen);
                    }
                }
            }

            return inside;
        }

        protected override GraphicsPath graphicsPath
        {
            get
            {
                GraphicsPath path = new GraphicsPath();

                if (pointTail.X < pointHead.X && pointTail.Y < pointHead.Y)
                {
                    path.AddRectangle(
                        new Rectangle(
                            pointTail,
                            new Size(pointHead.X - pointTail.X, pointHead.Y - pointTail.Y)
                            )
                        );
                }
                else if (pointHead.X > pointTail.X && pointHead.Y < pointTail.Y)
                {
                    path.AddRectangle(
                        new Rectangle(
                            new Point(pointTail.X, pointHead.Y),
                            new Size(pointHead.X - pointTail.X, pointTail.Y - pointHead.Y)
                            )
                        );
                }
                else if (pointHead.X < pointTail.X && pointHead.Y > pointTail.Y)
                {
                    path.AddRectangle(
                        new Rectangle(
                            new Point(pointHead.X, pointTail.Y),
                            new Size(pointTail.X - pointHead.X, pointHead.Y - pointTail.Y)
                            )
                        );
                }
                else
                {
                    path.AddRectangle(
                        new Rectangle(
                            pointHead,
                            new Size(pointTail.X - pointHead.X, pointTail.Y - pointHead.Y)
                            )
                        );
                }

                return path;
            }
        }
    }
}
