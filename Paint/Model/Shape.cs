using Paint.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Paint.Model
{
    public abstract class Shape : ICloneable
    {
        public string name { get; set; }
        public Point pointHead { get; set; }
        public Point pointTail { get; set; }
        public bool isSelected { get; set; }
        public int contourWidth { get; set; }
        public bool isFill { get; set; }
        public Color color { get; set; }

        public abstract object Clone();

        public abstract void DrawShape(Graphics g);

        public virtual void MoveShape(Point distance)
        {
            pointHead = new Point(pointHead.X + distance.X, pointHead.Y + distance.Y);
            pointTail = new Point(pointTail.X + distance.X, pointTail.Y + distance.Y);
        }

        public abstract bool isHit(Point p);

        protected abstract GraphicsPath graphicsPath { get; }

        public virtual bool isCollideWithRegion(Rectangle rectangle)
        {
            return !(pointTail.X <= rectangle.X || 
                    pointHead.X >= rectangle.X + rectangle.Width || 
                    pointTail.Y <= rectangle.Y || 
                    pointHead.Y >= rectangle.Y + rectangle.Height);
        }

        public Rectangle GetRectangle()
        {
            return new Rectangle(
                pointHead.X, 
                pointHead.Y, 
                pointTail.X - pointHead.X, 
                pointTail.Y - pointHead.Y
                );
        }
        public virtual int isHitControlsPoint(Point p)
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
                Point point = pointHead;
                pointHead = pointTail;
                pointTail = point;
            }
            if (index == 2)
            {
                int a = pointTail.X;
                int b = pointHead.Y;
                pointHead = new Point(pointHead.X, pointTail.Y);
                pointTail = new Point(a, b);
            }
            if (index == 5)
            {
                int a = pointHead.X;
                int b = pointTail.Y;
                pointHead = new Point(pointTail.X, pointHead.Y);
                pointTail = new Point(a, b);
            }
        }
        public virtual void MoveControlPoint(Point pointCurrent, Point previous, int index)
        {
            int deltaX = pointCurrent.X - previous.X;
            int deltaY = pointCurrent.Y - previous.Y;
            if (index == 1 || index == 6)
            {
                pointTail = new Point(pointTail.X, pointTail.Y + deltaY);
            }
            else if (index == 3 || index == 4)
            {
                pointTail = new Point(pointTail.X + deltaX, pointTail.Y);
            }
            else
            {
                pointTail = pointCurrent;
            }
        }
    }
}