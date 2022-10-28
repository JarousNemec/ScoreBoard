using System.ComponentModel;

namespace ScoreBoard.Controls
{
    partial class SpectatorCameraControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._picSpectatorCamera = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._picSpectatorCamera)).BeginInit();
            this.SuspendLayout();
            // 
            // _picSpectatorCamera
            // 
            this._picSpectatorCamera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this._picSpectatorCamera.Location = new System.Drawing.Point(18, 3);
            this._picSpectatorCamera.Name = "_picSpectatorCamera";
            this._picSpectatorCamera.Size = new System.Drawing.Size(685, 372);
            this._picSpectatorCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._picSpectatorCamera.TabIndex = 6;
            this._picSpectatorCamera.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 8000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SpectatorCameraControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this._picSpectatorCamera);
            this.Name = "SpectatorCameraControl";
            this.Size = new System.Drawing.Size(721, 392);
            ((System.ComponentModel.ISupportInitialize)(this._picSpectatorCamera)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Timer timer1;

        private System.Windows.Forms.PictureBox _picSpectatorCamera;

        #endregion
    }
}