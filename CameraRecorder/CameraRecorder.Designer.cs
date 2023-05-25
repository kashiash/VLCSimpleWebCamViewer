namespace CameraRecorder
{
    partial class CameraRecorder
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
            vlcControl = new LibVLCSharp.WinForms.VideoView();
            ((System.ComponentModel.ISupportInitialize)vlcControl).BeginInit();
            SuspendLayout();
            // 
            // vlcControl
            // 
            vlcControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            vlcControl.BackColor = Color.Black;
            vlcControl.Location = new Point(4, 8);
            vlcControl.MediaPlayer = null;
            vlcControl.Name = "vlcControl";
            vlcControl.Size = new Size(788, 438);
            vlcControl.TabIndex = 0;
            vlcControl.Text = "vlcControl";
            // 
            // CameraRecorder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(vlcControl);
            KeyPreview = true;
            Name = "CameraRecorder";
            Text = "Form1";
            KeyDown += CameraRecorder_KeyDown;
            ((System.ComponentModel.ISupportInitialize)vlcControl).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private LibVLCSharp.WinForms.VideoView vlcControl;
    }
}