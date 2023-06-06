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
            trackBar1 = new TrackBar();
            pauseButton = new Button();
            ((System.ComponentModel.ISupportInitialize)vlcControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // vlcControl
            // 
            vlcControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            vlcControl.BackColor = Color.Black;
            vlcControl.Location = new Point(0, 2);
            vlcControl.Margin = new Padding(4);
            vlcControl.MediaPlayer = null;
            vlcControl.Name = "vlcControl";
            vlcControl.Size = new Size(1343, 642);
            vlcControl.TabIndex = 0;
            vlcControl.Text = "vlcControl";
            vlcControl.ClientSizeChanged += vlcControl_ClientSizeChanged;
            vlcControl.ParentChanged += vlcControl_ParentChanged;
            // 
            // lblMovieDuration
            // 
            lblMovieDuration.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblMovieDuration.AutoSize = true;
            lblMovieDuration.BackColor = Color.Black;
            lblMovieDuration.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblMovieDuration.ForeColor = Color.Lime;
            lblMovieDuration.Location = new Point(1156, 703);
            lblMovieDuration.Name = "lblMovieDuration";
            lblMovieDuration.Size = new Size(173, 54);
            lblMovieDuration.TabIndex = 6;
            lblMovieDuration.Text = "00:00:00";
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTime.AutoSize = true;
            lblTime.BackColor = Color.Black;
            lblTime.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblTime.ForeColor = Color.Lime;
            lblTime.Location = new Point(12, 703);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(173, 54);
            lblTime.TabIndex = 6;
            lblTime.Text = "00:00:00";
            // 
            // playButton
            // 
            playButton.Anchor = AnchorStyles.Bottom;
            playButton.FlatStyle = FlatStyle.Flat;
            playButton.Image = (Image)resources.GetObject("playButton.Image");
            playButton.Location = new Point(364, 702);
            playButton.Name = "playButton";
            playButton.Size = new Size(93, 83);
            playButton.TabIndex = 7;
            playButton.UseVisualStyleBackColor = true;
            playButton.Click += playButton_Click;
            // 
            // backButton
            // 
            backButton.Anchor = AnchorStyles.Bottom;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Image = (Image)resources.GetObject("backButton.Image");
            backButton.Location = new Point(463, 702);
            backButton.Name = "backButton";
            backButton.Size = new Size(93, 83);
            backButton.TabIndex = 8;
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // stopButton
            // 
            stopButton.Anchor = AnchorStyles.Bottom;
            stopButton.FlatStyle = FlatStyle.Flat;
            stopButton.Image = (Image)resources.GetObject("stopButton.Image");
            stopButton.Location = new Point(562, 702);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(93, 83);
            stopButton.TabIndex = 8;
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += stopButton_Click;
            // 
            // forwardButton
            // 
            forwardButton.Anchor = AnchorStyles.Bottom;
            forwardButton.FlatStyle = FlatStyle.Flat;
            forwardButton.Image = (Image)resources.GetObject("forwardButton.Image");
            forwardButton.Location = new Point(661, 702);
            forwardButton.Name = "forwardButton";
            forwardButton.Size = new Size(93, 83);
            forwardButton.TabIndex = 8;
            forwardButton.UseVisualStyleBackColor = true;
            forwardButton.Click += forwardButton_Click;
            // 
            // snapshotButton
            // 
            snapshotButton.Anchor = AnchorStyles.Bottom;
            snapshotButton.FlatStyle = FlatStyle.Flat;
            snapshotButton.Image = (Image)resources.GetObject("snapshotButton.Image");
            snapshotButton.Location = new Point(760, 702);
            snapshotButton.Name = "snapshotButton";
            snapshotButton.Size = new Size(93, 83);
            snapshotButton.TabIndex = 8;
            snapshotButton.UseVisualStyleBackColor = true;
            snapshotButton.Click += snapshotButton_Click;
            // 
            // stepButton
            // 
            stepButton.Anchor = AnchorStyles.Bottom;
            stepButton.FlatStyle = FlatStyle.Flat;
            stepButton.Image = (Image)resources.GetObject("stepButton.Image");
            stepButton.Location = new Point(859, 702);
            stepButton.Name = "stepButton";
            stepButton.Size = new Size(93, 83);
            stepButton.TabIndex = 8;
            stepButton.UseVisualStyleBackColor = true;
            stepButton.Click += stepButton_Click;
            // 
            // trackBar1
            // 
            trackBar1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            trackBar1.BackColor = Color.Black;
            trackBar1.Location = new Point(12, 652);
            trackBar1.Margin = new Padding(4);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(1331, 69);
            trackBar1.TabIndex = 3;
            trackBar1.TickStyle = TickStyle.TopLeft;
            trackBar1.Scroll += trackBar1_Scroll;
            trackBar1.MouseDown += trackBar1_MouseDown;
            trackBar1.MouseMove += trackBar1_MouseMove;
            trackBar1.MouseUp += trackBar1_MouseUp;
            // 
            // pauseButton
            // 
            pauseButton.Anchor = AnchorStyles.Bottom;
            pauseButton.FlatStyle = FlatStyle.Flat;
            pauseButton.Image = (Image)resources.GetObject("pauseButton.Image");
            pauseButton.Location = new Point(364, 702);
            pauseButton.Name = "pauseButton";
            pauseButton.Size = new Size(93, 83);
            pauseButton.TabIndex = 7;
            pauseButton.UseVisualStyleBackColor = true;
            pauseButton.Click += playButton_Click;
            // 
            // PlayerForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1341, 792);
            Controls.Add(lblTime);
            Controls.Add(lblMovieDuration);
            Controls.Add(trackBar1);
            Controls.Add(stepButton);
            Controls.Add(vlcControl);
            Controls.Add(snapshotButton);
            Controls.Add(forwardButton);
            Controls.Add(pauseButton);
            Controls.Add(playButton);
            Controls.Add(stopButton);
            Controls.Add(backButton);
            Margin = new Padding(4);
            Name = "PlayerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gabos Video Player";
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
        private Label lblMovieDuration;
        private Label lblTime;
        private Button playButton;
        private Button backButton;
        private Button stopButton;
        private Button forwardButton;
        private Button snapshotButton;
        private Button stepButton;
        private TrackBar trackBar1;
        private Button pauseButton;
    }
}