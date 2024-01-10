using Paint.Utils;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Paint.Model
{
    public class MyEllipse : MyRectangle
    {
        public MyEllipse()
        {
            name = "Ellipse";
        }

        public override object Clone()
        {
            return new MyEllipse
            {
                pointHead = pointHead,
                pointTail = pointTail,
                contourWidth = contourWidth,
                isSelected = isSelected,
                color = color,
                name = name
            };
        }

        protected override GraphicsPath graphicsPath
        {
            get
            {
                GraphicsPath path = new GraphicsPath();

                if (pointTail.X < pointHead.X && pointTail.Y < pointHead.Y)
                {
                    path.AddEllipse(
                        new Rectangle(
                            pointTail.X,
                            pointTail.Y,
                            pointHead.X - pointTail.X,
                            pointHead.Y - pointTail.Y
                            )
                        );
                }
                else if (pointHead.X > pointTail.X && pointHead.Y < pointTail.Y)
                {
                    path.AddEllipse(HelpFunction.GetRectangle(pointHead, pointTail));
                }
                else if (pointHead.X < pointTail.X && pointHead.Y > pointTail.Y)
                {
                    path.AddEllipse(HelpFunction.GetRectangle(pointHead, pointTail));
                }
                else
                {
                    path.AddEllipse(
                        new Rectangle(
                            pointHead.X, 
                            pointHead.Y, 
                            pointTail.X - pointHead.X, 
                            pointTail.Y - pointHead.Y
                            )
                        );
                }
                return path;
            }
        }
    }
}
