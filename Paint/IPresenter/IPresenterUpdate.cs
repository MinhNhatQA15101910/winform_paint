using System.Drawing;
using System.Windows.Forms;

namespace Paint.IPresenter
{
    public interface IPresenterUpdate
    {
        void OnClickSelectMode();
        void OnClickSelectColor(Color color, Graphics g);
        void OnClickSelectSize(int size);
        void OnClickSelectFill(Button btn, Graphics g);
    }
}
