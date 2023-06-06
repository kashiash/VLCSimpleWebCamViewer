namespace VlcClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            vlcControl = new LibVLCSharp.WinForms.VideoView();
            trackBar1 = new TrackBar();
            lblMovieDuration = new Label();
            lblTime = new Label();
            playButton = new Button();
            backButton = new Button();
            stopButton = new Button();
            forwardButton = new Button();
            snapshotButton = new Button();
            stepButton = new Button();
            ((System.ComponentModel.ISupportInitialize)vlcControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
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
            vlcControl.Size = new Size(2748, 895);
            vlcControl.TabIndex = 0;
            vlcControl.Text = "vlcControl";
            vlcControl.ClientSizeChanged += vlcControl_ClientSizeChanged;
            vlcControl.MouseDown += vlcControl_MouseDown;
            vlcControl.MouseMove += vlcControl_MouseMove;
            vlcControl.MouseUp += vlcControl_MouseUp;
            vlcControl.ParentChanged += vlcControl_ParentChanged;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(0, 903);
            trackBar1.Margin = new Padding(4);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(2744, 69);
            trackBar1.TabIndex = 3;
            trackBar1.TickStyle = TickStyle.Both;
            trackBar1.Scroll += trackBar1_Scroll;
            trackBar1.MouseDown += trackBar1_MouseDown;
            trackBar1.MouseMove += trackBar1_MouseMove;
            trackBar1.MouseUp += trackBar1_MouseUp;
            // 
            // lblMovieDuration
            // 
            lblMovieDuration.AutoSize = true;
            lblMovieDuration.BackColor = Color.Black;
            lblMovieDuration.ForeColor = Color.Lime;
            lblMovieDuration.Location = new Point(2460, 899);
            lblMovieDuration.Name = "lblMovieDuration";
            lblMovieDuration.Size = new Size(89, 30);
            lblMovieDuration.TabIndex = 6;
            lblMovieDuration.Text = "00:00:00";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.BackColor = Color.Black;
            lblTime.ForeColor = Color.Lime;
            lblTime.Location = new Point(2555, 899);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(89, 30);
            lblTime.TabIndex = 6;
            lblTime.Text = "00:00:00";
            // 
            // playButton
            // 
            playButton.Image = (Image)resources.GetObject("playButton.Image");
            playButton.Location = new Point(6, 964);
            playButton.Name = "playButton";
            playButton.Size = new Size(67, 66);
            playButton.TabIndex = 7;
            playButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            backButton.Image = (Image)resources.GetObject("backButton.Image");
            backButton.Location = new Point(79, 964);
            backButton.Name = "backButton";
            backButton.Size = new Size(67, 66);
            backButton.TabIndex = 8;
            backButton.UseVisualStyleBackColor = true;
            // 
            // stopButton
            // 
            stopButton.Image = (Image)resources.GetObject("stopButton.Image");
            stopButton.Location = new Point(152, 964);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(67, 66);
            stopButton.TabIndex = 8;
            stopButton.UseVisualStyleBackColor = true;
            // 
            // forwardButton
            // 
            forwardButton.Image = (Image)resources.GetObject("forwardButton.Image");
            forwardButton.Location = new Point(225, 964);
            forwardButton.Name = "forwardButton";
            forwardButton.Size = new Size(67, 66);
            forwardButton.TabIndex = 8;
            forwardButton.UseVisualStyleBackColor = true;
            // 
            // snapshotButton
            // 
            snapshotButton.Image = (Image)resources.GetObject("snapshotButton.Image");
            snapshotButton.Location = new Point(298, 964);
            snapshotButton.Name = "snapshotButton";
            snapshotButton.Size = new Size(67, 66);
            snapshotButton.TabIndex = 8;
            snapshotButton.UseVisualStyleBackColor = true;
            // 
            // stepButton
            // 
            stepButton.Image = (Image)resources.GetObject("stepButton.Image");
            stepButton.Location = new Point(371, 964);
            stepButton.Name = "stepButton";
            stepButton.Size = new Size(67, 66);
            stepButton.TabIndex = 8;
            stepButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2748, 1152);
            Controls.Add(stepButton);
            Controls.Add(snapshotButton);
            Controls.Add(forwardButton);
            Controls.Add(stopButton);
            Controls.Add(backButton);
            Controls.Add(playButton);
            Controls.Add(lblTime);
            Controls.Add(lblMovieDuration);
            Controls.Add(trackBar1);
            Controls.Add(vlcControl);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            ((System.ComponentModel.ISupportInitialize)vlcControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LibVLCSharp.WinForms.VideoView vlcControl;
        private TrackBar trackBar1;
        private Label lblMovieDuration;
        private Label lblTime;
        private Button playButton;
        private Button backButton;
        private Button stopButton;
        private Button forwardButton;
        private Button snapshotButton;
        private Button stepButton;
    }
}