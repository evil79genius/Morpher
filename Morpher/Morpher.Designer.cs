namespace Morpher
{
    partial class Morpher
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Morpher));
            openFileDialog = new OpenFileDialog();
            tableLayoutPanel1 = new TableLayoutPanel();
            patternBox = new GroupBox();
            patternSave = new Button();
            patternOpen = new Button();
            patternFile = new TextBox();
            imageBarH = new TrackBar();
            patternBarH = new TrackBar();
            patternBarV = new TrackBar();
            imageBarV = new TrackBar();
            imageBox = new GroupBox();
            imageSave = new Button();
            imageOpen = new Button();
            imageFile = new TextBox();
            imagePictureBox = new PictureBox();
            patternPictureBox = new PictureBox();
            direction = new Button();
            saveFileDialog = new SaveFileDialog();
            tableLayoutPanel1.SuspendLayout();
            patternBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imageBarH).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patternBarH).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patternBarV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imageBarV).BeginInit();
            imageBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patternPictureBox).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(patternBox, 0, 0);
            tableLayoutPanel1.Controls.Add(imageBarH, 4, 1);
            tableLayoutPanel1.Controls.Add(patternBarH, 1, 1);
            tableLayoutPanel1.Controls.Add(patternBarV, 0, 2);
            tableLayoutPanel1.Controls.Add(imageBarV, 3, 2);
            tableLayoutPanel1.Controls.Add(imageBox, 3, 0);
            tableLayoutPanel1.Controls.Add(imagePictureBox, 4, 2);
            tableLayoutPanel1.Controls.Add(patternPictureBox, 1, 2);
            tableLayoutPanel1.Controls.Add(direction, 2, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(829, 461);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // patternBox
            // 
            tableLayoutPanel1.SetColumnSpan(patternBox, 2);
            patternBox.Controls.Add(patternSave);
            patternBox.Controls.Add(patternOpen);
            patternBox.Controls.Add(patternFile);
            patternBox.Dock = DockStyle.Fill;
            patternBox.Location = new Point(3, 3);
            patternBox.Name = "patternBox";
            patternBox.Size = new Size(394, 55);
            patternBox.TabIndex = 0;
            patternBox.TabStop = false;
            patternBox.Text = "Pattern";
            // 
            // patternSave
            // 
            patternSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            patternSave.Image = (Image)resources.GetObject("patternSave.Image");
            patternSave.Location = new Point(363, 22);
            patternSave.Name = "patternSave";
            patternSave.Size = new Size(23, 23);
            patternSave.TabIndex = 2;
            patternSave.UseVisualStyleBackColor = true;
            patternSave.Click += patternSave_Click;
            // 
            // patternOpen
            // 
            patternOpen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            patternOpen.Image = (Image)resources.GetObject("patternOpen.Image");
            patternOpen.Location = new Point(334, 22);
            patternOpen.Name = "patternOpen";
            patternOpen.Size = new Size(23, 23);
            patternOpen.TabIndex = 1;
            patternOpen.UseVisualStyleBackColor = true;
            patternOpen.Click += patternOpen_Click;
            // 
            // patternFile
            // 
            patternFile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            patternFile.Location = new Point(9, 22);
            patternFile.Name = "patternFile";
            patternFile.Size = new Size(318, 23);
            patternFile.TabIndex = 0;
            // 
            // imageBarH
            // 
            imageBarH.Dock = DockStyle.Fill;
            imageBarH.Location = new Point(470, 64);
            imageBarH.Name = "imageBarH";
            imageBarH.Size = new Size(356, 32);
            imageBarH.TabIndex = 2;
            imageBarH.Value = 5;
            // 
            // patternBarH
            // 
            patternBarH.Dock = DockStyle.Fill;
            patternBarH.Location = new Point(41, 64);
            patternBarH.Name = "patternBarH";
            patternBarH.Size = new Size(356, 32);
            patternBarH.TabIndex = 3;
            patternBarH.Value = 5;
            // 
            // patternBarV
            // 
            patternBarV.Dock = DockStyle.Fill;
            patternBarV.Location = new Point(3, 102);
            patternBarV.Name = "patternBarV";
            patternBarV.Orientation = Orientation.Vertical;
            patternBarV.Size = new Size(32, 356);
            patternBarV.TabIndex = 4;
            patternBarV.Value = 5;
            // 
            // imageBarV
            // 
            imageBarV.Dock = DockStyle.Fill;
            imageBarV.Location = new Point(432, 102);
            imageBarV.Name = "imageBarV";
            imageBarV.Orientation = Orientation.Vertical;
            imageBarV.Size = new Size(32, 356);
            imageBarV.TabIndex = 5;
            imageBarV.Value = 5;
            // 
            // imageBox
            // 
            tableLayoutPanel1.SetColumnSpan(imageBox, 2);
            imageBox.Controls.Add(imageSave);
            imageBox.Controls.Add(imageOpen);
            imageBox.Controls.Add(imageFile);
            imageBox.Dock = DockStyle.Fill;
            imageBox.Location = new Point(432, 3);
            imageBox.Name = "imageBox";
            imageBox.Size = new Size(394, 55);
            imageBox.TabIndex = 6;
            imageBox.TabStop = false;
            imageBox.Text = "Image";
            // 
            // imageSave
            // 
            imageSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            imageSave.Image = (Image)resources.GetObject("imageSave.Image");
            imageSave.Location = new Point(363, 22);
            imageSave.Name = "imageSave";
            imageSave.Size = new Size(23, 23);
            imageSave.TabIndex = 3;
            imageSave.UseVisualStyleBackColor = true;
            imageSave.Click += imageSave_Click;
            // 
            // imageOpen
            // 
            imageOpen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            imageOpen.Image = (Image)resources.GetObject("imageOpen.Image");
            imageOpen.Location = new Point(334, 22);
            imageOpen.Name = "imageOpen";
            imageOpen.Size = new Size(23, 23);
            imageOpen.TabIndex = 2;
            imageOpen.UseVisualStyleBackColor = true;
            imageOpen.Click += imageOpen_Click;
            // 
            // imageFile
            // 
            imageFile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            imageFile.Location = new Point(9, 22);
            imageFile.Name = "imageFile";
            imageFile.Size = new Size(318, 23);
            imageFile.TabIndex = 1;
            // 
            // imagePictureBox
            // 
            imagePictureBox.Dock = DockStyle.Fill;
            imagePictureBox.Location = new Point(483, 115);
            imagePictureBox.Margin = new Padding(16);
            imagePictureBox.Name = "imagePictureBox";
            imagePictureBox.Size = new Size(330, 330);
            imagePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            imagePictureBox.TabIndex = 8;
            imagePictureBox.TabStop = false;
            // 
            // patternPictureBox
            // 
            patternPictureBox.Dock = DockStyle.Fill;
            patternPictureBox.Location = new Point(54, 115);
            patternPictureBox.Margin = new Padding(16);
            patternPictureBox.Name = "patternPictureBox";
            patternPictureBox.Size = new Size(330, 330);
            patternPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            patternPictureBox.TabIndex = 7;
            patternPictureBox.TabStop = false;
            // 
            // direction
            // 
            direction.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            direction.Location = new Point(403, 102);
            direction.Name = "direction";
            direction.Size = new Size(23, 356);
            direction.TabIndex = 9;
            direction.Text = ">";
            direction.UseVisualStyleBackColor = true;
            direction.Click += direction_Click;
            // 
            // Morpher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 461);
            Controls.Add(tableLayoutPanel1);
            Name = "Morpher";
            Text = "Morpher";
            Resize += Morpher_Resize;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            patternBox.ResumeLayout(false);
            patternBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imageBarH).EndInit();
            ((System.ComponentModel.ISupportInitialize)patternBarH).EndInit();
            ((System.ComponentModel.ISupportInitialize)patternBarV).EndInit();
            ((System.ComponentModel.ISupportInitialize)imageBarV).EndInit();
            imageBox.ResumeLayout(false);
            imageBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imagePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)patternPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private OpenFileDialog openFileDialog;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox patternBox;
        private Button patternOpen;
        private TextBox patternFile;
        private Button patternSave;
        private TrackBar imageBarH;
        private TrackBar patternBarH;
        private TrackBar patternBarV;
        private TrackBar imageBarV;
        private GroupBox imageBox;
        private Button imageOpen;
        private TextBox imageFile;
        private Button imageSave;
        private SaveFileDialog saveFileDialog;
        private PictureBox patternPictureBox;
        private PictureBox imagePictureBox;
        private Button direction;
    }
}
