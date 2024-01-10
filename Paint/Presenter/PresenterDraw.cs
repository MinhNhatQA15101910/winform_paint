﻿using System.Drawing;
using System.Windows.Forms;

namespace Paint.Presenter
{
    interface PresenterDraw
    {
        void GetDrawing(Graphics g);
        void onClickMouseDown(Point p);
        void onClickMouseMove(Point p);
        void onClickMouseUp();
        void onClickDrawLine();
        void onClickDrawRectangle();
        void onClickDrawEllipse();
        void onClickDrawBezier();
        void onClickDrawPolygon();
        void onClickDrawPen();
        void onClickDrawEraser();
        void onClickStopDrawing(MouseButtons mouse);

    }
}
