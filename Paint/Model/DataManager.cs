using Paint.Utils;
using System.Collections.Generic;
using System.Drawing;

namespace Paint.Model
{
    internal class DataManager
    {
        public static DataManager Instance { get; set; }

        public List<Shape> ShapeList { get; set; } = new List<Shape>();
        public List<Shape> SavedShapes { get; set; } = new List<Shape>();
        public Shape ShapeToMove { get; set; }
        public Rectangle RectangleRegion;
        public bool IsMouseDown { get; set; }
        public bool IsMovingShape { get; set; }
        public bool IsMovingMouse { get; set; }
        public bool IsDrawingCurve { get; set; }
        public bool IsDrawingPolygon { get; set; }
        public bool IsDrawingPen { get; set; }
        public bool IsDrawingEraser { get; set; }
        public bool IsFill { get; set; }
        public bool IsSave { get; set; }
        public bool IsNotNone { get; set; }
        public int PointToResize { get; set; } = -1;
        public CurrentShapeStatus CurrentShape { get; set; }
        public Point CursorCurrent { get; set; }
        public Color ColorCurrent { get; set; }
        public int LineSize { get; set; }

        public static DataManager GetInstance()
        {
            if (Instance == null) Instance = new DataManager();
            return Instance;
        }

        public void UpdatePointTail(Point p)
        {
            ShapeList[ShapeList.Count - 1].PointTail = p;
        }

        public void AddEntity(Shape shape)
        {
            ShapeList.Add(shape);
        }

        public void AddSavedShapes(Shape shape)
        {
            SavedShapes.Add(shape);
        }

        public void RemoveSavedShapes()
        {
            SavedShapes.Clear();
        } 

        public void OffAllShapeSelected()
        {
            ShapeList.ForEach(shape => shape.IsSelected = false);
        }

        public Point DistanceXY(Point x, Point y)
        {
            return new Point(y.X - x.X, y.Y - x.Y);
        }

        public void UpdateRectangleRegion(Point p)
        {
            RectangleRegion.Width = p.X - RectangleRegion.X;
            RectangleRegion.Height = p.Y - RectangleRegion.Y;
        }
    }
}
