namespace WinFormsOpenCvRecorder
{
    partial class FormGrabber
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
            pictureBox1.Location = new Point(512, -1);
            pictureBox1.Margin = new Padding(2, 3, 2, 3);
            pictureBox1.MinimumSize = new Size(640, 480);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(684, 480);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Resize += pictureBox1_Resize;
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
            // cbCamera
            // 
            cbCamera.FormattingEnabled = true;
            cbCamera.Location = new Point(134, 33);
            cbCamera.Margin = new Padding(3, 4, 3, 4);
            cbCamera.Name = "cbCamera";
            cbCamera.Size = new Size(248, 28);
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
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.settings_824700;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(388, 12);
            button1.Name = "button1";
            button1.Size = new Size(62, 62);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormGrabber
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 1032);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(cbCamera);
            Controls.Add(groupBox1);
            Controls.Add(buttonTakeSnapshot);
            Controls.Add(buttonStop);
            Controls.Add(buttonStart);
            Controls.Add(pictureBox1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "FormGrabber";
            Text = "Grabber Video";
            Load += Form1_Load;
            Leave += Form1_Leave;
            Resize += Form1_Resize;
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
        private ComboBox cbCamera;
        private Label label3;
        private GroupBox groupBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
    }
}