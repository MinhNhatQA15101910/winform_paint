using Paint.IPresenter;
using Paint.Presenter;
using Paint.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Windows.Forms;

namespace Paint
{
    public partial class MainForm : Form, IViewPaint
    {
        #region Services
        private readonly IPresenterAlter _presenterAlter;
        private readonly IPresenterDraw _presenterDraw;
        private readonly IPresenterUpdate _presenterUpdate;
        private readonly Graphics _graphics;
        #endregion

        #region Constructor
        public MainForm()
        {
            InitializeComponent();

            _graphics = CreateGraphics();

            _presenterAlter = new PresenterAlter(this);
            _presenterDraw = new PresenterDraw(this);
            _presenterUpdate = new PresenterUpdate(this);
            _presenterUpdate.OnClickSelectColor(btnColorDisplay.BackColor, _graphics);
            _presenterUpdate.OnClickSelectSize(trbLineSize.Value + 1);
        }
        #endregion

        #region Implement IViewPaint
        public void RefreshDrawing()
        {
            pic.Invalidate();
        }

        public void SetCursor(Cursor cursor)
        {
            pic.Cursor = cursor;
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

        public void SetDrawing(Model.Shape shape, Graphics g)
        {
            shape.DrawShape(g);
        }

        public void SetDrawingLineSelected(Model.Shape shape, Brush brush, Graphics g)
        {
            g.FillRectangle(brush, new Rectangle(shape.PointHead.X - 4, shape.PointHead.Y - 4, 8, 8));
            g.FillRectangle(brush, new Rectangle(shape.PointHead.X - 4, shape.PointHead.Y - 4, 8, 8));
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
            btnColorDisplay.BackColor = color;
        }

        public void SetColor(Button btn, Color color)
        {
            btn.BackColor = color;
        }
        #endregion

        #region Event Handler
        private void OnBtnNewClicked(object sender, EventArgs e)
        {
            _presenterAlter.OnClickNewImage(pic);
        }

        private void OnBtnSaveClicked(object sender, EventArgs e)
        {
            _presenterAlter.OnClickSaveImage(pic);
        }

        private void OnBtnRectClicked(object sender, EventArgs e)
        {
            _presenterDraw.OnClickDrawRectangle();
        }

        private void OnBtnLineClicked(object sender, EventArgs e)
        {
            _presenterDraw.OnClickDrawLine();
        }

        private void OnPicPainted(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            _presenterDraw.GetDrawing(e.Graphics);
        }

        private void OnBtnClearClicked(object sender, EventArgs e)
        {
            _presenterAlter.OnClickClearAll(pic);
        }

        private void OnBtnColorClicked(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _presenterUpdate.OnClickSelectColor(colorDialog.Color, _graphics);
            }
        }

        private void OnBtnEllipseClicked(object sender, EventArgs e)
        {
            _presenterDraw.OnClickDrawEllipse();
        }

        private void OnColorPickerMouseClicked(object sender, MouseEventArgs e)
        {
            Point Point = HelpFunction.SetPoint(colorPicker, e.Location);
            btnColorDisplay.BackColor = ((Bitmap)colorPicker.Image).GetPixel(Point.X, Point.Y);

            _presenterUpdate.OnClickSelectColor(btnColorDisplay.BackColor, _graphics);
        }

        private void OnPicMouseDown(object sender, MouseEventArgs e)
        {
            _presenterDraw.OnClickMouseDown(e.Location);
        }

        private void OnPicMouseMoved(object sender, MouseEventArgs e)
        {
            lblLocation.Text = e.Location.X + ", " + (e.Location.Y - 146) + "px";
            _presenterDraw.OnClickMouseMove(e.Location);
        }

        private void OnPicMouseClicked(object sender, MouseEventArgs e)
        {
            _presenterDraw.OnClickStopDrawing(e.Button);
        }

        private void OnBtnFillClicked(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            _presenterUpdate.OnClickSelectFill(btn, _graphics);
        }

        private void OnBtnOpenClicked(object sender, EventArgs e)
        {
            _presenterAlter.OnClickOpenImage(pic);
        }

        private void OnPicMouseUp(object sender, MouseEventArgs e)
        {
            _presenterDraw.OnClickMouseUp();
        }

        private void OnBtnEraserClicked(object sender, EventArgs e)
        {
            _presenterDraw.OnClickDrawEraser();
        }

        private void OnForm1KeyDown(object sender, KeyEventArgs e)
        {
            _presenterAlter.OnUseKeyStrokes(e.KeyCode);
        }

        private void OnBtnPenClicked(object sender, EventArgs e)
        {
            _presenterDraw.OnClickDrawPen();
        }

        private void OnBtnGroupClicked(object sender, EventArgs e)
        {
            _presenterAlter.OnClickDrawGroup();
        }

        private void OnBtnPolygonClicked(object sender, EventArgs e)
        {
            _presenterDraw.OnClickDrawPolygon();
        }

        private void OnBtnCurveClicked(object sender, EventArgs e)
        {
            _presenterDraw.OnClickDrawBezier();
        }

        private void OnBtnUngroupClicked(object sender, EventArgs e)
        {
            _presenterAlter.OnClickDrawUngroup();
        }

        private void OnBtnDeleteClicked(object sender, EventArgs e)
        {
            _presenterAlter.OnClickDeleteShape();
        }

        private void OnBtnSelectClicked(object sender, EventArgs e)
        {
            _presenterUpdate.OnClickSelectMode();
        }

        private void OnTrbLineSizeScrolled(object sender, EventArgs e)
        {
            _presenterUpdate.OnClickSelectSize(trbLineSize.Value + 1);
        }

        private void OnBtnCopyClicked(object sender, EventArgs e)
        {
            _presenterAlter.OnClickCopyShape();
        }

        private void OnBtnCutClicked(object sender, EventArgs e)
        {
            _presenterAlter.OnClickCutShape();
        }

        private void OnBtnPasteClicked(object sender, EventArgs e)
        {
            _presenterAlter.OnClickPasteShape();
        }

        private void OnUpdateClicked(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            var client = new WebClient();

            if (!webClient.DownloadString("").Contains("1.0.0"))
            {
                var result = MessageBox.Show("New update available! Do you want to install it?", "Paint", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (File.Exists(@".\PaintSetup.msi"))
                        {
                            File.Delete(@".\PaintSetup.msi");
                        }

                        client.DownloadFile("", @"PaintSetup.zip");
                        string zipPath = @".\PaintSetup.zip";
                        string extractPath = @".\";
                        ZipFile.ExtractToDirectory(zipPath, extractPath);

                        Process process = new Process();
                        process.StartInfo.FileName = "msiexec";
                        process.StartInfo.Arguments = string.Format("/i PaintSetup.msi");

                        Close();
                        process.Start();
                    }
                    catch
                    {
                        // Do nothing
                    }
                }
            }
        }
        #endregion
    }
}
