using Paint.IPresenter;
using Paint.Model;
using Paint.Utils;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Paint.Presenter
{
    class PresenterAlter : IPresenterAlter
    {
        private readonly IViewPaint viewPaint;

        private readonly DataManager dataManager;

        public PresenterAlter(IViewPaint viewPaint)
        {
            this.viewPaint = viewPaint;
            dataManager = DataManager.GetInstance();
        }

        public void OnClickDrawGroup()
        {
            // Find selected images, if number of images > 1 => group
            if (dataManager.ShapeList.Count(shape => shape.IsSelected) > 1)
            {
                GroupShape group = new GroupShape();
                for (int i = 0; i < dataManager.ShapeList.Count; i++)
                {
                    if (dataManager.ShapeList[i].IsSelected)
                    {
                        group.AddShape(dataManager.ShapeList[i]);
                        dataManager.ShapeList.RemoveAt(i--);
                    }
                }
                FindRegion.SetPointHeadTail(group);
                group.IsSelected = true;
                dataManager.ShapeList.Add(group);
                viewPaint.RefreshDrawing();
            }

            viewPaint.RefreshDrawing();
        }

        public void OnClickDrawUngroup()
        {
            // Find selected GroupShape
            if (dataManager.ShapeList.Find(shape => shape.IsSelected) is GroupShape)
            {
                GroupShape group = dataManager.ShapeList.Find(shape => shape.IsSelected) as GroupShape;
                foreach (Shape shape in group)
                {
                    dataManager.ShapeList.Add(shape);
                }
                dataManager.ShapeList.Remove(group);
            }

            viewPaint.RefreshDrawing();
        }

        public void OnClickDeleteShape()
        {
            for (int i = 0; i < dataManager.ShapeList.Count; i++)
            {
                if (dataManager.ShapeList[i].IsSelected)
                {
                    dataManager.ShapeList.RemoveAt(i--);
                }
            }
            viewPaint.RefreshDrawing();
        }

        public void OnClickCopyShape()
        {
            dataManager.RemoveSavedShapes();
            for (int i = 0; i < dataManager.ShapeList.Count; i++)
            {
                if (dataManager.ShapeList[i].IsSelected)
                {
                    dataManager.AddSavedShapes(dataManager.ShapeList[i].Clone() as Shape);
                }
            }
            viewPaint.RefreshDrawing();
        }

        public void OnClickCutShape()
        {
            dataManager.RemoveSavedShapes();
            for (int i = 0; i < dataManager.ShapeList.Count; i++)
            {
                if (dataManager.ShapeList[i].IsSelected)
                {
                    dataManager.AddSavedShapes(dataManager.ShapeList[i].Clone() as Shape);
                    dataManager.ShapeList.RemoveAt(i--);
                }
            }
            viewPaint.RefreshDrawing();
        }

        public void OnClickPasteShape()
        {

            for (int i = 0; i < dataManager.SavedShapes.Count; i++)
            {
                Shape shape = dataManager.SavedShapes[i].Clone() as Shape;
                dataManager.AddEntity(shape);
                dataManager.ShapeList[dataManager.ShapeList.Count - 1].MoveShape(new Point(20, 20));
            }
            dataManager.OffAllShapeSelected();
            viewPaint.RefreshDrawing();
        }

        public void OnClickClearAll(PictureBox pictureBox)
        {
            pictureBox.Image = null;
            dataManager.ShapeList.Clear();
            dataManager.IsNotNone = false;
            viewPaint.RefreshDrawing();
        }

        public void OnClickSaveImage(PictureBox pictureBox)
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
                dataManager.IsSave = true;
            }
        }

        public void OnClickOpenImage(PictureBox pictureBox)
        {
            OpenFileDialog openFile = new OpenFileDialog
            {
                Filter = "Image Files(*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png; *.jpg; *.jpeg; *.gif; *.bmp",
                CheckFileExists = true,
                CheckPathExists = true
            };
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = new Bitmap(openFile.FileName);
            }
        }

        public void OnClickNewImage(PictureBox pictureBox)
        {
            if (dataManager.IsNotNone && MessageBox.Show("You have not saved this image. Do you want to save it?",
                     "Notification",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question) == DialogResult.Yes)
            {
                OnClickSaveImage(pictureBox);
            }
            OnClickClearAll(pictureBox);
        }

        public void OnUseKeyStrokes(Keys key)
        {
            if (key == Keys.A && Control.ModifierKeys.HasFlag(Keys.Control))
            {
                for (int i = 0; i < dataManager.ShapeList.Count; i++)
                    dataManager.ShapeList[i].IsSelected = true;
                viewPaint.RefreshDrawing();
            }
            if (key == Keys.Delete)
            {
                OnClickDeleteShape();
            }
        }
    }
}
