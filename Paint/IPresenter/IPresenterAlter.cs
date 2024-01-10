using System.Windows.Forms;

namespace Paint.IPresenter
{
    public interface IPresenterAlter
    {
        // Draw Group
        void onClickDrawGroup();
        // Draw Ungroup
        void onClickDrawUngroup();
        // Delete shape
        void onClickDeleteShape();
        // Copy shape
        void onClickCopyShape();
        // Cut shape
        void onClickCutShape();
        // Paste shape
        void onClickPasteShape();
        // Clear
        void onClickClearAll(PictureBox pictureBox);
        // Save Image
        void onClickSaveImage(PictureBox pictureBox);
        // Open Image
        void onClickOpenImage(PictureBox pictureBox);
        // Create new Image
        void onClickNewImage(PictureBox pictureBox);
        // Keyboard shortcut
        void onUseKeyStrokes(PictureBox pictureBox, Keys key);
    }
}
