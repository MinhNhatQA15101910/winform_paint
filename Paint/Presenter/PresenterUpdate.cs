using Paint.IPresenter;
using Paint.Model;
using Paint.Utils;
using System.Drawing;
using System.Windows.Forms;

namespace Paint.Presenter
{
    class PresenterUpdate : IPresenterUpdate
    {
        private readonly IViewPaint viewPaint;

        private readonly DataManager dataManager;

        public PresenterUpdate(IViewPaint viewPaint)
        {
            this.viewPaint = viewPaint;
            dataManager = DataManager.GetInstance();
        }

        public void OnClickSelectMode()
        {
            dataManager.OffAllShapeSelected();
            viewPaint.RefreshDrawing();
            dataManager.CurrentShape = CurrentShapeStatus.Void;
            viewPaint.SetCursor(Cursors.Default);
        }

        public void OnClickSelectColor(Color color, Graphics g)
        {
            dataManager.ColorCurrent = color;
            viewPaint.SetColor(color);
            foreach (Shape item in dataManager.ShapeList)
            {
                if (item.IsSelected)
                {
                    item.Color = color;
                    viewPaint.SetDrawing(item, g);
                }
            }
        }

        public void OnClickSelectSize(int size)
        {
            dataManager.LineSize = size;
        }

        public void OnClickSelectFill(Button btn, Graphics g)
        {
            dataManager.IsFill = !dataManager.IsFill;
            if (btn.BackColor.Equals(Color.Yellow))
                viewPaint.SetColor(btn, Color.Black);
            else
                viewPaint.SetColor(btn, Color.Yellow);
        }
    }
}
