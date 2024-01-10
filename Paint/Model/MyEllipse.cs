using Paint.Utils;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Paint.Model
{
    public class MyEllipse : MyRectangle
    {
        public MyEllipse()
        {
            Name = "Ellipse";
        }

        public override object Clone()
        {
            return new MyEllipse
            {
                PointHead = PointHead,
                PointTail = PointTail,
                ContourWidth = ContourWidth,
                IsSelected = IsSelected,
                Color = Color,
                Name = Name
            };
        }

        protected override GraphicsPath GraphicsPath
        {
            get
            {
                GraphicsPath path = new GraphicsPath();

                if (PointTail.X < PointHead.X && PointTail.Y < PointHead.Y)
                {
                    path.AddEllipse(
                        new Rectangle(
                            PointTail.X,
                            PointTail.Y,
                            PointHead.X - PointTail.X,
                            PointHead.Y - PointTail.Y
                            )
                        );
                }
                else if (PointHead.X > PointTail.X && PointHead.Y < PointTail.Y)
                {
                    path.AddEllipse(HelpFunction.GetRectangle(PointHead, PointTail));
                }
                else if (PointHead.X < PointTail.X && PointHead.Y > PointTail.Y)
                {
                    path.AddEllipse(HelpFunction.GetRectangle(PointHead, PointTail));
                }
                else
                {
                    path.AddEllipse(
                        new Rectangle(
                            PointHead.X, 
                            PointHead.Y, 
                            PointTail.X - PointHead.X, 
                            PointTail.Y - PointHead.Y
                            )
                        );
                }
                return path;
            }
        }
    }
}
