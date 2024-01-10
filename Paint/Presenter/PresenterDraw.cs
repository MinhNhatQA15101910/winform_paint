using Paint.IPresenter;
using Paint.Model;
using Paint.Utils;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Paint.Presenter
{
    internal class PresenterDraw : IPresenterDraw
    {
        private readonly IViewPaint viewPaint;

        private readonly DataManager dataManager;

        public PresenterDraw(IViewPaint viewPaint)
        {
            this.viewPaint = viewPaint;
            dataManager = DataManager.GetInstance();
        }

        public void OnClickMouseDown(Point p)
        {
            dataManager.IsSave = false;
            dataManager.IsNotNone = true;
            if (dataManager.CurrentShape.Equals(CurrentShapeStatus.Void))
            {
                if (Control.ModifierKeys != Keys.Control)
                    dataManager.OffAllShapeSelected();
                viewPaint.RefreshDrawing();
                HandleClickToSelect(p);
            }
            else
            {
               HandleClickToDraw(p);
            }
        }

        public void HandleClickToSelect(Point p)
        {
            for (int i = 0; i < dataManager.ShapeList.Count; i++)
            {
                if (!(dataManager.ShapeList[i] is MyPen))
                    dataManager.PointToResize = dataManager.ShapeList[i].IsHitControlsPoint(p);
                if (dataManager.PointToResize != -1)
                {
                    dataManager.ShapeList[i].ChangePoint(dataManager.PointToResize);
                    dataManager.ShapeToMove = dataManager.ShapeList[i];
                    break;
                }
                else if (dataManager.ShapeList[i].IsHit(p))
                {
                    dataManager.ShapeToMove = dataManager.ShapeList[i];
                    dataManager.ShapeList[i].IsSelected = true;
                    if (dataManager.ShapeList[i] is MyPen && (dataManager.ShapeList[i] as MyPen).IsEraser)
                    {
                        dataManager.ShapeList[i].IsSelected = false;
                        dataManager.ShapeToMove = null;
                    }
                    break;
                }
            }

            if (dataManager.PointToResize != -1)
            {
                dataManager.CursorCurrent = p;
            }
            else if (dataManager.ShapeToMove != null)
            {
                dataManager.IsMovingShape = true;
                dataManager.CursorCurrent = p;
            }
            else
            {
                dataManager.IsMovingMouse = true;
                dataManager.RectangleRegion = new Rectangle(p, new Size(0, 0));
            }
        }

        public void HandleClickToDraw(Point p)
        {
            dataManager.IsMouseDown = true;
            dataManager.OffAllShapeSelected();
            if (dataManager.CurrentShape.Equals(CurrentShapeStatus.Line))
            {
                dataManager.AddEntity(new MyLine
                {
                    PointHead = p,
                    PointTail = p,
                    ContourWidth = dataManager.LineSize, 
                    Color = dataManager.ColorCurrent,
                    IsFill = dataManager.IsFill
                });
            }
            else if (dataManager.CurrentShape.Equals(CurrentShapeStatus.Rectangle))
            {
                dataManager.AddEntity(new MyRectangle
                {
                    PointHead = p,
                    PointTail = p,
                    ContourWidth = dataManager.LineSize,
                    Color = dataManager.ColorCurrent,
                    IsFill = dataManager.IsFill
                });
            }
            else if (dataManager.CurrentShape.Equals(CurrentShapeStatus.Ellipse))
            {
                dataManager.AddEntity(new MyEllipse
                {
                    PointHead = p,
                    PointTail = p,
                    ContourWidth = dataManager.LineSize,
                    Color = dataManager.ColorCurrent,
                    IsFill = dataManager.IsFill
                });
            }
            else if (dataManager.CurrentShape.Equals(CurrentShapeStatus.Curve))
            {
                if (!dataManager.IsDrawingCurve)
                {
                    dataManager.IsDrawingCurve = true;
                    MyCurve bezier = new MyCurve
                    {
                        Color = dataManager.ColorCurrent,
                        ContourWidth = dataManager.LineSize,
                        IsFill = dataManager.IsFill
                    };
                    bezier.Points.Add(p);
                    bezier.Points.Add(p);
                    dataManager.ShapeList.Add(bezier);
                }
                else
                {
                    MyCurve bezier = dataManager.ShapeList[dataManager.ShapeList.Count - 1] as MyCurve;
                    bezier.Points[bezier.Points.Count - 1] = p;
                    bezier.Points.Add(p);
                }
                dataManager.IsMouseDown = false;
            }
            else if (dataManager.CurrentShape.Equals(CurrentShapeStatus.Polygon))
            {
                if (!dataManager.IsDrawingPolygon)
                {
                    dataManager.IsDrawingPolygon = true;
                    MyPolygon polygon = new MyPolygon
                    {
                        Color = dataManager.ColorCurrent,
                        ContourWidth = dataManager.LineSize,
                        IsFill = dataManager.IsFill
                    };
                    polygon.Points.Add(p);
                    polygon.Points.Add(p);
                    dataManager.ShapeList.Add(polygon);
                }
                else
                {
                    MyPolygon polygon = dataManager.ShapeList[dataManager.ShapeList.Count - 1] as MyPolygon;
                    polygon.Points[polygon.Points.Count - 1] = p;
                    polygon.Points.Add(p);
                }
                dataManager.IsMouseDown = false;
            }
            else if (dataManager.CurrentShape.Equals(CurrentShapeStatus.Pen))
            {
                dataManager.IsDrawingPen = true;
                MyPen pen = new MyPen
                {
                    Color = dataManager.ColorCurrent,
                    ContourWidth = dataManager.LineSize,
                    IsFill = dataManager.IsFill
                };
                pen.Points.Add(p);
                pen.Points.Add(p);
                dataManager.ShapeList.Add(pen);
            }
            else if (dataManager.CurrentShape.Equals(CurrentShapeStatus.Eraser))
            {
                dataManager.IsDrawingEraser = true;
                MyPen pen = new MyPen
                {
                    Color = Color.White,
                    ContourWidth = dataManager.LineSize,
                    IsEraser = true
                };
                pen.Points.Add(p);
                pen.Points.Add(p);
                dataManager.ShapeList.Add(pen);
            }
        }

        public void OnClickMouseMove(Point p)
        {
            if (dataManager.IsMouseDown)
            {
                dataManager.UpdatePointTail(p);
                viewPaint.RefreshDrawing();
            }
            else if (dataManager.PointToResize != -1)
            {
                if (!(dataManager.ShapeToMove is GroupShape) && !(dataManager.ShapeToMove is MyPen))
                {
                    viewPaint.MovingControlPoint(
                        dataManager.ShapeToMove,
                        p,
                        dataManager.CursorCurrent,
                        dataManager.PointToResize
                        );
                    dataManager.CursorCurrent = p;
                }
            }
            else if (dataManager.IsMovingShape)
            {
                viewPaint.MovingShape(dataManager.ShapeToMove, dataManager.DistanceXY(dataManager.CursorCurrent, p));
                dataManager.CursorCurrent = p;
            }
            else if (dataManager.CurrentShape.Equals(CurrentShapeStatus.Void))
            {
                if (dataManager.IsMovingMouse)
                {
                    dataManager.UpdateRectangleRegion(p);
                    viewPaint.RefreshDrawing();
                }
                else
                {
                    if (dataManager.ShapeList.Exists(shape => HelpFunction.IsInside(shape, p)))
                    {
                        Shape existShape = dataManager.ShapeList.Find(shape => HelpFunction.IsInside(shape, p));
                        if (existShape.IsHitControlsPoint(p) != -1)
                        {
                            if (existShape.IsSelected)
                            {
                                int existIndex = existShape.IsHitControlsPoint(p);
                                if (existIndex == 0 || existIndex == 7)
                                {
                                    viewPaint.SetCursor(Cursors.SizeNWSE);
                                }
                                else if (existIndex == 1 || existIndex == 6)
                                {
                                    viewPaint.SetCursor(Cursors.SizeNS);
                                }
                                else if (existIndex == 2 || existIndex == 5)
                                {
                                    viewPaint.SetCursor(Cursors.SizeNESW);
                                }
                                else if (existIndex == 3 || existIndex == 4)
                                {
                                    viewPaint.SetCursor(Cursors.SizeWE);
                                }
                            }
                        }
                        else
                        {
                            viewPaint.SetCursor(Cursors.SizeAll);
                        }
                    }
                    else
                    {
                        viewPaint.SetCursor(Cursors.Default);
                    }
                }
            }

            if (dataManager.IsDrawingCurve)
            {
                MyCurve bezier = dataManager.ShapeList[dataManager.ShapeList.Count - 1] as MyCurve;
                bezier.Points[bezier.Points.Count - 1] = p;
                viewPaint.RefreshDrawing();
            }
            else if (dataManager.IsDrawingPolygon)
            {
                MyPolygon polygon = dataManager.ShapeList[dataManager.ShapeList.Count - 1] as MyPolygon;
                polygon.Points[polygon.Points.Count - 1] = p;
                viewPaint.RefreshDrawing();
            }
            else if (dataManager.IsDrawingPen || dataManager.IsDrawingEraser)
            {
                MyPen pen = dataManager.ShapeList[dataManager.ShapeList.Count - 1] as MyPen;
                pen.Points.Add(p);
                FindRegion.SetPointHeadTail(pen);
                viewPaint.RefreshDrawing();
            }
        }

        public void OnClickMouseUp()
        {
            dataManager.IsMouseDown = false;
            if (dataManager.PointToResize != -1)
            {
                dataManager.PointToResize = -1;
                dataManager.ShapeToMove = null;
            }
            else if (dataManager.IsMovingShape)
            {
                dataManager.IsMovingShape = false;
                dataManager.ShapeToMove = null;
            }
            else if (dataManager.IsMovingMouse)
            {
                dataManager.IsMovingMouse = false;
                dataManager.OffAllShapeSelected();

                // Check if the shape is in the region or not. If the shape is in 
                // the region, set IsSelected = true
                for (int i = 0; i < dataManager.ShapeList.Count; i++)
                {
                    if (dataManager.ShapeList[i].IsCollideWithRegion(dataManager.RectangleRegion))
                    {
                        dataManager.ShapeList[i].IsSelected = true;
                    }
                    if (dataManager.ShapeList[i] is MyPen)
                    {
                        MyPen pen = dataManager.ShapeList[i] as MyPen;
                        if (pen.IsEraser)
                            dataManager.ShapeList[i].IsSelected = false;
                    }
                }
                viewPaint.RefreshDrawing();
            }
            if (dataManager.IsDrawingPen)
            {
                dataManager.IsDrawingPen = false;
            }
            else if (dataManager.IsDrawingEraser)
            {
                dataManager.IsDrawingEraser = false;
            }
        }

        public void GetDrawing(Graphics g)
        {
            dataManager.ShapeList.ForEach(shape =>
            {
                viewPaint.SetDrawing(shape, g);
                if (shape.IsSelected)
                {
                    DrawRegionForShape(shape, g);
                }
            });
            if (dataManager.IsMovingMouse)
            {
                using (Pen pen = new Pen(Color.DarkBlue, 1)
                {
                    DashPattern = new float[] { 3, 3, 3, 3 }, 
                    DashStyle = DashStyle.Custom
                })
                {
                    viewPaint.SetDrawingRegionRectangle(pen, dataManager.RectangleRegion, g);
                }
            }
            if (dataManager.PointToResize != -1)
            {
                if (dataManager.ShapeToMove is GroupShape) return;
                DrawRegionForShape(dataManager.ShapeToMove, g);
            }
        }

        private void DrawRegionForShape(Shape shape, Graphics g)
        {
            if (shape is MyLine)
            {
                viewPaint.SetDrawingLineSelected(shape, new SolidBrush(Color.DarkBlue), g);
            }
            else if (shape is MyPen)
            {
                if (!(shape as MyPen).IsEraser)
                {
                    using (Pen pen = new Pen(Color.DarkBlue, 1)
                    {
                        DashPattern = new float[] { 3, 3, 3, 3 },
                        DashStyle = DashStyle.Custom
                    })
                    {
                        viewPaint.SetDrawingRegionRectangle(pen, shape.GetRectangle(), g);
                    }
                }
            }
            else if (shape is MyCurve)
            {
                MyCurve curve = shape as MyCurve;
                for (int i = 0; i < curve.Points.Count; i++)
                {
                    viewPaint.SetDrawingCurveSelected(curve.Points, new SolidBrush(Color.DarkBlue), g);
                }
            }
            else if (shape is MyPolygon)
            {
                MyPolygon polygon = shape as MyPolygon;
                for (int i = 0; i < polygon.Points.Count; i++)
                {
                    viewPaint.SetDrawingCurveSelected(polygon.Points, new SolidBrush(Color.DarkBlue), g);
                }
            }
            else
            {
                using (Pen pen = new Pen(Color.DarkBlue, 1)
                {
                    DashPattern = new float[] { 3, 3, 3, 3 },
                    DashStyle = DashStyle.Custom
                })
                {
                    viewPaint.SetDrawingRegionRectangle(pen, HelpFunction.GetRectangle(shape.PointHead, shape.PointTail), g);
                    viewPaint.SetDrawingCurveSelected(FindRegion.GetControlPoints(shape), new SolidBrush(Color.DarkBlue), g);
                }
            }
        }

        public void OnClickDrawLine()
        {
            SetDefaultToDraw();
            dataManager.CurrentShape = CurrentShapeStatus.Line;
        }

        public void OnClickDrawRectangle()
        {
            SetDefaultToDraw();
            dataManager.CurrentShape = CurrentShapeStatus.Rectangle;
        }

        public void OnClickDrawEllipse()
        {
            SetDefaultToDraw();
            dataManager.CurrentShape = CurrentShapeStatus.Ellipse;
        }

        public void OnClickDrawBezier()
        {
            SetDefaultToDraw();
            dataManager.CurrentShape = CurrentShapeStatus.Curve;
        }

        public void OnClickDrawPolygon()
        {
            SetDefaultToDraw();
            dataManager.CurrentShape = CurrentShapeStatus.Polygon;
        }

        public void OnClickDrawPen()
        {
            SetDefaultToDraw();
            dataManager.CurrentShape = CurrentShapeStatus.Pen;
        }

        public void OnClickDrawEraser()
        {
            SetDefaultToDraw();
            dataManager.CurrentShape = CurrentShapeStatus.Eraser;
        }

        public void OnClickStopDrawing(MouseButtons mouse)
        {
            if (mouse == MouseButtons.Right)
            {
                if (dataManager.CurrentShape.Equals(CurrentShapeStatus.Polygon))
                {
                    MyPolygon polygon = dataManager.ShapeList[dataManager.ShapeList.Count - 1] as MyPolygon;
                    polygon.Points.Remove(polygon.Points[polygon.Points.Count - 1]);
                    dataManager.IsDrawingPolygon = false;
                    FindRegion.SetPointHeadTail(polygon);
                }
                else if (dataManager.CurrentShape.Equals(CurrentShapeStatus.Curve))
                {
                    MyCurve curve = dataManager.ShapeList[dataManager.ShapeList.Count - 1] as MyCurve;
                    curve.Points.Remove(curve.Points[curve.Points.Count - 1]);
                    dataManager.IsDrawingCurve = false;
                    FindRegion.SetPointHeadTail(curve);
                }
            }
        }

        private void SetDefaultToDraw()
        {
            dataManager.OffAllShapeSelected();
            viewPaint.RefreshDrawing();
            viewPaint.SetCursor(Cursors.Default);
        }
    }
}
