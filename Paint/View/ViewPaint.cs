using Paint.Model;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    interface ViewPaint
    {
        void RefreshDrawing();
        void SetCursor(Cursor cursor);
        void SetColor(Color color);
        void SetColor(Button btn, Color color);
        void SetDrawing(Shape shape, Graphics g);
        void SetDrawingLineSelected(Shape shape, Brush brush, Graphics g);
        void SetDrawingCurveSelected(List<Point> points, Brush brush, Graphics g);
        void SetDrawingRegionRectangle(Pen p, Rectangle rectangle, Graphics g);
        void MovingShape(Shape shape, Point distance);
        void MovingControlPoint(Shape shape, Point pointCurrent, Point previous, int indexPoint);
    }
}
