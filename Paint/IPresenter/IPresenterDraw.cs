using System.Drawing;
using System.Windows.Forms;

namespace Paint.IPresenter
{
    public interface IPresenterDraw
    {
        void GetDrawing(Graphics g);
        void OnClickMouseDown(Point p);
        void OnClickMouseMove(Point p);
        void OnClickMouseUp();
        void OnClickDrawLine();
        void OnClickDrawRectangle();
        void OnClickDrawEllipse();
        void OnClickDrawBezier();
        void OnClickDrawPolygon();
        void OnClickDrawPen();
        void OnClickDrawEraser();
        void OnClickStopDrawing(MouseButtons mouse);
    }
}
