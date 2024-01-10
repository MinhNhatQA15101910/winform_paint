using Paint.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Paint.Model
{
    public abstract class Shape : ICloneable
    {
        public string Name { get; set; }
        public Point PointHead { get; set; }
        public Point PointTail { get; set; }
        public bool IsSelected { get; set; }
        public int ContourWidth { get; set; }
        public bool IsFill { get; set; }
        public Color Color { get; set; }

        public abstract object Clone();

        public abstract void DrawShape(Graphics g);

        public virtual void MoveShape(Point distance)
        {
            PointHead = new Point(PointHead.X + distance.X, PointHead.Y + distance.Y);
            PointTail = new Point(PointTail.X + distance.X, PointTail.Y + distance.Y);
        }

        public abstract bool IsHit(Point p);

        protected abstract GraphicsPath GraphicsPath { get; }

        public virtual bool IsCollideWithRegion(Rectangle rectangle)
        {
            return !(PointTail.X <= rectangle.X ||
                    PointTail.X >= rectangle.X + rectangle.Width ||
                    PointTail.Y <= rectangle.Y ||
                    PointTail.Y >= rectangle.Y + rectangle.Height);
        }

        public Rectangle GetRectangle()
        {
            return new Rectangle(
                PointHead.X,
                PointHead.Y,
                PointTail.X - PointHead.X, 
                PointTail.Y - PointHead.Y
                );
        }
        public virtual int IsHitControlsPoint(Point p)
        {
            List<Point> points = FindRegion.GetControlPoints(this);
            for (int i = 0; i < 8; i++)
            {
                GraphicsPath path = new GraphicsPath();
                path.AddRectangle(new Rectangle(points[i].X - 4, points[i].Y - 4, 8, 8));

                if (path.IsVisible(p)) return i;
            }
            return -1;
        }
        public virtual void ChangePoint(int index)
        {
            if (index == 0 || index == 1 || index == 3)
            {
                (PointTail, PointHead) = (PointHead, PointTail);
            }
            if (index == 2)
            {
                int a = PointTail.X;
                int b = PointHead.Y;
                PointHead = new Point(PointHead.X, PointTail.Y);
                PointTail = new Point(a, b);
            }
            if (index == 5)
            {
                int a = PointHead.X;
                int b = PointTail.Y;
                PointHead = new Point(PointTail.X, PointHead.Y);
                PointTail = new Point(a, b);
            }
        }
        public virtual void MoveControlPoint(Point pointCurrent, Point previous, int index)
        {
            int deltaX = pointCurrent.X - previous.X;
            int deltaY = pointCurrent.Y - previous.Y;
            if (index == 1 || index == 6)
            {
                PointTail = new Point(PointTail.X, PointTail.Y + deltaY);
            }
            else if (index == 3 || index == 4)
            {
                PointTail = new Point(PointTail.X + deltaX, PointTail.Y);
            }
            else
            {
                PointTail = pointCurrent;
            }
        }
    }
}