using Paint.Model;
using System.Drawing;
using System.Windows.Forms;

namespace Paint.Utils
{
    public static class HelpFunction
    {
        public static Point SetPoint(PictureBox pb, Point pt)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }

        public static Rectangle GetRectangle(Point a, Point b)
        {
            if (a.X > b.X)
            {
                int temp = a.X;
                a.X = b.X;
                b.X = temp;
            }
            if (a.Y > b.Y)
            {
                int temp = a.Y;
                a.Y = b.Y;
                b.Y = temp;
            }
            return new Rectangle(a.X, a.Y, b.X - a.X, b.Y - a.Y);
        }

        public static bool isInside(Shape shape, Point p)
        {
            if (shape is MyPen)
            {
                MyPen pen = shape as MyPen;
                if (pen.isEraser) return false;
                return true;
            }
            return shape.isHit(p);
        }
    }
}
