using System.ComponentModel;

namespace ScoreBoard.Forms
{
    partial class ScoreBoardForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._spectatorCamera = new ScoreBoard.Controls.SpectatorCameraControl();
            this._home = new ScoreBoard.Controls.TeamScoreControl();
            this._host = new ScoreBoard.Controls.TeamScoreControl();
            this._mtcTimer = new ScoreBoard.Controls.MatchTimerControl();
            this.label1 = new System.Windows.Forms.Label();
            
            this.SuspendLayout();
            // 
            // _home
            // 
            this._home.Location = new System.Drawing.Point(12, 1);
            this._home.Name = "_home";
            this._home.Size = new System.Drawing.Size(258, 344);
            this._home.TabIndex = 0;
            // 
            // _host
            // 
            this._host.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._host.Location = new System.Drawing.Point(843, 1);
            this._host.Name = "_host";
            this._host.Size = new System.Drawing.Size(279, 344);
            this._host.TabIndex = 1;
            // 
            // _mtcTimer
            // 
            this._mtcTimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this._mtcTimer.Location = new System.Drawing.Point(276, 12);
            this._mtcTimer.Name = "_mtcTimer";
            this._mtcTimer.Size = new System.Drawing.Size(561, 333);
            this._mtcTimer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1112, 67);
            this.label1.TabIndex = 4;
            this.label1.Text = "Penalizovaní hráči";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _spectatorCamera
            // 
            this._spectatorCamera.Location = new System.Drawing.Point(12, 811);
            this._spectatorCamera.Name = "spectatorCamera";
            this._spectatorCamera.Size = new System.Drawing.Size(1110, 338);
            this._spectatorCamera.TabIndex = 5;
            // 
            // ScoreBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 1161);
            this.Controls.Add(this._spectatorCamera);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._mtcTimer);
            this.Controls.Add(this._host);
            this.Controls.Add(this._home);
            this.Name = "ScoreBoardForm";
            this.Text = "ScoreBoardForm";
            this.ResumeLayout(false);
        }

        private ScoreBoard.Controls.SpectatorCameraControl _spectatorCamera;

        private System.Windows.Forms.Label label1;

        private ScoreBoard.Controls.MatchTimerControl _mtcTimer;

        private ScoreBoard.Controls.TeamScoreControl _home;
        private ScoreBoard.Controls.TeamScoreControl _host;

        #endregion
    }
}