using Paint.Model;
using Paint.Utils;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Paint.Presenter
{
    internal class PresenterDrawImp : PresenterDraw
    {
        ViewPaint viewPaint;

        DataManager dataManager;

        public PresenterDrawImp(ViewPaint viewPaint)
        {
            this.viewPaint = viewPaint;
            dataManager = DataManager.getInstance();
        }

        public void onClickMouseDown(Point p)
        {
            dataManager.isSave = false;
            dataManager.isNotNone = true;
            if (dataManager.currentShape.Equals(CurrentShapeStatus.Void))
            {
                if (!(Control.ModifierKeys == Keys.Control))
                    dataManager.offAllShapeSelected();
                viewPaint.RefreshDrawing();
                handleClickToSelect(p);
            }
            else
            {
                handleClickToDraw(p);
            }
        }

        public void handleClickToSelect(Point p)
        {
            for (int i = 0; i < dataManager.shapeList.Count; i++)
            {
                if (!(dataManager.shapeList[i] is MyPen))
                    dataManager.pointToResize = dataManager.shapeList[i].isHitControlsPoint(p);
                if (dataManager.pointToResize != -1)
                {
                    dataManager.shapeList[i].ChangePoint(dataManager.pointToResize);
                    dataManager.shapeToMove = dataManager.shapeList[i];
                    break;
                }
                else if (dataManager.shapeList[i].isHit(p))
                {
                    dataManager.shapeToMove = dataManager.shapeList[i];
                    dataManager.shapeList[i].isSelected = true;
                    if (dataManager.shapeList[i] is MyPen)
                    {
                        if (((MyPen)dataManager.shapeList[i]).isEraser)
                        {
                            dataManager.shapeList[i].isSelected = false;
                            dataManager.shapeToMove = null;
                        }
                    }
                    break;
                }
            }

            if (dataManager.pointToResize != -1)
            {
                dataManager.cursorCurrent = p;
            }
            else if (dataManager.shapeToMove != null)
            {
                dataManager.isMovingShape = true;
                dataManager.cursorCurrent = p;
            }
            else
            {
                dataManager.isMovingMouse = true;
                dataManager.rectangleRegion = new Rectangle(p, new Size(0, 0));
            }
        }

        public void handleClickToDraw(Point p)
        {
            dataManager.isMouseDown = true;
            dataManager.offAllShapeSelected();
            if (dataManager.currentShape.Equals(CurrentShapeStatus.Line))
            {
                dataManager.AddEntity(new MyLine
                {
                    pointHead = p,
                    pointTail = p,
                    contourWidth = dataManager.lineSize, 
                    color = dataManager.colorCurrent,
                    isFill = dataManager.isFill
                });
            }
            else if (dataManager.currentShape.Equals(CurrentShapeStatus.Rectangle))
            {
                dataManager.AddEntity(new MyRectangle
                {
                    pointHead = p,
                    pointTail = p,
                    contourWidth = dataManager.lineSize,
                    color = dataManager.colorCurrent,
                    isFill = dataManager.isFill
                });
            }
            else if (dataManager.currentShape.Equals(CurrentShapeStatus.Ellipse))
            {
                dataManager.AddEntity(new MyEllipse
                {
                    pointHead = p,
                    pointTail = p,
                    contourWidth = dataManager.lineSize,
                    color = dataManager.colorCurrent,
                    isFill = dataManager.isFill
                });
            }
            else if (dataManager.currentShape.Equals(CurrentShapeStatus.Curve))
            {
                if (!dataManager.isDrawingCurve)
                {
                    dataManager.isDrawingCurve = true;
                    MyCurve bezier = new MyCurve
                    {
                        color = dataManager.colorCurrent,
                        contourWidth = dataManager.lineSize,
                        isFill = dataManager.isFill
                    };
                    bezier.points.Add(p);
                    bezier.points.Add(p);
                    dataManager.shapeList.Add(bezier);
                }
                else
                {
                    MyCurve bezier = dataManager.shapeList[dataManager.shapeList.Count - 1] as MyCurve;
                    bezier.points[bezier.points.Count - 1] = p;
                    bezier.points.Add(p);
                }
                dataManager.isMouseDown = false;
            }
            else if (dataManager.currentShape.Equals(CurrentShapeStatus.Polygon))
            {
                if (!dataManager.isDrawingPolygon)
                {
                    dataManager.isDrawingPolygon = true;
                    MyPolygon polygon = new MyPolygon
                    {
                        color = dataManager.colorCurrent,
                        contourWidth = dataManager.lineSize,
                        isFill = dataManager.isFill
                    };
                    polygon.points.Add(p);
                    polygon.points.Add(p);
                    dataManager.shapeList.Add(polygon);
                }
                else
                {
                    MyPolygon polygon = dataManager.shapeList[dataManager.shapeList.Count - 1] as MyPolygon;
                    polygon.points[polygon.points.Count - 1] = p;
                    polygon.points.Add(p);
                }
                dataManager.isMouseDown = false;
            }
            else if (dataManager.currentShape.Equals(CurrentShapeStatus.Pen))
            {
                dataManager.isDrawingPen = true;
                MyPen pen = new MyPen
                {
                    color = dataManager.colorCurrent,
                    contourWidth = dataManager.lineSize,
                    isFill = dataManager.isFill
                };
                pen.points.Add(p);
                pen.points.Add(p);
                dataManager.shapeList.Add(pen);
            }
            else if (dataManager.currentShape.Equals(CurrentShapeStatus.Eraser))
            {
                dataManager.isDrawingEraser = true;
                MyPen pen = new MyPen
                {
                    color = Color.White,
                    contourWidth = dataManager.lineSize
                };
                pen.isEraser = true;
                pen.points.Add(p);
                pen.points.Add(p);
                dataManager.shapeList.Add(pen);
            }
        }

        public void onClickMouseMove(Point p)
        {
            if (dataManager.isMouseDown)
            {
                dataManager.UpdatePointTail(p);
                viewPaint.RefreshDrawing();
            }
            else if (dataManager.pointToResize != -1)
            {
                if (!(dataManager.shapeToMove is GroupShape) && !(dataManager.shapeToMove is MyPen))
                {
                    viewPaint.MovingControlPoint(
                        dataManager.shapeToMove,
                        p,
                        dataManager.cursorCurrent,
                        dataManager.pointToResize
                        );
                    dataManager.cursorCurrent = p;
                }
            }
            else if (dataManager.isMovingShape)
            {
                viewPaint.MovingShape(dataManager.shapeToMove, dataManager.distanceXY(dataManager.cursorCurrent, p));
                dataManager.cursorCurrent = p;
            }
            else if (dataManager.currentShape.Equals(CurrentShapeStatus.Void))
            {
                if (dataManager.isMovingMouse)
                {
                    dataManager.UpdateRectangleRegion(p);
                    viewPaint.RefreshDrawing();
                }
                else
                {
                    if (dataManager.shapeList.Exists(shape => HelpFunction.isInside(shape, p)))
                    {
                        Shape existShape = dataManager.shapeList.Find(shape => HelpFunction.isInside(shape, p));
                        if (existShape.isHitControlsPoint(p) != -1)
                        {
                            if (existShape.isSelected)
                            {
                                int existIndex = existShape.isHitControlsPoint(p);
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

            if (dataManager.isDrawingCurve)
            {
                MyCurve bezier = dataManager.shapeList[dataManager.shapeList.Count - 1] as MyCurve;
                bezier.points[bezier.points.Count - 1] = p;
                viewPaint.RefreshDrawing();
            }
            else if (dataManager.isDrawingPolygon)
            {
                MyPolygon polygon = dataManager.shapeList[dataManager.shapeList.Count - 1] as MyPolygon;
                polygon.points[polygon.points.Count - 1] = p;
                viewPaint.RefreshDrawing();
            }
            else if (dataManager.isDrawingPen)
            {
                MyPen pen = dataManager.shapeList[dataManager.shapeList.Count - 1] as MyPen;
                pen.points.Add(p);
                FindRegion.SetPointHeadTail(pen);
                viewPaint.RefreshDrawing();
            }
            else if (dataManager.isDrawingEraser)
            {
                MyPen pen = dataManager.shapeList[dataManager.shapeList.Count - 1] as MyPen;
                pen.points.Add(p);
                FindRegion.SetPointHeadTail(pen);
                viewPaint.RefreshDrawing();
            }
        }

        public void onClickMouseUp()
        {
            dataManager.isMouseDown = false;
            if (dataManager.pointToResize != -1)
            {
                dataManager.pointToResize = -1;
                dataManager.shapeToMove = null;
            }
            else if (dataManager.isMovingShape)
            {
                dataManager.isMovingShape = false;
                dataManager.shapeToMove = null;
            }
            else if (dataManager.isMovingMouse)
            {
                dataManager.isMovingMouse = false;
                dataManager.offAllShapeSelected();

                // Check if the shape is in the region or not. If the shape is in 
                // the region, set isSelected = true
                for (int i = 0; i < dataManager.shapeList.Count; i++)
                {
                    if (dataManager.shapeList[i].isCollideWithRegion(dataManager.rectangleRegion))
                    {
                        dataManager.shapeList[i].isSelected = true;
                    }
                    if (dataManager.shapeList[i] is MyPen)
                    {
                        MyPen pen = dataManager.shapeList[i] as MyPen;
                        if (pen.isEraser)
                            dataManager.shapeList[i].isSelected = false;
                    }
                }
                viewPaint.RefreshDrawing();
            }
            if (dataManager.isDrawingPen)
            {
                dataManager.isDrawingPen = false;
            }
            else if (dataManager.isDrawingEraser)
            {
                dataManager.isDrawingEraser = false;
            }
        }

        public void GetDrawing(Graphics g)
        {
            dataManager.shapeList.ForEach(shape =>
            {
                viewPaint.SetDrawing(shape, g);
                if (shape.isSelected)
                {
                    DrawRegionForShape(shape, g);
                }
            });
            if (dataManager.isMovingMouse)
            {
                using (Pen pen = new Pen(Color.DarkBlue, 1)
                {
                    DashPattern = new float[] { 3, 3, 3, 3 }, 
                    DashStyle = DashStyle.Custom
                })
                {
                    viewPaint.SetDrawingRegionRectangle(pen, dataManager.rectangleRegion, g);
                }
            }
            if (dataManager.pointToResize != -1)
            {
                if (dataManager.shapeToMove is GroupShape) return;
                DrawRegionForShape(dataManager.shapeToMove, g);
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
                if (!((MyPen)shape).isEraser)
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
                MyCurve curve = (MyCurve)shape;
                for (int i = 0; i < curve.points.Count; i++)
                {
                    viewPaint.SetDrawingCurveSelected(curve.points, new SolidBrush(Color.DarkBlue), g);
                }
            }
            else if (shape is MyPolygon)
            {
                MyPolygon polygon = (MyPolygon)shape;
                for (int i = 0; i < polygon.points.Count; i++)
                {
                    viewPaint.SetDrawingCurveSelected(polygon.points, new SolidBrush(Color.DarkBlue), g);
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
                    viewPaint.SetDrawingRegionRectangle(pen, HelpFunction.GetRectangle(shape.pointHead, shape.pointTail), g);
                    viewPaint.SetDrawingCurveSelected(FindRegion.GetControlPoints(shape), new SolidBrush(Color.DarkBlue), g);
                }
            }
        }

        public void onClickDrawLine()
        {
            SetDefaultToDraw();
            dataManager.currentShape = CurrentShapeStatus.Line;
        }

        public void onClickDrawRectangle()
        {
            SetDefaultToDraw();
            dataManager.currentShape = CurrentShapeStatus.Rectangle;
        }

        public void onClickDrawEllipse()
        {
            SetDefaultToDraw();
            dataManager.currentShape = CurrentShapeStatus.Ellipse;
        }

        public void onClickDrawBezier()
        {
            SetDefaultToDraw();
            dataManager.currentShape = CurrentShapeStatus.Curve;
        }

        public void onClickDrawPolygon()
        {
            SetDefaultToDraw();
            dataManager.currentShape = CurrentShapeStatus.Polygon;
        }

        public void onClickDrawPen()
        {
            SetDefaultToDraw();
            dataManager.currentShape = CurrentShapeStatus.Pen;
        }

        public void onClickDrawEraser()
        {
            SetDefaultToDraw();
            dataManager.currentShape = CurrentShapeStatus.Eraser;
        }

        public void onClickStopDrawing(MouseButtons mouse)
        {
            if (mouse == MouseButtons.Right)
            {
                if (dataManager.currentShape.Equals(CurrentShapeStatus.Polygon))
                {
                    MyPolygon polygon = dataManager.shapeList[dataManager.shapeList.Count - 1] as MyPolygon;
                    polygon.points.Remove(polygon.points[polygon.points.Count - 1]);
                    dataManager.isDrawingPolygon = false;
                    FindRegion.SetPointHeadTail(polygon);
                }
                else if (dataManager.currentShape.Equals(CurrentShapeStatus.Curve))
                {
                    MyCurve curve = dataManager.shapeList[dataManager.shapeList.Count - 1] as MyCurve;
                    curve.points.Remove(curve.points[curve.points.Count - 1]);
                    dataManager.isDrawingCurve = false;
                    FindRegion.SetPointHeadTail(curve);
                }
            }
        }

        private void SetDefaultToDraw()
        {
            dataManager.offAllShapeSelected();
            viewPaint.RefreshDrawing();
            viewPaint.SetCursor(Cursors.Default);
        }
    }
}
