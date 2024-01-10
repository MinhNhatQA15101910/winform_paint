using Paint.Utils;
using System.Collections.Generic;
using System.Drawing;

namespace Paint.Model
{
    internal class DataManager
    {
        public static DataManager instance;

        public List<Shape> shapeList { get; set; }
        public List<Shape> savedShapes { get; set; }
        public Shape shapeToMove { get; set; }
        public Rectangle rectangleRegion;
        public bool isMouseDown { get; set; }
        public bool isMovingShape { get; set; }
        public bool isMovingMouse { get; set; }
        public bool isDrawingCurve { get; set; }
        public bool isDrawingPolygon { get; set; }
        public bool isDrawingPen { get; set; }
        public bool isDrawingEraser { get; set; }
        public bool isFill { get; set; }
        public bool isSave { get; set; }
        public bool isNotNone { get; set; }
        public int pointToResize { get; set; }
        public CurrentShapeStatus currentShape { get; set; }
        public Point cursorCurrent { get; set; }
        public Color colorCurrent { get; set; }
        public int lineSize { get; set; }

        private DataManager()
        {
            shapeList = new List<Shape>();
            savedShapes = new List<Shape>();
            pointToResize = -1;
        }

        public static DataManager getInstance()
        {
            if (instance == null) instance = new DataManager();
            return instance;
        }

        public void UpdatePointTail(Point p)
        {
            shapeList[shapeList.Count - 1].pointTail = p;
        }

        public void AddEntity(Shape shape)
        {
            shapeList.Add(shape);
        }

        public void AddSavedShapes(Shape shape)
        {
            savedShapes.Add(shape);
        }

        public void RemoveSavedShapes()
        {
            savedShapes.Clear();
        } 

        public void offAllShapeSelected()
        {
            shapeList.ForEach(shape => shape.isSelected = false);
        }

        public Point distanceXY(Point x, Point y)
        {
            return new Point(y.X - x.X, y.Y - x.Y);
        }

        public void UpdateRectangleRegion(Point p)
        {
            rectangleRegion.Width = p.X - rectangleRegion.X;
            rectangleRegion.Height = p.Y - rectangleRegion.Y;
        }
    }
}
