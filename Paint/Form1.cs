﻿using Paint.Presenter;
using Paint.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form, ViewPaint
    {
        private PresenterAlter presenterAlter;
        private PresenterDraw presenterDraw;
        private PresenterUpdate presenterUpdate;
        private Graphics gr;

        public Form1()
        {
            InitializeComponent();

            presenterAlter = new PresenterAlterImp(this);
            presenterDraw = new PresenterDrawImp(this);
            presenterUpdate = new PresenterUpdateImp(this);
            presenterUpdate.onClickSelectColor(pic_color.BackColor, gr);
            presenterUpdate.onClickSelectSize(tb_lineSize.Value + 1);
        }

        private void btn_rect_Click(object sender, EventArgs e)
        {
            presenterDraw.onClickDrawRectangle();
        }

        private void btn_line_Click(object sender, EventArgs e)
        {
            presenterDraw.onClickDrawLine();
        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            presenterDraw.GetDrawing(e.Graphics);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            presenterAlter.onClickClearAll(pic);
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                presenterUpdate.onClickSelectColor(colorDialog.Color, gr);
            }
        }

        private void btn_ellipse_Click(object sender, EventArgs e)
        {
            presenterDraw.onClickDrawEllipse();
        }

        private void color_picker_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = HelpFunction.SetPoint(color_picker, e.Location);
            pic_color.BackColor = ((Bitmap)color_picker.Image).GetPixel(point.X, point.Y);

            presenterUpdate.onClickSelectColor(pic_color.BackColor, gr);
        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            presenterDraw.onClickMouseDown(e.Location);
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_location.Text = e.Location.X + ", " + (e.Location.Y - 146) + "px";
            presenterDraw.onClickMouseMove(e.Location);
        }

        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            presenterDraw.onClickStopDrawing(e.Button);
        }

        private void btn_fill_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            presenterUpdate.onClickSelectFill(btn, gr);
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            presenterAlter.onClickOpenImage(pic);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            presenterAlter.onClickSaveImage(pic);
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            presenterAlter.onClickNewImage(pic);
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            presenterDraw.onClickMouseUp();
        }

        private void btn_eraser_Click(object sender, EventArgs e)
        {
            presenterDraw.onClickDrawEraser();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            presenterAlter.onUseKeyStrokes(pic, e.KeyCode);
        }

        private void btn_pencil_Click(object sender, EventArgs e)
        {
            presenterDraw.onClickDrawPen();
        }

        public void RefreshDrawing()
        {
            pic.Invalidate();
        }

        public void SetCursor(Cursor cursor)
        {
            pic.Cursor = cursor;
        }

        private void btn_group_Click(object sender, EventArgs e)
        {
            presenterAlter.onClickDrawGroup();
        }

        private void btn_polygon_Click(object sender, EventArgs e)
        {
            presenterDraw.onClickDrawPolygon();
        }

        private void btn_curve_Click(object sender, EventArgs e)
        {
            presenterDraw.onClickDrawBezier();
        }

        public void MovingControlPoint(Model.Shape shape, Point pointCurrent, Point previous, int indexPoint)
        {
            shape.MoveControlPoint(pointCurrent, previous, indexPoint);
            RefreshDrawing();
        }

        public void MovingShape(Model.Shape shape, Point distance)
        {
            shape.MoveShape(distance);
            RefreshDrawing();
        }

        private void btn_ungroup_Click(object sender, EventArgs e)
        {
            presenterAlter.onClickDrawUngroup();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            presenterAlter.onClickDeleteShape();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            presenterUpdate.onClickSelectMode();
        }

        private void tb_lineSize_Scroll(object sender, EventArgs e)
        {
            presenterUpdate.onClickSelectSize(tb_lineSize.Value + 1);
        }

        public void SetDrawing(Model.Shape shape, Graphics g)
        {
            shape.DrawShape(g);
        }

        public void SetDrawingLineSelected(Model.Shape shape, Brush brush, Graphics g)
        {
            g.FillRectangle(brush, new Rectangle(shape.pointHead.X - 4, shape.pointHead.Y - 4, 8, 8));
            g.FillRectangle(brush, new Rectangle(shape.pointHead.X - 4, shape.pointHead.Y - 4, 8, 8));
        }

        public void SetDrawingRegionRectangle(Pen p, Rectangle rectangle, Graphics g)
        {
            g.DrawRectangle(p, rectangle);
        }

        public void SetDrawingCurveSelected(List<Point> points, Brush brush, Graphics g)
        {
            for (int i = 0; i < points.Count; i++)
            {
                g.FillRectangle(brush, new Rectangle(points[i].X - 4, points[i].Y - 4, 8, 8));
            }
        }

        public void SetColor(Color color)
        {
            pic_color.BackColor = color;
        }

        public void SetColor(Button btn, Color color)
        {
            btn.BackColor = color;
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            presenterAlter.onClickCopyShape();
        }

        private void btn_cut_Click(object sender, EventArgs e)
        {
            presenterAlter.onClickCutShape();
        }

        private void btn_paste_Click(object sender, EventArgs e)
        {
            presenterAlter.onClickPasteShape();
        }
    }
}