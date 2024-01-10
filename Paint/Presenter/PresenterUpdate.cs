using System.Drawing;
using System.Windows.Forms;

namespace Paint.Presenter
{
    interface PresenterUpdate
    {
        void onClickSelectMode();
        void onClickSelectColor(Color color, Graphics g);
        void onClickSelectSize(int size);
        void onClickSelectFill(Button btn, Graphics g);
    }
}
