namespace WinFormOpenCVRec2
{
    partial class Form1
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
            pictureBox1 = new PictureBox();
            buttonStart = new Button();
            buttonStop = new Button();
            buttonChangeCamera = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label21 = new Label();
            cbRozdzielczoscVideo = new ComboBox();
            cbFormatVideo = new ComboBox();
            label22 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1393, 1308);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(34, 1347);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(112, 34);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonStop
            // 
            buttonStop.Enabled = false;
            buttonStop.Location = new Point(166, 1347);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(112, 34);
            buttonStop.TabIndex = 2;
            buttonStop.Text = "Stop";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // buttonChangeCamera
            // 
            buttonChangeCamera.Location = new Point(284, 1347);
            buttonChangeCamera.Name = "buttonChangeCamera";
            buttonChangeCamera.Size = new Size(112, 34);
            buttonChangeCamera.TabIndex = 3;
            buttonChangeCamera.Text = "button1";
            buttonChangeCamera.UseVisualStyleBackColor = true;
            buttonChangeCamera.Click += buttonChangeCamera_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1058, 1355);
            label1.Name = "label1";
            label1.Size = new Size(68, 30);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1166, 1355);
            label2.Name = "label2";
            label2.Size = new Size(68, 30);
            label2.TabIndex = 5;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1267, 1355);
            label3.Name = "label3";
            label3.Size = new Size(68, 30);
            label3.TabIndex = 6;
            label3.Text = "label3";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(465, 1311);
            label21.Margin = new Padding(5, 0, 5, 0);
            label21.Name = "label21";
            label21.Size = new Size(200, 30);
            label21.TabIndex = 4;
            label21.Text = "Rozdzielczość Video";
            // 
            // cbRozdzielczoscVideo
            // 
            cbRozdzielczoscVideo.FormattingEnabled = true;
            cbRozdzielczoscVideo.Items.AddRange(new object[] { "640 x 480 (VGA)", "1280 x 720 (HD)", "1920 x 1080 (FHD)" });
            cbRozdzielczoscVideo.Location = new Point(465, 1347);
            cbRozdzielczoscVideo.Margin = new Padding(5, 6, 5, 6);
            cbRozdzielczoscVideo.Name = "cbRozdzielczoscVideo";
            cbRozdzielczoscVideo.Size = new Size(189, 38);
            cbRozdzielczoscVideo.TabIndex = 5;
            cbRozdzielczoscVideo.SelectedIndexChanged += cbRozdzielczoscVideo_SelectedIndexChanged;
            // 
            // cbFormatVideo
            // 
            cbFormatVideo.FormattingEnabled = true;
            cbFormatVideo.Items.AddRange(new object[] { "H265", "MPG4", "HEVC" });
            cbFormatVideo.Location = new Point(717, 1347);
            cbFormatVideo.Margin = new Padding(5, 6, 5, 6);
            cbFormatVideo.Name = "cbFormatVideo";
            cbFormatVideo.Size = new Size(205, 38);
            cbFormatVideo.TabIndex = 6;
            cbFormatVideo.SelectedIndexChanged += cbFormatVideo_SelectedIndexChanged;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(751, 1311);
            label22.Margin = new Padding(5, 0, 5, 0);
            label22.Name = "label22";
            label22.Size = new Size(137, 30);
            label22.TabIndex = 7;
            label22.Text = "Format Video";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1393, 1393);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonChangeCamera);
            Controls.Add(buttonStop);
            Controls.Add(buttonStart);
            Controls.Add(pictureBox1);
            Controls.Add(label22);
            Controls.Add(cbFormatVideo);
            Controls.Add(cbRozdzielczoscVideo);
            Controls.Add(label21);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private PictureBox pictureBox1;
        private Button buttonStart;
        private Button buttonStop;
        private Button buttonChangeCamera;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label21;
        private ComboBox cbRozdzielczoscVideo;
        private ComboBox cbFormatVideo;
        private Label label22;
    }
}