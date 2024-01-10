using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Paint.Model
{
    public class MyCurve : Shape
    {
        public List<Point> Points { get; set; }

        public MyCurve()
        {
            name = "Curve";
            Points = new List<Point>();
        }
        public override object Clone()
        {
            MyCurve curve = new MyCurve
            {
                pointHead = pointHead,
                pointTail = pointTail,
                isSelected = isSelected,
                name = name,
                color = color,
                contourWidth = contourWidth,
            };
            Points.ForEach(point => curve.Points.Add(point));
            return curve;
        }
        public override void DrawShape(Graphics g)
        {
            using (GraphicsPath path = graphicsPath)
            {
                using (Pen pen = new Pen(color, contourWidth))
                {
                    g.DrawPath(pen, path);
                }
            }
        }
        public override bool isHit(Point p)
        {
            bool inside = false;
            using (GraphicsPath path = graphicsPath)
            {
                using (Pen pen = new Pen(color, contourWidth + 3))
                {
                    inside = path.IsOutlineVisible(p, pen);
                }
            }
            return inside;
        }
        protected override GraphicsPath graphicsPath
        {
            get
            {
                GraphicsPath path = new GraphicsPath();
                path.AddCurve(Points.ToArray());

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
        public override int isHitControlsPoint(Point p)
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
