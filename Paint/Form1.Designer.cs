namespace Paint
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_lineSize = new System.Windows.Forms.TrackBar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_color = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_location = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_cut = new System.Windows.Forms.Button();
            this.btn_paste = new System.Windows.Forms.Button();
            this.btn_copy = new System.Windows.Forms.Button();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_ungroup = new System.Windows.Forms.Button();
            this.btn_group = new System.Windows.Forms.Button();
            this.btn_curve = new System.Windows.Forms.Button();
            this.btn_polygon = new System.Windows.Forms.Button();
            this.btn_ellipse = new System.Windows.Forms.Button();
            this.btn_line = new System.Windows.Forms.Button();
            this.btn_rect = new System.Windows.Forms.Button();
            this.btn_fill = new System.Windows.Forms.Button();
            this.btn_pencil = new System.Windows.Forms.Button();
            this.btn_eraser = new System.Windows.Forms.Button();
            this.btn_color = new System.Windows.Forms.Button();
            this.color_picker = new System.Windows.Forms.PictureBox();
            this.pic = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_lineSize)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.tb_lineSize);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.btn_color);
            this.panel3.Controls.Add(this.color_picker);
            this.panel3.Controls.Add(this.pic_color);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1034, 146);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(573, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Size";
            // 
            // tb_lineSize
            // 
            this.tb_lineSize.Location = new System.Drawing.Point(542, 25);
            this.tb_lineSize.Name = "tb_lineSize";
            this.tb_lineSize.Size = new System.Drawing.Size(100, 45);
            this.tb_lineSize.TabIndex = 12;
            this.tb_lineSize.Scroll += new System.EventHandler(this.tb_lineSize_Scroll);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Yellow;
            this.panel4.Controls.Add(this.btn_clear);
            this.panel4.Controls.Add(this.btn_save);
            this.panel4.Controls.Add(this.btn_new);
            this.panel4.Controls.Add(this.btn_open);
            this.panel4.Location = new System.Drawing.Point(12, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(92, 98);
            this.panel4.TabIndex = 9;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Controls.Add(this.btn_cut);
            this.panel6.Controls.Add(this.btn_paste);
            this.panel6.Controls.Add(this.btn_copy);
            this.panel6.Controls.Add(this.btn_select);
            this.panel6.Controls.Add(this.btn_delete);
            this.panel6.Controls.Add(this.btn_ungroup);
            this.panel6.Controls.Add(this.btn_group);
            this.panel6.Location = new System.Drawing.Point(110, 14);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(181, 98);
            this.panel6.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Controls.Add(this.btn_curve);
            this.panel5.Controls.Add(this.btn_polygon);
            this.panel5.Controls.Add(this.btn_ellipse);
            this.panel5.Controls.Add(this.btn_line);
            this.panel5.Controls.Add(this.btn_rect);
            this.panel5.Location = new System.Drawing.Point(395, 14);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(141, 98);
            this.panel5.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(644, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Color";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btn_fill);
            this.panel1.Controls.Add(this.btn_pencil);
            this.panel1.Controls.Add(this.btn_eraser);
            this.panel1.Location = new System.Drawing.Point(297, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(92, 98);
            this.panel1.TabIndex = 3;
            // 
            // pic_color
            // 
            this.pic_color.BackColor = System.Drawing.Color.Black;
            this.pic_color.Location = new System.Drawing.Point(648, 37);
            this.pic_color.Name = "pic_color";
            this.pic_color.Size = new System.Drawing.Size(42, 36);
            this.pic_color.TabIndex = 0;
            this.pic_color.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lbl_location);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 820);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1034, 41);
            this.panel2.TabIndex = 1;
            // 
            // lbl_location
            // 
            this.lbl_location.AutoSize = true;
            this.lbl_location.ForeColor = System.Drawing.Color.White;
            this.lbl_location.Location = new System.Drawing.Point(38, 9);
            this.lbl_location.Name = "lbl_location";
            this.lbl_location.Size = new System.Drawing.Size(22, 13);
            this.lbl_location.TabIndex = 0;
            this.lbl_location.Text = "0:0";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 6000;
            this.toolTip1.InitialDelay = 50;
            this.toolTip1.ReshowDelay = 100;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Paint.Properties.Resources.ic_location;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Black;
            this.btn_clear.BackgroundImage = global::Paint.Properties.Resources.clear;
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_clear.Location = new System.Drawing.Point(49, 49);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(40, 40);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_clear, "Clear All");
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Black;
            this.btn_save.BackgroundImage = global::Paint.Properties.Resources.ic_save;
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_save.Location = new System.Drawing.Point(49, 3);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(40, 40);
            this.btn_save.TabIndex = 11;
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_save, "Save");
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.Black;
            this.btn_new.BackgroundImage = global::Paint.Properties.Resources.ic_new;
            this.btn_new.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_new.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.ForeColor = System.Drawing.Color.White;
            this.btn_new.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_new.Location = new System.Drawing.Point(3, 3);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(40, 40);
            this.btn_new.TabIndex = 10;
            this.btn_new.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_new, "New");
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_open
            // 
            this.btn_open.BackColor = System.Drawing.Color.Black;
            this.btn_open.BackgroundImage = global::Paint.Properties.Resources.ic_open;
            this.btn_open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_open.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_open.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_open.ForeColor = System.Drawing.Color.White;
            this.btn_open.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_open.Location = new System.Drawing.Point(3, 46);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(40, 40);
            this.btn_open.TabIndex = 9;
            this.btn_open.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_open, "Open");
            this.btn_open.UseVisualStyleBackColor = false;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_cut
            // 
            this.btn_cut.BackColor = System.Drawing.Color.Black;
            this.btn_cut.BackgroundImage = global::Paint.Properties.Resources.ic_cut;
            this.btn_cut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_cut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_cut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cut.ForeColor = System.Drawing.Color.White;
            this.btn_cut.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cut.Location = new System.Drawing.Point(138, 3);
            this.btn_cut.Name = "btn_cut";
            this.btn_cut.Size = new System.Drawing.Size(40, 40);
            this.btn_cut.TabIndex = 18;
            this.btn_cut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_cut, "Cut");
            this.btn_cut.UseVisualStyleBackColor = false;
            this.btn_cut.Click += new System.EventHandler(this.btn_cut_Click);
            // 
            // btn_paste
            // 
            this.btn_paste.BackColor = System.Drawing.Color.Black;
            this.btn_paste.BackgroundImage = global::Paint.Properties.Resources.ic_paste;
            this.btn_paste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_paste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_paste.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_paste.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_paste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_paste.ForeColor = System.Drawing.Color.White;
            this.btn_paste.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_paste.Location = new System.Drawing.Point(95, 49);
            this.btn_paste.Name = "btn_paste";
            this.btn_paste.Size = new System.Drawing.Size(40, 40);
            this.btn_paste.TabIndex = 17;
            this.btn_paste.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_paste, "Paste");
            this.btn_paste.UseVisualStyleBackColor = false;
            this.btn_paste.Click += new System.EventHandler(this.btn_paste_Click);
            // 
            // btn_copy
            // 
            this.btn_copy.BackColor = System.Drawing.Color.Black;
            this.btn_copy.BackgroundImage = global::Paint.Properties.Resources.ic_copy;
            this.btn_copy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_copy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_copy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_copy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_copy.ForeColor = System.Drawing.Color.White;
            this.btn_copy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_copy.Location = new System.Drawing.Point(95, 3);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(40, 40);
            this.btn_copy.TabIndex = 16;
            this.btn_copy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_copy, "Copy");
            this.btn_copy.UseVisualStyleBackColor = false;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // btn_select
            // 
            this.btn_select.BackColor = System.Drawing.Color.Black;
            this.btn_select.BackgroundImage = global::Paint.Properties.Resources.ic_select;
            this.btn_select.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_select.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_select.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_select.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_select.ForeColor = System.Drawing.Color.White;
            this.btn_select.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_select.Location = new System.Drawing.Point(49, 49);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(40, 40);
            this.btn_select.TabIndex = 15;
            this.btn_select.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_select, "Select");
            this.btn_select.UseVisualStyleBackColor = false;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Black;
            this.btn_delete.BackgroundImage = global::Paint.Properties.Resources.ic_delete;
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_delete.Location = new System.Drawing.Point(3, 49);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(40, 40);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_delete, "Delete");
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_ungroup
            // 
            this.btn_ungroup.BackColor = System.Drawing.Color.Black;
            this.btn_ungroup.BackgroundImage = global::Paint.Properties.Resources.ic_ungroup;
            this.btn_ungroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ungroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ungroup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_ungroup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ungroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ungroup.ForeColor = System.Drawing.Color.White;
            this.btn_ungroup.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ungroup.Location = new System.Drawing.Point(49, 3);
            this.btn_ungroup.Name = "btn_ungroup";
            this.btn_ungroup.Size = new System.Drawing.Size(40, 40);
            this.btn_ungroup.TabIndex = 13;
            this.btn_ungroup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_ungroup, "Ungroup Shape");
            this.btn_ungroup.UseVisualStyleBackColor = false;
            this.btn_ungroup.Click += new System.EventHandler(this.btn_ungroup_Click);
            // 
            // btn_group
            // 
            this.btn_group.BackColor = System.Drawing.Color.Black;
            this.btn_group.BackgroundImage = global::Paint.Properties.Resources.ic_group;
            this.btn_group.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_group.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_group.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_group.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_group.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_group.ForeColor = System.Drawing.Color.White;
            this.btn_group.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_group.Location = new System.Drawing.Point(3, 3);
            this.btn_group.Name = "btn_group";
            this.btn_group.Size = new System.Drawing.Size(40, 40);
            this.btn_group.TabIndex = 12;
            this.btn_group.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_group, "Group Shape");
            this.btn_group.UseVisualStyleBackColor = false;
            this.btn_group.Click += new System.EventHandler(this.btn_group_Click);
            // 
            // btn_curve
            // 
            this.btn_curve.BackgroundImage = global::Paint.Properties.Resources.ic_curve;
            this.btn_curve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_curve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_curve.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_curve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_curve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_curve.ForeColor = System.Drawing.Color.White;
            this.btn_curve.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_curve.Location = new System.Drawing.Point(49, 49);
            this.btn_curve.Name = "btn_curve";
            this.btn_curve.Size = new System.Drawing.Size(40, 40);
            this.btn_curve.TabIndex = 9;
            this.btn_curve.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_curve, "Draw Curve");
            this.btn_curve.UseVisualStyleBackColor = true;
            this.btn_curve.Click += new System.EventHandler(this.btn_curve_Click);
            // 
            // btn_polygon
            // 
            this.btn_polygon.BackgroundImage = global::Paint.Properties.Resources.ic_polygon;
            this.btn_polygon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_polygon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_polygon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_polygon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_polygon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_polygon.ForeColor = System.Drawing.Color.White;
            this.btn_polygon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_polygon.Location = new System.Drawing.Point(3, 49);
            this.btn_polygon.Name = "btn_polygon";
            this.btn_polygon.Size = new System.Drawing.Size(40, 40);
            this.btn_polygon.TabIndex = 8;
            this.btn_polygon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_polygon, "Draw Polygon");
            this.btn_polygon.UseVisualStyleBackColor = true;
            this.btn_polygon.Click += new System.EventHandler(this.btn_polygon_Click);
            // 
            // btn_ellipse
            // 
            this.btn_ellipse.BackgroundImage = global::Paint.Properties.Resources.circle;
            this.btn_ellipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ellipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ellipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_ellipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ellipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ellipse.ForeColor = System.Drawing.Color.White;
            this.btn_ellipse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ellipse.Location = new System.Drawing.Point(95, 3);
            this.btn_ellipse.Name = "btn_ellipse";
            this.btn_ellipse.Size = new System.Drawing.Size(40, 40);
            this.btn_ellipse.TabIndex = 5;
            this.btn_ellipse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_ellipse, "Draw Ellipse");
            this.btn_ellipse.UseVisualStyleBackColor = true;
            this.btn_ellipse.Click += new System.EventHandler(this.btn_ellipse_Click);
            // 
            // btn_line
            // 
            this.btn_line.BackgroundImage = global::Paint.Properties.Resources.line;
            this.btn_line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_line.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_line.ForeColor = System.Drawing.Color.White;
            this.btn_line.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_line.Location = new System.Drawing.Point(3, 3);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(40, 40);
            this.btn_line.TabIndex = 7;
            this.btn_line.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_line, "Draw Line");
            this.btn_line.UseVisualStyleBackColor = true;
            this.btn_line.Click += new System.EventHandler(this.btn_line_Click);
            // 
            // btn_rect
            // 
            this.btn_rect.BackgroundImage = global::Paint.Properties.Resources.rectangle;
            this.btn_rect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_rect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_rect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_rect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rect.ForeColor = System.Drawing.Color.White;
            this.btn_rect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_rect.Location = new System.Drawing.Point(49, 3);
            this.btn_rect.Name = "btn_rect";
            this.btn_rect.Size = new System.Drawing.Size(40, 40);
            this.btn_rect.TabIndex = 6;
            this.btn_rect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_rect, "Draw Rectangle");
            this.btn_rect.UseVisualStyleBackColor = true;
            this.btn_rect.Click += new System.EventHandler(this.btn_rect_Click);
            // 
            // btn_fill
            // 
            this.btn_fill.BackgroundImage = global::Paint.Properties.Resources.bucket;
            this.btn_fill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_fill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_fill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fill.ForeColor = System.Drawing.Color.White;
            this.btn_fill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fill.Location = new System.Drawing.Point(3, 3);
            this.btn_fill.Name = "btn_fill";
            this.btn_fill.Size = new System.Drawing.Size(40, 40);
            this.btn_fill.TabIndex = 2;
            this.btn_fill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_fill, "Fill");
            this.btn_fill.UseVisualStyleBackColor = true;
            this.btn_fill.Click += new System.EventHandler(this.btn_fill_Click);
            // 
            // btn_pencil
            // 
            this.btn_pencil.BackgroundImage = global::Paint.Properties.Resources.pencil;
            this.btn_pencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_pencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pencil.ForeColor = System.Drawing.Color.White;
            this.btn_pencil.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_pencil.Location = new System.Drawing.Point(49, 3);
            this.btn_pencil.Name = "btn_pencil";
            this.btn_pencil.Size = new System.Drawing.Size(40, 40);
            this.btn_pencil.TabIndex = 3;
            this.btn_pencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_pencil, "Pencil");
            this.btn_pencil.UseVisualStyleBackColor = true;
            this.btn_pencil.Click += new System.EventHandler(this.btn_pencil_Click);
            // 
            // btn_eraser
            // 
            this.btn_eraser.BackgroundImage = global::Paint.Properties.Resources.eraser;
            this.btn_eraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_eraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_eraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eraser.ForeColor = System.Drawing.Color.White;
            this.btn_eraser.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_eraser.Location = new System.Drawing.Point(3, 49);
            this.btn_eraser.Name = "btn_eraser";
            this.btn_eraser.Size = new System.Drawing.Size(40, 40);
            this.btn_eraser.TabIndex = 4;
            this.btn_eraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_eraser, "Eraser");
            this.btn_eraser.UseVisualStyleBackColor = true;
            this.btn_eraser.Click += new System.EventHandler(this.btn_eraser_Click);
            // 
            // btn_color
            // 
            this.btn_color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_color.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_color.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_color.ForeColor = System.Drawing.Color.White;
            this.btn_color.Image = global::Paint.Properties.Resources.color;
            this.btn_color.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_color.Location = new System.Drawing.Point(912, 37);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(67, 63);
            this.btn_color.TabIndex = 1;
            this.btn_color.Text = "Edit color";
            this.btn_color.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_color.UseVisualStyleBackColor = true;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // color_picker
            // 
            this.color_picker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color_picker.Image = global::Paint.Properties.Resources.color_palette;
            this.color_picker.Location = new System.Drawing.Point(696, 25);
            this.color_picker.Name = "color_picker";
            this.color_picker.Size = new System.Drawing.Size(210, 87);
            this.color_picker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.color_picker.TabIndex = 8;
            this.color_picker.TabStop = false;
            this.color_picker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.color_picker_MouseClick);
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
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 861);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_lineSize)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.Button pic_color;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btn_line;
        private System.Windows.Forms.Button btn_rect;
        private System.Windows.Forms.Button btn_ellipse;
        private System.Windows.Forms.Button btn_eraser;
        private System.Windows.Forms.Button btn_pencil;
        private System.Windows.Forms.Button btn_fill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox color_picker;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_group;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_ungroup;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_polygon;
        private System.Windows.Forms.Button btn_curve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tb_lineSize;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_location;
        private System.Windows.Forms.Button btn_paste;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.Button btn_cut;
    }
}

