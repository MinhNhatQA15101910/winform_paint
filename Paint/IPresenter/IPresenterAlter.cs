using System.Windows.Forms;

namespace Paint.IPresenter
{
    public interface IPresenterAlter
    {
        // Draw Group
        void OnClickDrawGroup();
        // Draw Ungroup
        void OnClickDrawUngroup();
        // Delete shape
        void OnClickDeleteShape();
        // Copy shape
        void OnClickCopyShape();
        // Cut shape
        void OnClickCutShape();
        // Paste shape
        void OnClickPasteShape();
        // Clear
        void OnClickClearAll(PictureBox pictureBox);
        // Save Image
        void OnClickSaveImage(PictureBox pictureBox);
        // Open Image
        void OnClickOpenImage(PictureBox pictureBox);
        // Create new Image
        void OnClickNewImage(PictureBox pictureBox);
        // Keyboard shortcut
        void OnUseKeyStrokes(Keys key);
    }
}
