using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Paint.Model
{
    public class MyCurve : Shape
    {
        public List<Point> points;

        public MyCurve()
        {
            name = "Curve";
            points = new List<Point>();
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
            points.ForEach(point => curve.points.Add(point));
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
                path.AddCurve(points.ToArray());

                return path;
            }
        }
        public override void MoveShape(Point distance)
        {
            base.MoveShape(distance);
            for (int i = 0; i < points.Count; i++)
            {
                points[i] = new Point(points[i].X + distance.X, points[i].Y + distance.Y);
            }
        }
        public override int isHitControlsPoint(Point p)
        {
            for (int i = 0; i < points.Count; i++)
            {
                GraphicsPath path = new GraphicsPath();
                path.AddRectangle(new Rectangle(points[i].X - 4, points[i].Y - 4, 8, 8));
                if (path.IsVisible(p)) return i;
            }
            return -1;
        }
        public override void MoveControlPoint(Point pointCurrent, Point previous, int index)
        {
            int deltaX = pointCurrent.X - previous.X;
            int deltaY = pointCurrent.Y - previous.Y;
            points[index] = new Point(points[index].X + deltaX, points[index].Y + deltaY);
        }
    }
}
