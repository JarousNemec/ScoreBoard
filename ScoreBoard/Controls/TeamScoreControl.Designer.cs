using System.ComponentModel;

namespace ScoreBoard.Controls
{
    partial class TeamScoreControl
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
            this._lblScore = new System.Windows.Forms.Label();
            this._lblTeamName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _lblScore
            // 
            this._lblScore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this._lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this._lblScore.Location = new System.Drawing.Point(0, 129);
            this._lblScore.Name = "_lblScore";
            this._lblScore.Size = new System.Drawing.Size(261, 220);
            this._lblScore.TabIndex = 0;
            this._lblScore.Text = "0";
            this._lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _lblTeamName
            // 
            this._lblTeamName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this._lblTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this._lblTeamName.Location = new System.Drawing.Point(0, 0);
            this._lblTeamName.Name = "_lblTeamName";
            this._lblTeamName.Size = new System.Drawing.Size(261, 69);
            this._lblTeamName.TabIndex = 1;
            this._lblTeamName.Text = "TeamName";
            this._lblTeamName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TeamScoreControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._lblTeamName);
            this.Controls.Add(this._lblScore);
            this.Name = "TeamScoreControl";
            this.Size = new System.Drawing.Size(264, 349);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label _lblTeamName;

        private System.Windows.Forms.Label _lblScore;

        #endregion
    }
}