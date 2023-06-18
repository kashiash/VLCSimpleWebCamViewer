namespace WinFormsOpenCvRecorder
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
            buttonTakeSnapshot = new Button();
            label1 = new Label();
            cbRozdzielczoscVideo = new ComboBox();
            cbFormatVideo = new ComboBox();
            label2 = new Label();
            cbCamera = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(2491, 1214);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(14, 1264);
            buttonStart.Margin = new Padding(3, 4, 3, 4);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(134, 64);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "START";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonStop
            // 
            buttonStop.Location = new Point(154, 1264);
            buttonStop.Margin = new Padding(3, 4, 3, 4);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(134, 64);
            buttonStop.TabIndex = 2;
            buttonStop.Text = "STOP";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // buttonTakeSnapshot
            // 
            buttonTakeSnapshot.Image = Properties.Resources.screenshot_32;
            buttonTakeSnapshot.Location = new Point(295, 1246);
            buttonTakeSnapshot.Margin = new Padding(3, 4, 3, 4);
            buttonTakeSnapshot.Name = "buttonTakeSnapshot";
            buttonTakeSnapshot.Size = new Size(94, 80);
            buttonTakeSnapshot.TabIndex = 3;
            buttonTakeSnapshot.UseVisualStyleBackColor = true;
            buttonTakeSnapshot.Click += buttonTakeSnapshot_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(516, 1246);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(200, 30);
            label1.TabIndex = 4;
            label1.Text = "Rozdzielczość Video";
            // 
            // cbRozdzielczoscVideo
            // 
            cbRozdzielczoscVideo.FormattingEnabled = true;
            cbRozdzielczoscVideo.Items.AddRange(new object[] { "640 x 480 (VGA)", "1280 x 720 (HD)", "1920 x 1080 (FHD)" });
            cbRozdzielczoscVideo.Location = new Point(516, 1282);
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
            cbFormatVideo.Location = new Point(768, 1282);
            cbFormatVideo.Margin = new Padding(5, 6, 5, 6);
            cbFormatVideo.Name = "cbFormatVideo";
            cbFormatVideo.Size = new Size(205, 38);
            cbFormatVideo.TabIndex = 6;
            cbFormatVideo.SelectedIndexChanged += cbFormatVideo_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(802, 1246);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(137, 30);
            label2.TabIndex = 7;
            label2.Text = "Format Video";
            // 
            // cbCamera
            // 
            cbCamera.FormattingEnabled = true;
            cbCamera.Location = new Point(1071, 1282);
            cbCamera.Margin = new Padding(5, 6, 5, 6);
            cbCamera.Name = "cbCamera";
            cbCamera.Size = new Size(290, 38);
            cbCamera.TabIndex = 8;
            cbCamera.SelectedIndexChanged += cbCamera_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1178, 1246);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(83, 30);
            label3.TabIndex = 9;
            label3.Text = "Kamera";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2491, 1345);
            Controls.Add(label3);
            Controls.Add(cbCamera);
            Controls.Add(label2);
            Controls.Add(cbFormatVideo);
            Controls.Add(cbRozdzielczoscVideo);
            Controls.Add(label1);
            Controls.Add(buttonTakeSnapshot);
            Controls.Add(buttonStop);
            Controls.Add(buttonStart);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Leave += Form1_Leave;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonStart;
        private Button buttonStop;
        private Button buttonTakeSnapshot;
        private Label label1;
        private ComboBox cbRozdzielczoscVideo;
        private ComboBox cbFormatVideo;
        private Label label2;
        private ComboBox cbCamera;
        private Label label3;
    }
}