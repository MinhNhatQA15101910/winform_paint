namespace Paint
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlAllTool = new System.Windows.Forms.Panel();
            this.lblSize = new System.Windows.Forms.Label();
            this.trbLineSize = new System.Windows.Forms.TrackBar();
            this.pnlFileTool = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.pnlEditTool = new System.Windows.Forms.Panel();
            this.btnCut = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUngroup = new System.Windows.Forms.Button();
            this.btnGroup = new System.Windows.Forms.Button();
            this.pnlShapeTool = new System.Windows.Forms.Panel();
            this.btnCurve = new System.Windows.Forms.Button();
            this.btnPolygon = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnRect = new System.Windows.Forms.Button();
            this.lblColor = new System.Windows.Forms.Label();
            this.pnlDrawTool = new System.Windows.Forms.Panel();
            this.btnFill = new System.Windows.Forms.Button();
            this.btnPen = new System.Windows.Forms.Button();
            this.btnEraser = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.colorPicker = new System.Windows.Forms.PictureBox();
            this.btnColorDisplay = new System.Windows.Forms.Button();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.picUpdate = new System.Windows.Forms.PictureBox();
            this.picLocation = new System.Windows.Forms.PictureBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pic = new System.Windows.Forms.PictureBox();
            this.pnlAllTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbLineSize)).BeginInit();
            this.pnlFileTool.SuspendLayout();
            this.pnlEditTool.SuspendLayout();
            this.pnlShapeTool.SuspendLayout();
            this.pnlDrawTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorPicker)).BeginInit();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAllTool
            // 
            this.pnlAllTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlAllTool.Controls.Add(this.lblSize);
            this.pnlAllTool.Controls.Add(this.trbLineSize);
            this.pnlAllTool.Controls.Add(this.pnlFileTool);
            this.pnlAllTool.Controls.Add(this.pnlEditTool);
            this.pnlAllTool.Controls.Add(this.pnlShapeTool);
            this.pnlAllTool.Controls.Add(this.lblColor);
            this.pnlAllTool.Controls.Add(this.pnlDrawTool);
            this.pnlAllTool.Controls.Add(this.btnColor);
            this.pnlAllTool.Controls.Add(this.colorPicker);
            this.pnlAllTool.Controls.Add(this.btnColorDisplay);
            this.pnlAllTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAllTool.Location = new System.Drawing.Point(0, 0);
            this.pnlAllTool.Name = "pnlAllTool";
            this.pnlAllTool.Size = new System.Drawing.Size(1034, 146);
            this.pnlAllTool.TabIndex = 0;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSize.ForeColor = System.Drawing.Color.White;
            this.lblSize.Location = new System.Drawing.Point(573, 80);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(40, 20);
            this.lblSize.TabIndex = 13;
            this.lblSize.Text = "Size";
            // 
            // trbLineSize
            // 
            this.trbLineSize.Location = new System.Drawing.Point(542, 25);
            this.trbLineSize.Name = "trbLineSize";
            this.trbLineSize.Size = new System.Drawing.Size(100, 45);
            this.trbLineSize.TabIndex = 12;
            this.trbLineSize.Scroll += new System.EventHandler(this.OnTrbLineSizeScrolled);
            // 
            // pnlFileTool
            // 
            this.pnlFileTool.BackColor = System.Drawing.Color.Yellow;
            this.pnlFileTool.Controls.Add(this.btnClear);
            this.pnlFileTool.Controls.Add(this.btnSave);
            this.pnlFileTool.Controls.Add(this.btnNew);
            this.pnlFileTool.Controls.Add(this.btnOpen);
            this.pnlFileTool.Location = new System.Drawing.Point(12, 14);
            this.pnlFileTool.Name = "pnlFileTool";
            this.pnlFileTool.Size = new System.Drawing.Size(92, 98);
            this.pnlFileTool.TabIndex = 9;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Black;
            this.btnClear.BackgroundImage = global::Paint.Properties.Resources.clear;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClear.Location = new System.Drawing.Point(49, 49);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(40, 40);
            this.btnClear.TabIndex = 8;
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnClear, "Clear All");
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.OnBtnClearClicked);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.BackgroundImage = global::Paint.Properties.Resources.ic_save;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(49, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(40, 40);
            this.btnSave.TabIndex = 11;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnSave, "Save");
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.OnBtnSaveClicked);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Black;
            this.btnNew.BackgroundImage = global::Paint.Properties.Resources.ic_new;
            this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNew.Location = new System.Drawing.Point(3, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(40, 40);
            this.btnNew.TabIndex = 10;
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnNew, "New");
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.OnBtnNewClicked);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.Black;
            this.btnOpen.BackgroundImage = global::Paint.Properties.Resources.ic_open;
            this.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.ForeColor = System.Drawing.Color.White;
            this.btnOpen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOpen.Location = new System.Drawing.Point(3, 46);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(40, 40);
            this.btnOpen.TabIndex = 9;
            this.btnOpen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnOpen, "Open");
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.OnBtnOpenClicked);
            // 
            // pnlEditTool
            // 
            this.pnlEditTool.BackColor = System.Drawing.Color.Black;
            this.pnlEditTool.Controls.Add(this.btnCut);
            this.pnlEditTool.Controls.Add(this.btnPaste);
            this.pnlEditTool.Controls.Add(this.btnCopy);
            this.pnlEditTool.Controls.Add(this.btnSelect);
            this.pnlEditTool.Controls.Add(this.btnDelete);
            this.pnlEditTool.Controls.Add(this.btnUngroup);
            this.pnlEditTool.Controls.Add(this.btnGroup);
            this.pnlEditTool.Location = new System.Drawing.Point(110, 14);
            this.pnlEditTool.Name = "pnlEditTool";
            this.pnlEditTool.Size = new System.Drawing.Size(181, 98);
            this.pnlEditTool.TabIndex = 8;
            // 
            // btnCut
            // 
            this.btnCut.BackColor = System.Drawing.Color.Black;
            this.btnCut.BackgroundImage = global::Paint.Properties.Resources.ic_cut;
            this.btnCut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnCut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCut.ForeColor = System.Drawing.Color.White;
            this.btnCut.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCut.Location = new System.Drawing.Point(138, 3);
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(40, 40);
            this.btnCut.TabIndex = 18;
            this.btnCut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnCut, "Cut");
            this.btnCut.UseVisualStyleBackColor = false;
            this.btnCut.Click += new System.EventHandler(this.OnBtnCutClicked);
            // 
            // btnPaste
            // 
            this.btnPaste.BackColor = System.Drawing.Color.Black;
            this.btnPaste.BackgroundImage = global::Paint.Properties.Resources.ic_paste;
            this.btnPaste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPaste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaste.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnPaste.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaste.ForeColor = System.Drawing.Color.White;
            this.btnPaste.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPaste.Location = new System.Drawing.Point(95, 49);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(40, 40);
            this.btnPaste.TabIndex = 17;
            this.btnPaste.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnPaste, "Paste");
            this.btnPaste.UseVisualStyleBackColor = false;
            this.btnPaste.Click += new System.EventHandler(this.OnBtnPasteClicked);
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.Black;
            this.btnCopy.BackgroundImage = global::Paint.Properties.Resources.ic_copy;
            this.btnCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.ForeColor = System.Drawing.Color.White;
            this.btnCopy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCopy.Location = new System.Drawing.Point(95, 3);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(40, 40);
            this.btnCopy.TabIndex = 16;
            this.btnCopy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnCopy, "Copy");
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.OnBtnCopyClicked);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Black;
            this.btnSelect.BackgroundImage = global::Paint.Properties.Resources.ic_select;
            this.btnSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSelect.Location = new System.Drawing.Point(49, 49);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(40, 40);
            this.btnSelect.TabIndex = 15;
            this.btnSelect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnSelect, "Select");
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.OnBtnSelectClicked);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Black;
            this.btnDelete.BackgroundImage = global::Paint.Properties.Resources.ic_delete;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(3, 49);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnDelete, "Delete");
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.OnBtnDeleteClicked);
            // 
            // btnUngroup
            // 
            this.btnUngroup.BackColor = System.Drawing.Color.Black;
            this.btnUngroup.BackgroundImage = global::Paint.Properties.Resources.ic_ungroup;
            this.btnUngroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUngroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUngroup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnUngroup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUngroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUngroup.ForeColor = System.Drawing.Color.White;
            this.btnUngroup.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUngroup.Location = new System.Drawing.Point(49, 3);
            this.btnUngroup.Name = "btnUngroup";
            this.btnUngroup.Size = new System.Drawing.Size(40, 40);
            this.btnUngroup.TabIndex = 13;
            this.btnUngroup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnUngroup, "Ungroup Shape");
            this.btnUngroup.UseVisualStyleBackColor = false;
            this.btnUngroup.Click += new System.EventHandler(this.OnBtnUngroupClicked);
            // 
            // btnGroup
            // 
            this.btnGroup.BackColor = System.Drawing.Color.Black;
            this.btnGroup.BackgroundImage = global::Paint.Properties.Resources.ic_group;
            this.btnGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGroup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnGroup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroup.ForeColor = System.Drawing.Color.White;
            this.btnGroup.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGroup.Location = new System.Drawing.Point(3, 3);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(40, 40);
            this.btnGroup.TabIndex = 12;
            this.btnGroup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnGroup, "Group Shape");
            this.btnGroup.UseVisualStyleBackColor = false;
            this.btnGroup.Click += new System.EventHandler(this.OnBtnGroupClicked);
            // 
            // pnlShapeTool
            // 
            this.pnlShapeTool.BackColor = System.Drawing.Color.Black;
            this.pnlShapeTool.Controls.Add(this.btnCurve);
            this.pnlShapeTool.Controls.Add(this.btnPolygon);
            this.pnlShapeTool.Controls.Add(this.btnEllipse);
            this.pnlShapeTool.Controls.Add(this.btnLine);
            this.pnlShapeTool.Controls.Add(this.btnRect);
            this.pnlShapeTool.Location = new System.Drawing.Point(395, 14);
            this.pnlShapeTool.Name = "pnlShapeTool";
            this.pnlShapeTool.Size = new System.Drawing.Size(141, 98);
            this.pnlShapeTool.TabIndex = 5;
            // 
            // btnCurve
            // 
            this.btnCurve.BackgroundImage = global::Paint.Properties.Resources.ic_curve;
            this.btnCurve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCurve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCurve.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnCurve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCurve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurve.ForeColor = System.Drawing.Color.White;
            this.btnCurve.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCurve.Location = new System.Drawing.Point(49, 49);
            this.btnCurve.Name = "btnCurve";
            this.btnCurve.Size = new System.Drawing.Size(40, 40);
            this.btnCurve.TabIndex = 9;
            this.btnCurve.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnCurve, "Draw Curve");
            this.btnCurve.UseVisualStyleBackColor = true;
            this.btnCurve.Click += new System.EventHandler(this.OnBtnCurveClicked);
            // 
            // btnPolygon
            // 
            this.btnPolygon.BackgroundImage = global::Paint.Properties.Resources.ic_polygon;
            this.btnPolygon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPolygon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPolygon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnPolygon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPolygon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPolygon.ForeColor = System.Drawing.Color.White;
            this.btnPolygon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPolygon.Location = new System.Drawing.Point(3, 49);
            this.btnPolygon.Name = "btnPolygon";
            this.btnPolygon.Size = new System.Drawing.Size(40, 40);
            this.btnPolygon.TabIndex = 8;
            this.btnPolygon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnPolygon, "Draw Polygon");
            this.btnPolygon.UseVisualStyleBackColor = true;
            this.btnPolygon.Click += new System.EventHandler(this.OnBtnPolygonClicked);
            // 
            // btnEllipse
            // 
            this.btnEllipse.BackgroundImage = global::Paint.Properties.Resources.circle;
            this.btnEllipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEllipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEllipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnEllipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEllipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEllipse.ForeColor = System.Drawing.Color.White;
            this.btnEllipse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEllipse.Location = new System.Drawing.Point(95, 3);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(40, 40);
            this.btnEllipse.TabIndex = 5;
            this.btnEllipse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnEllipse, "Draw Ellipse");
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.OnBtnEllipseClicked);
            // 
            // btnLine
            // 
            this.btnLine.BackgroundImage = global::Paint.Properties.Resources.line;
            this.btnLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnLine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLine.ForeColor = System.Drawing.Color.White;
            this.btnLine.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLine.Location = new System.Drawing.Point(3, 3);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(40, 40);
            this.btnLine.TabIndex = 7;
            this.btnLine.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnLine, "Draw Line");
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.OnBtnLineClicked);
            // 
            // btnRect
            // 
            this.btnRect.BackgroundImage = global::Paint.Properties.Resources.rectangle;
            this.btnRect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnRect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRect.ForeColor = System.Drawing.Color.White;
            this.btnRect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRect.Location = new System.Drawing.Point(49, 3);
            this.btnRect.Name = "btnRect";
            this.btnRect.Size = new System.Drawing.Size(40, 40);
            this.btnRect.TabIndex = 6;
            this.btnRect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnRect, "Draw Rectangle");
            this.btnRect.UseVisualStyleBackColor = true;
            this.btnRect.Click += new System.EventHandler(this.OnBtnRectClicked);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblColor.ForeColor = System.Drawing.Color.White;
            this.lblColor.Location = new System.Drawing.Point(644, 80);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(46, 20);
            this.lblColor.TabIndex = 11;
            this.lblColor.Text = "Color";
            // 
            // pnlDrawTool
            // 
            this.pnlDrawTool.BackColor = System.Drawing.Color.Black;
            this.pnlDrawTool.Controls.Add(this.btnFill);
            this.pnlDrawTool.Controls.Add(this.btnPen);
            this.pnlDrawTool.Controls.Add(this.btnEraser);
            this.pnlDrawTool.Location = new System.Drawing.Point(297, 14);
            this.pnlDrawTool.Name = "pnlDrawTool";
            this.pnlDrawTool.Size = new System.Drawing.Size(92, 98);
            this.pnlDrawTool.TabIndex = 3;
            // 
            // btnFill
            // 
            this.btnFill.BackgroundImage = global::Paint.Properties.Resources.bucket;
            this.btnFill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnFill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFill.ForeColor = System.Drawing.Color.White;
            this.btnFill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFill.Location = new System.Drawing.Point(3, 3);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(40, 40);
            this.btnFill.TabIndex = 2;
            this.btnFill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnFill, "Fill");
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.OnBtnFillClicked);
            // 
            // btnPen
            // 
            this.btnPen.BackgroundImage = global::Paint.Properties.Resources.pencil;
            this.btnPen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnPen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPen.ForeColor = System.Drawing.Color.White;
            this.btnPen.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPen.Location = new System.Drawing.Point(49, 3);
            this.btnPen.Name = "btnPen";
            this.btnPen.Size = new System.Drawing.Size(40, 40);
            this.btnPen.TabIndex = 3;
            this.btnPen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnPen, "Pencil");
            this.btnPen.UseVisualStyleBackColor = true;
            this.btnPen.Click += new System.EventHandler(this.OnBtnPenClicked);
            // 
            // btnEraser
            // 
            this.btnEraser.BackgroundImage = global::Paint.Properties.Resources.eraser;
            this.btnEraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnEraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEraser.ForeColor = System.Drawing.Color.White;
            this.btnEraser.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnEraser.Location = new System.Drawing.Point(3, 49);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(40, 40);
            this.btnEraser.TabIndex = 4;
            this.btnEraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnEraser, "Eraser");
            this.btnEraser.UseVisualStyleBackColor = true;
            this.btnEraser.Click += new System.EventHandler(this.OnBtnEraserClicked);
            // 
            // btnColor
            // 
            this.btnColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.ForeColor = System.Drawing.Color.White;
            this.btnColor.Image = global::Paint.Properties.Resources.color;
            this.btnColor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnColor.Location = new System.Drawing.Point(912, 37);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(67, 63);
            this.btnColor.TabIndex = 1;
            this.btnColor.Text = "Edit color";
            this.btnColor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.OnBtnColorClicked);
            // 
            // colorPicker
            // 
            this.colorPicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPicker.Image = global::Paint.Properties.Resources.color_palette;
            this.colorPicker.Location = new System.Drawing.Point(696, 25);
            this.colorPicker.Name = "colorPicker";
            this.colorPicker.Size = new System.Drawing.Size(210, 87);
            this.colorPicker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.colorPicker.TabIndex = 8;
            this.colorPicker.TabStop = false;
            this.colorPicker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnColorPickerMouseClicked);
            // 
            // btnColorDisplay
            // 
            this.btnColorDisplay.BackColor = System.Drawing.Color.Black;
            this.btnColorDisplay.Location = new System.Drawing.Point(648, 37);
            this.btnColorDisplay.Name = "btnColorDisplay";
            this.btnColorDisplay.Size = new System.Drawing.Size(42, 36);
            this.btnColorDisplay.TabIndex = 0;
            this.btnColorDisplay.UseVisualStyleBackColor = false;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlFooter.Controls.Add(this.picUpdate);
            this.pnlFooter.Controls.Add(this.picLocation);
            this.pnlFooter.Controls.Add(this.lblLocation);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 820);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1034, 41);
            this.pnlFooter.TabIndex = 1;
            // 
            // picUpdate
            // 
            this.picUpdate.BackgroundImage = global::Paint.Properties.Resources.ic_update;
            this.picUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picUpdate.Location = new System.Drawing.Point(1002, 9);
            this.picUpdate.Name = "picUpdate";
            this.picUpdate.Size = new System.Drawing.Size(20, 20);
            this.picUpdate.TabIndex = 2;
            this.picUpdate.TabStop = false;
            this.toolTip.SetToolTip(this.picUpdate, "Update");
            this.picUpdate.Click += new System.EventHandler(this.OnUpdateClicked);
            // 
            // picLocation
            // 
            this.picLocation.BackgroundImage = global::Paint.Properties.Resources.ic_location;
            this.picLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLocation.Location = new System.Drawing.Point(12, 9);
            this.picLocation.Name = "picLocation";
            this.picLocation.Size = new System.Drawing.Size(20, 20);
            this.picLocation.TabIndex = 1;
            this.picLocation.TabStop = false;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.ForeColor = System.Drawing.Color.White;
            this.lblLocation.Location = new System.Drawing.Point(38, 9);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(22, 13);
            this.lblLocation.TabIndex = 0;
            this.lblLocation.Text = "0:0";
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 6000;
            this.toolTip.InitialDelay = 50;
            this.toolTip.ReshowDelay = 100;
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(1034, 861);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPicPainted);
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnPicMouseClicked);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnPicMouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnPicMouseMoved);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnPicMouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 861);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlAllTool);
            this.Controls.Add(this.pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnForm1KeyDown);
            this.pnlAllTool.ResumeLayout(false);
            this.pnlAllTool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbLineSize)).EndInit();
            this.pnlFileTool.ResumeLayout(false);
            this.pnlEditTool.ResumeLayout(false);
            this.pnlShapeTool.ResumeLayout(false);
            this.pnlDrawTool.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.colorPicker)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAllTool;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnColorDisplay;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnRect;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnEraser;
        private System.Windows.Forms.Button btnPen;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Panel pnlDrawTool;
        private System.Windows.Forms.PictureBox colorPicker;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Panel pnlShapeTool;
        private System.Windows.Forms.Panel pnlEditTool;
        private System.Windows.Forms.Panel pnlFileTool;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnUngroup;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnPolygon;
        private System.Windows.Forms.Button btnCurve;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TrackBar trbLineSize;
        private System.Windows.Forms.PictureBox picLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnCut;
        private System.Windows.Forms.PictureBox picUpdate;
    }
}

