namespace WinFormsViewer
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
            videoView1 = new LibVLCSharp.WinForms.VideoView();
            videoView2 = new LibVLCSharp.WinForms.VideoView();
            button1 = new Button();
            button2 = new Button();
            buttonTakeSnapshot = new Button();
            splitContainer1 = new SplitContainer();
            button8 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button9 = new Button();
            button7 = new Button();
            CAMERA = new Button();
            ((System.ComponentModel.ISupportInitialize)videoView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)videoView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // videoView1
            // 
            videoView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            videoView1.BackColor = Color.Black;
            videoView1.Location = new Point(11, 8);
            videoView1.MediaPlayer = null;
            videoView1.Name = "videoView1";
            videoView1.Size = new Size(1427, 1018);
            videoView1.TabIndex = 0;
            videoView1.Text = "videoView1";
            videoView1.Click += videoView1_Click;
            // 
            // videoView2
            // 
            videoView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            videoView2.BackColor = Color.Black;
            videoView2.Location = new Point(8, 8);
            videoView2.MediaPlayer = null;
            videoView2.Name = "videoView2";
            videoView2.Size = new Size(502, 1018);
            videoView2.TabIndex = 1;
            videoView2.Text = "videoView2";
            videoView2.Click += videoView2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Location = new Point(11, 1163);
            button1.Name = "button1";
            button1.Size = new Size(116, 33);
            button1.TabIndex = 2;
            button1.Text = "START";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.Location = new Point(134, 1163);
            button2.Name = "button2";
            button2.Size = new Size(129, 33);
            button2.TabIndex = 3;
            button2.Text = "STOP";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buttonTakeSnapshot
            // 
            buttonTakeSnapshot.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonTakeSnapshot.Location = new Point(806, 1163);
            buttonTakeSnapshot.Name = "buttonTakeSnapshot";
            buttonTakeSnapshot.Size = new Size(159, 33);
            buttonTakeSnapshot.TabIndex = 4;
            buttonTakeSnapshot.Text = "TAKE SNAPSHOT";
            buttonTakeSnapshot.UseVisualStyleBackColor = true;
            buttonTakeSnapshot.Click += button3_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(0, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(button8);
            splitContainer1.Panel1.Controls.Add(videoView1);
            splitContainer1.Panel1.Controls.Add(buttonTakeSnapshot);
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Controls.Add(button6);
            splitContainer1.Panel1.Controls.Add(button5);
            splitContainer1.Panel1.Controls.Add(button4);
            splitContainer1.Panel1.Controls.Add(button2);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(button9);
            splitContainer1.Panel2.Controls.Add(button7);
            splitContainer1.Panel2.Controls.Add(CAMERA);
            splitContainer1.Panel2.Controls.Add(videoView2);
            splitContainer1.Size = new Size(1957, 1207);
            splitContainer1.SplitterDistance = 1441;
            splitContainer1.TabIndex = 5;
            // 
            // button8
            // 
            button8.Location = new Point(280, 1163);
            button8.Name = "button8";
            button8.Size = new Size(111, 33);
            button8.TabIndex = 7;
            button8.Text = "PAUSE";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button6.Location = new Point(679, 1163);
            button6.Name = "button6";
            button6.Size = new Size(67, 33);
            button6.TabIndex = 3;
            button6.Text = ">|";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button5.Location = new Point(597, 1163);
            button5.Name = "button5";
            button5.Size = new Size(67, 33);
            button5.TabIndex = 3;
            button5.Text = ">>";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button4.Location = new Point(524, 1163);
            button4.Name = "button4";
            button4.Size = new Size(67, 33);
            button4.TabIndex = 3;
            button4.Text = "<<";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button9
            // 
            button9.Location = new Point(221, 1165);
            button9.Name = "button9";
            button9.Size = new Size(111, 33);
            button9.TabIndex = 4;
            button9.Text = "PAUSE";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button7
            // 
            button7.Location = new Point(371, 1163);
            button7.Name = "button7";
            button7.Size = new Size(111, 33);
            button7.TabIndex = 3;
            button7.Text = "STOP";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click_1;
            // 
            // CAMERA
            // 
            CAMERA.Location = new Point(8, 1165);
            CAMERA.Name = "CAMERA";
            CAMERA.Size = new Size(111, 33);
            CAMERA.TabIndex = 2;
            CAMERA.Text = "CAMERA";
            CAMERA.UseVisualStyleBackColor = true;
            CAMERA.Click += button7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1969, 1217);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)videoView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)videoView2).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private LibVLCSharp.WinForms.VideoView videoView1;
        private LibVLCSharp.WinForms.VideoView videoView2;
        private Button button1;
        private Button button2;
        private Button buttonTakeSnapshot;
        private SplitContainer splitContainer1;
        private Button button5;
        private Button button4;
        private Button button6;
        private Button CAMERA;
        private Button button8;
        private Button button7;
        private Button button9;
    }
}