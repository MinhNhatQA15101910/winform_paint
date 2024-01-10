using Paint.Model;
using System.Collections.Generic;
using System.Drawing;

namespace Paint.Utils
{
    public static class FindRegion
    {
        // Set PointHead and PointTail for GroupShape
        public static void SetPointHeadTail(GroupShape group)
        {
            int minX = int.MaxValue, minY = int.MaxValue;
            int maxX = int.MinValue, maxY = int.MinValue;

            for (int i = 0; i < group.Count; i++)
            {
                Shape shape = group[i];

                if (shape.PointHead.X < minX)
                {
                    minX = shape.PointHead.X;
                }
                if (shape.PointTail.X < minX)
                {
                    minX = shape.PointTail.X;
                }

                if (shape.PointHead.Y < minY)
                {
                    minY = shape.PointHead.Y;
                }
                if (shape.PointTail.Y < minY)
                {
                    minY = shape.PointTail.Y;
                }

                if (shape.PointHead.X > maxX)
                {
                    maxX = shape.PointHead.X;
                }
                if (shape.PointTail.X > maxX)
                {
                    maxX = shape.PointTail.X;
                }

                if (shape.PointHead.Y > maxY)
                {
                    maxY = shape.PointHead.Y;
                }
                if (shape.PointTail.Y > maxY)
                {
                    maxY = shape.PointTail.Y;
                }
            }
            group.PointHead = new Point(minX, minY);
            group.PointTail = new Point(maxX, maxY);
        }

        // Set PointHead and PointTail for MyCurve
        public static void SetPointHeadTail(MyCurve curve)
        {
            int minX = int.MaxValue, minY = int.MaxValue;
            int maxX = int.MinValue, maxY = int.MinValue;
            curve.Points.ForEach(p =>
            {
                if (minX > p.X) minX = p.X;
                if (minY > p.Y) minY = p.Y;
                if (maxX < p.X) maxX = p.X;
                if (maxY < p.Y) maxY = p.Y;
            });
            curve.PointHead = new Point(minX, minY);
            curve.PointTail = new Point(maxX, maxY);
        }

        // Set PointHead and PointTail for MyPolygon
        public static void SetPointHeadTail(MyPolygon polygon)
        {
            int minX = int.MaxValue, minY = int.MaxValue;
            int maxX = int.MinValue, maxY = int.MinValue;
            polygon.Points.ForEach(p =>
            {
                if (minX > p.X) minX = p.X;
                if (minY > p.Y) minY = p.Y;
                if (maxX < p.X) maxX = p.X;
                if (maxY < p.Y) maxY = p.Y;
            });
            polygon.PointHead = new Point(minX, minY);
            polygon.PointTail = new Point(maxX, maxY);
        }

        // Set PointHead and PointTail for MyPen
        public static void SetPointHeadTail(MyPen pen)
        {
            int minX = int.MaxValue, minY = int.MaxValue;
            int maxX = int.MinValue, maxY = int.MinValue;
            pen.Points.ForEach(p =>
            {
                if (minX > p.X) minX = p.X;
                if (minY > p.Y) minY = p.Y;
                if (maxX < p.X) maxX = p.X;
                if (maxY < p.Y) maxY = p.Y;
            });
            pen.PointHead = new Point(minX, minY);
            pen.PointTail = new Point(maxX, maxY);
        }

        // Get Control Points of the Shape
        public static List<Point> GetControlPoints(Shape shape)
        {
            List<Point> Points = new List<Point>();
            int xCenter = (shape.PointHead.X + shape.PointTail.X) / 2;
            int yCenter = (shape.PointHead.Y + shape.PointTail.Y) / 2;
            Points.Add(new Point(shape.PointHead.X, shape.PointHead.Y));
            Points.Add(new Point(xCenter, shape.PointHead.Y));
            Points.Add(new Point(shape.PointTail.X, shape.PointHead.Y));
            Points.Add(new Point(shape.PointHead.X, yCenter));
            Points.Add(new Point(shape.PointTail.X, yCenter));
            Points.Add(new Point(shape.PointHead.X, shape.PointTail.Y));
            Points.Add(new Point(xCenter, shape.PointTail.Y));
            Points.Add(new Point(shape.PointTail.X, shape.PointTail.Y));
            return Points;
        }
    }
}
