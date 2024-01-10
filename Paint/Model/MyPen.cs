namespace Paint.Model
{
    public class MyPen:MyCurve
    {
        public bool isEraser { get; set; }

        public MyPen()
        {
            name = "Pen";
        }
    }
}
