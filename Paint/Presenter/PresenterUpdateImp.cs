using Paint.Model;
using Paint.Utils;
using System.Drawing;
using System.Windows.Forms;

namespace Paint.Presenter
{
    class PresenterUpdateImp : PresenterUpdate
    {
        ViewPaint viewPaint;

        DataManager dataManager;

        public PresenterUpdateImp(ViewPaint viewPaint)
        {
            this.viewPaint = viewPaint;
            dataManager = DataManager.getInstance();
        }

        public void onClickSelectMode()
        {
            dataManager.offAllShapeSelected();
            viewPaint.RefreshDrawing();
            dataManager.currentShape = CurrentShapeStatus.Void;
            viewPaint.SetCursor(Cursors.Default);
        }

        public void onClickSelectColor(Color color, Graphics g)
        {
            dataManager.colorCurrent = color;
            viewPaint.SetColor(color);
            foreach (Shape item in dataManager.shapeList)
            {
                if (item.isSelected)
                {
                    item.color = color;
                    viewPaint.SetDrawing(item, g);
                }
            }
        }

        public void onClickSelectSize(int size)
        {
            dataManager.lineSize = size;
        }

        public void onClickSelectFill(Button btn, Graphics g)
        {
            dataManager.isFill = !dataManager.isFill;
            if (btn.BackColor.Equals(Color.Yellow))
                viewPaint.SetColor(btn, Color.Black);
            else
                viewPaint.SetColor(btn, Color.Yellow);
        }
    }
}
