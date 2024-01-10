using Paint.Model;
using Paint.Utils;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Paint.Presenter
{
    class PresenterAlterImp : PresenterAlter
    {
        ViewPaint viewPaint;

        DataManager dataManager;

        public PresenterAlterImp(ViewPaint viewPaint)
        {
            this.viewPaint = viewPaint;
            dataManager = DataManager.getInstance();
        }

        public void onClickDrawGroup()
        {
            // Find selected images, if number of images > 1 => group
            if (dataManager.shapeList.Count(shape => shape.isSelected) > 1)
            {
                GroupShape group = new GroupShape();
                for (int i = 0; i < dataManager.shapeList.Count; i++)
                {
                    if (dataManager.shapeList[i].isSelected)
                    {
                        group.AddShape(dataManager.shapeList[i]);
                        dataManager.shapeList.RemoveAt(i--);
                    }
                }
                FindRegion.SetPointHeadTail(group);
                group.isSelected = true;
                dataManager.shapeList.Add(group);
                viewPaint.RefreshDrawing();
            }

            viewPaint.RefreshDrawing();
        }

        public void onClickDrawUngroup()
        {
            // Find selected GroupShape
            if (dataManager.shapeList.Find(shape => shape.isSelected) is GroupShape)
            {
                GroupShape group = (GroupShape)dataManager.shapeList.Find(shape => shape.isSelected);
                foreach (Shape shape in group)
                {
                    dataManager.shapeList.Add(shape);
                }
                dataManager.shapeList.Remove(group);
            }

            viewPaint.RefreshDrawing();
        }

        public void onClickDeleteShape()
        {
            for (int i = 0; i < dataManager.shapeList.Count; i++)
            {
                if (dataManager.shapeList[i].isSelected)
                {
                    dataManager.shapeList.RemoveAt(i--);
                }
            }
            viewPaint.RefreshDrawing();
        }

        public void onClickCopyShape()
        {
            dataManager.RemoveSavedShapes();
            for (int i = 0; i < dataManager.shapeList.Count; i++)
            {
                if (dataManager.shapeList[i].isSelected)
                {
                    dataManager.AddSavedShapes(dataManager.shapeList[i].Clone() as Shape);
                }
            }
            viewPaint.RefreshDrawing();
        }

        public void onClickCutShape()
        {
            dataManager.RemoveSavedShapes();
            for (int i = 0; i < dataManager.shapeList.Count; i++)
            {
                if (dataManager.shapeList[i].isSelected)
                {
                    dataManager.AddSavedShapes(dataManager.shapeList[i].Clone() as Shape);
                    dataManager.shapeList.RemoveAt(i--);
                }
            }
            viewPaint.RefreshDrawing();
        }

        public void onClickPasteShape()
        {

            for (int i = 0; i < dataManager.savedShapes.Count; i++)
            {
                Shape shape = dataManager.savedShapes[i].Clone() as Shape;
                dataManager.AddEntity(shape);
                dataManager.shapeList[dataManager.shapeList.Count - 1].MoveShape(new Point(20, 20));
            }
            dataManager.offAllShapeSelected();
            viewPaint.RefreshDrawing();
        }

        public void onClickClearAll(PictureBox pictureBox)
        {
            pictureBox.Image = null;
            dataManager.shapeList.Clear();
            dataManager.isNotNone = false;
            viewPaint.RefreshDrawing();
        }

        public void onClickSaveImage(PictureBox pictureBox)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            Rectangle rect = new Rectangle(0, 0, pictureBox.Width, pictureBox.Height);
            pictureBox.DrawToBitmap(bitmap, rect);
            saveFile.Filter = "Image Files(*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png; *.jpg; *.jpeg; *.gif; *.bmp";
            saveFile.CheckPathExists = true;
            saveFile.OverwritePrompt = true;
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                bitmap.Save(saveFile.FileName);
                dataManager.isSave = true;
            }
        }

        public void onClickOpenImage(PictureBox pictureBox)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files(*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png; *.jpg; *.jpeg; *.gif; *.bmp";
            openFile.CheckFileExists = true;
            openFile.CheckPathExists = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = new Bitmap(openFile.FileName);
            }
        }

        public void onClickNewImage(PictureBox pictureBox)
        {
            if (dataManager.isNotNone)
            {
                if (MessageBox.Show("You have not saved this image. Do you want to save it?",
                     "Notification",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    onClickSaveImage(pictureBox);
                }
            }
            onClickClearAll(pictureBox);
        }

        public void onUseKeyStrokes(PictureBox pictureBox, Keys key)
        {
            if (key == Keys.A && Control.ModifierKeys.HasFlag(Keys.Control))
            {
                for (int i = 0; i < dataManager.shapeList.Count; i++)
                    dataManager.shapeList[i].isSelected = true;
                viewPaint.RefreshDrawing();
            }
            if (key == Keys.Delete)
            {
                onClickDeleteShape();
            }
        }
    }
}
