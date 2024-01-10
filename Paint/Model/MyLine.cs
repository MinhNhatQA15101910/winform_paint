using System.Drawing;
using System.Drawing.Drawing2D;

namespace Paint.Model
{
    public class MyLine : Shape
    {
        public MyLine()
        {
            Name = "line";
        }
        public override object Clone()
        {
            return new MyLine
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
                using (Pen pen = new Pen(Color, ContourWidth))
                {
                    g.DrawPath(pen, path);
                }
            }
        }
        protected override GraphicsPath GraphicsPath
        {
            get
            {
                GraphicsPath path = new GraphicsPath();
                path.AddLine(PointHead, PointTail);
                return path;
            }
        }
        public override bool IsHit(Point p)
        {
            bool inside = false;
            using (GraphicsPath path = GraphicsPath)
            {
                using (Pen pen = new Pen(Color, ContourWidth + 3))
                {
                    inside = path.IsOutlineVisible(p, pen);
                }
            }
            return inside;
        }
        public override int IsHitControlsPoint(Point p)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddRectangle(new Rectangle(PointHead.X - 4, PointHead.Y - 4, 8, 8));
            if (path.IsVisible(p)) return 0;
            path.AddRectangle(new Rectangle(PointTail.X - 4, PointTail.Y - 4, 8, 8));
            if (path.IsVisible(p)) return 7;
            return -1;
        }
    }
}
