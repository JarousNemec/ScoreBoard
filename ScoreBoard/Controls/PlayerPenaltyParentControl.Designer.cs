using System.ComponentModel;
using System.Windows.Forms;

namespace ScoreBoard.Controls
{
    partial class PlayerPenaltyParentControl
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

        private System.Windows.Forms.Label _lblPlayerNumber;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._lblPlayerNumber = new System.Windows.Forms.Label();
            this._lblPenaltyTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._timerPenalty = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // _lblPlayerNumber
            // 
            this._lblPlayerNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this._lblPlayerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this._lblPlayerNumber.Location = new System.Drawing.Point(0, 0);
            this._lblPlayerNumber.Name = "_lblPlayerNumber";
            this._lblPlayerNumber.Size = new System.Drawing.Size(149, 46);
            this._lblPlayerNumber.TabIndex = 0;
            this._lblPlayerNumber.Text = "00";
            this._lblPlayerNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _lblPenaltyTime
            // 
            this._lblPenaltyTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right)));
            this._lblPenaltyTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this._lblPenaltyTime.Location = new System.Drawing.Point(214, 0);
            this._lblPenaltyTime.Name = "_lblPenaltyTime";
            this._lblPenaltyTime.Size = new System.Drawing.Size(292, 46);
            this._lblPenaltyTime.TabIndex = 1;
            this._lblPenaltyTime.Text = "00:00";
            this._lblPenaltyTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(155, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "|";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _timerPenalty
            // 
            this._timerPenalty.Interval = 1000;
            this._timerPenalty.Tick += new System.EventHandler(this._timerPenalty_Tick);
            // 
            // PlayerPenaltyParentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this._lblPenaltyTime);
            this.Controls.Add(this._lblPlayerNumber);
            this.Name = "PlayerPenaltyParentControl";
            this.Size = new System.Drawing.Size(506, 47);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Timer _timerPenalty;

        private System.Windows.Forms.Label _lblPenaltyTime;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        #endregion
    }
}