namespace Paint.Model
{
    public class MyPen:MyCurve
    {
        public bool IsEraser { get; set; }

        public MyPen()
        {
            Name = "Pen";
        }
    }
}
