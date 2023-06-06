using System.Windows.Forms;

namespace VlcClient
{
    partial class PlayerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerForm));
            vlcControl = new LibVLCSharp.WinForms.VideoView();
            lblMovieDuration = new Label();
            lblTime = new Label();
            playButton = new Button();
            backButton = new Button();
            stopButton = new Button();
            forwardButton = new Button();
            snapshotButton = new Button();
            stepButton = new Button();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            trackBar1 = new TrackBar();
            tableLayoutPanel2 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)vlcControl).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // vlcControl
            // 
            vlcControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            vlcControl.BackColor = Color.Black;
            vlcControl.Location = new Point(0, 0);
            vlcControl.Margin = new Padding(4);
            vlcControl.MediaPlayer = null;
            vlcControl.Name = "vlcControl";
            vlcControl.Size = new Size(1300, 583);
            vlcControl.TabIndex = 0;
            vlcControl.Text = "vlcControl";
            vlcControl.ClientSizeChanged += vlcControl_ClientSizeChanged;
            vlcControl.Click += vlcControl_Click;
            vlcControl.MouseDown += vlcControl_MouseDown;
            vlcControl.MouseMove += vlcControl_MouseMove;
            vlcControl.MouseUp += vlcControl_MouseUp;
            vlcControl.ParentChanged += vlcControl_ParentChanged;
            // 
            // lblMovieDuration
            // 
            lblMovieDuration.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblMovieDuration.AutoSize = true;
            lblMovieDuration.BackColor = Color.Black;
            lblMovieDuration.ForeColor = Color.Lime;
            lblMovieDuration.Location = new Point(1188, 71);
            lblMovieDuration.Name = "lblMovieDuration";
            lblMovieDuration.Size = new Size(89, 30);
            lblMovieDuration.TabIndex = 6;
            lblMovieDuration.Text = "00:00:00";
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTime.AutoSize = true;
            lblTime.BackColor = Color.Black;
            lblTime.ForeColor = Color.Lime;
            lblTime.Location = new Point(3, 71);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(89, 30);
            lblTime.TabIndex = 6;
            lblTime.Text = "00:00:00";
            // 
            // playButton
            // 
            playButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            playButton.FlatStyle = FlatStyle.Flat;
            playButton.Image = (Image)resources.GetObject("playButton.Image");
            playButton.Location = new Point(3, 3);
            playButton.Name = "playButton";
            playButton.Size = new Size(93, 83);
            playButton.TabIndex = 7;
            playButton.UseVisualStyleBackColor = true;
            playButton.Click += playButton_Click;
            // 
            // backButton
            // 
            backButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Image = (Image)resources.GetObject("backButton.Image");
            backButton.Location = new Point(102, 3);
            backButton.Name = "backButton";
            backButton.Size = new Size(93, 83);
            backButton.TabIndex = 8;
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // stopButton
            // 
            stopButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            stopButton.FlatStyle = FlatStyle.Flat;
            stopButton.Image = (Image)resources.GetObject("stopButton.Image");
            stopButton.Location = new Point(201, 3);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(93, 83);
            stopButton.TabIndex = 8;
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += stopButton_Click;
            // 
            // forwardButton
            // 
            forwardButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            forwardButton.FlatStyle = FlatStyle.Flat;
            forwardButton.Image = (Image)resources.GetObject("forwardButton.Image");
            forwardButton.Location = new Point(300, 3);
            forwardButton.Name = "forwardButton";
            forwardButton.Size = new Size(93, 83);
            forwardButton.TabIndex = 8;
            forwardButton.UseVisualStyleBackColor = true;
            forwardButton.Click += forwardButton_Click;
            // 
            // snapshotButton
            // 
            snapshotButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            snapshotButton.FlatStyle = FlatStyle.Flat;
            snapshotButton.Image = (Image)resources.GetObject("snapshotButton.Image");
            snapshotButton.Location = new Point(399, 3);
            snapshotButton.Name = "snapshotButton";
            snapshotButton.Size = new Size(93, 83);
            snapshotButton.TabIndex = 8;
            snapshotButton.UseVisualStyleBackColor = true;
            snapshotButton.Click += snapshotButton_Click;
            // 
            // stepButton
            // 
            stepButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            stepButton.FlatStyle = FlatStyle.Flat;
            stepButton.Image = (Image)resources.GetObject("stepButton.Image");
            stepButton.Location = new Point(498, 3);
            stepButton.Name = "stepButton";
            stepButton.Size = new Size(93, 83);
            stepButton.TabIndex = 8;
            stepButton.UseVisualStyleBackColor = true;
            stepButton.Click += stepButton_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Location = new Point(0, 812);
            panel1.Name = "panel1";
            panel1.Size = new Size(1300, 138);
            panel1.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Controls.Add(stepButton, 5, 0);
            tableLayoutPanel1.Controls.Add(snapshotButton, 4, 0);
            tableLayoutPanel1.Controls.Add(forwardButton, 3, 0);
            tableLayoutPanel1.Controls.Add(stopButton, 2, 0);
            tableLayoutPanel1.Controls.Add(backButton, 1, 0);
            tableLayoutPanel1.Controls.Add(playButton, 0, 0);
            tableLayoutPanel1.Location = new Point(363, 39);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(594, 89);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(lblMovieDuration);
            panel2.Controls.Add(lblTime);
            panel2.Controls.Add(trackBar1);
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Location = new Point(11, 809);
            panel2.Name = "panel2";
            panel2.Size = new Size(1286, 138);
            panel2.TabIndex = 9;
            // 
            // trackBar1
            // 
            trackBar1.BackColor = Color.Black;
            trackBar1.Dock = DockStyle.Top;
            trackBar1.Location = new Point(0, 0);
            trackBar1.Margin = new Padding(4);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(1286, 69);
            trackBar1.TabIndex = 3;
            trackBar1.TickStyle = TickStyle.TopLeft;
            trackBar1.Scroll += trackBar1_Scroll;
            trackBar1.MouseDown += trackBar1_MouseDown;
            trackBar1.MouseMove += trackBar1_MouseMove;
            trackBar1.MouseUp += trackBar1_MouseUp;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.None;
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.Controls.Add(button1, 5, 0);
            tableLayoutPanel2.Controls.Add(button2, 4, 0);
            tableLayoutPanel2.Controls.Add(button3, 3, 0);
            tableLayoutPanel2.Controls.Add(button4, 2, 0);
            tableLayoutPanel2.Controls.Add(button5, 1, 0);
            tableLayoutPanel2.Controls.Add(button6, 0, 0);
            tableLayoutPanel2.Location = new Point(364, 71);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(564, 57);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(473, 3);
            button1.Name = "button1";
            button1.Size = new Size(88, 51);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = true;
            button1.Click += stepButton_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(379, 3);
            button2.Name = "button2";
            button2.Size = new Size(88, 51);
            button2.TabIndex = 8;
            button2.UseVisualStyleBackColor = true;
            button2.Click += snapshotButton_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(285, 3);
            button3.Name = "button3";
            button3.Size = new Size(88, 51);
            button3.TabIndex = 8;
            button3.UseVisualStyleBackColor = true;
            button3.Click += forwardButton_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(191, 3);
            button4.Name = "button4";
            button4.Size = new Size(88, 51);
            button4.TabIndex = 8;
            button4.UseVisualStyleBackColor = true;
            button4.Click += stopButton_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(97, 3);
            button5.Name = "button5";
            button5.Size = new Size(88, 51);
            button5.TabIndex = 8;
            button5.UseVisualStyleBackColor = true;
            button5.Click += backButton_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(3, 3);
            button6.Name = "button6";
            button6.Size = new Size(88, 51);
            button6.TabIndex = 7;
            button6.UseVisualStyleBackColor = true;
            button6.Click += playButton_Click;
            // 
            // PlayerForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1300, 950);
            Controls.Add(vlcControl);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "PlayerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gabos Video Player";
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            ((System.ComponentModel.ISupportInitialize)vlcControl).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private LibVLCSharp.WinForms.VideoView vlcControl;
        private Label lblMovieDuration;
        private Label lblTime;
        private Button playButton;
        private Button backButton;
        private Button stopButton;
        private Button forwardButton;
        private Button snapshotButton;
        private Button stepButton;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private TrackBar trackBar1;
    }
}