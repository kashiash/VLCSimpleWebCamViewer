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
            groupBox1 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Location = new Point(512, 0);
            pictureBox1.Margin = new Padding(2, 3, 2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(914, 1135);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(9, 843);
            buttonStart.Margin = new Padding(2, 3, 2, 3);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(89, 43);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "START";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonStop
            // 
            buttonStop.Location = new Point(103, 843);
            buttonStop.Margin = new Padding(2, 3, 2, 3);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(89, 43);
            buttonStop.TabIndex = 2;
            buttonStop.Text = "STOP";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // buttonTakeSnapshot
            // 
            buttonTakeSnapshot.Image = Properties.Resources.screenshot_32;
            buttonTakeSnapshot.Location = new Point(197, 831);
            buttonTakeSnapshot.Margin = new Padding(2, 3, 2, 3);
            buttonTakeSnapshot.Name = "buttonTakeSnapshot";
            buttonTakeSnapshot.Size = new Size(63, 53);
            buttonTakeSnapshot.TabIndex = 3;
            buttonTakeSnapshot.UseVisualStyleBackColor = true;
            buttonTakeSnapshot.Click += buttonTakeSnapshot_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(344, 831);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 4;
            label1.Text = "Rozdzielczość Video";
            // 
            // cbRozdzielczoscVideo
            // 
            cbRozdzielczoscVideo.FormattingEnabled = true;
            cbRozdzielczoscVideo.Items.AddRange(new object[] { "640 x 480 (VGA)", "1280 x 720 (HD)", "1920 x 1080 (FHD)" });
            cbRozdzielczoscVideo.Location = new Point(344, 855);
            cbRozdzielczoscVideo.Margin = new Padding(3, 4, 3, 4);
            cbRozdzielczoscVideo.Name = "cbRozdzielczoscVideo";
            cbRozdzielczoscVideo.Size = new Size(127, 28);
            cbRozdzielczoscVideo.TabIndex = 5;
            cbRozdzielczoscVideo.SelectedIndexChanged += cbRozdzielczoscVideo_SelectedIndexChanged;
            // 
            // cbFormatVideo
            // 
            cbFormatVideo.FormattingEnabled = true;
            cbFormatVideo.Items.AddRange(new object[] { "H265", "MPG4", "HEVC" });
            cbFormatVideo.Location = new Point(512, 855);
            cbFormatVideo.Margin = new Padding(3, 4, 3, 4);
            cbFormatVideo.Name = "cbFormatVideo";
            cbFormatVideo.Size = new Size(138, 28);
            cbFormatVideo.TabIndex = 6;
            cbFormatVideo.SelectedIndexChanged += cbFormatVideo_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(535, 831);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 7;
            label2.Text = "Format Video";
            // 
            // cbCamera
            // 
            cbCamera.FormattingEnabled = true;
            cbCamera.Location = new Point(134, 33);
            cbCamera.Margin = new Padding(3, 4, 3, 4);
            cbCamera.Name = "cbCamera";
            cbCamera.Size = new Size(195, 28);
            cbCamera.TabIndex = 8;
            cbCamera.SelectedIndexChanged += cbCamera_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 36);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 9;
            label3.Text = "Urządzenie";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Location = new Point(24, 69);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(474, 727);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Multimedia";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(16, 40);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(449, 624);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.settings_824700;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(388, 12);
            button1.Name = "button1";
            button1.Size = new Size(62, 62);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1426, 1032);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(cbCamera);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(cbFormatVideo);
            Controls.Add(cbRozdzielczoscVideo);
            Controls.Add(label1);
            Controls.Add(buttonTakeSnapshot);
            Controls.Add(buttonStop);
            Controls.Add(buttonStart);
            Controls.Add(pictureBox1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Leave += Form1_Leave;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
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
        private GroupBox groupBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
    }
}