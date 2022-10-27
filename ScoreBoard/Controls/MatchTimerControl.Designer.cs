using System.ComponentModel;

namespace ScoreBoard.Controls
{
    partial class MatchTimerControl
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
            this._lblLeftTime = new System.Windows.Forms.Label();
            this._lblPeriodes = new System.Windows.Forms.Label();
            this._lblText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _lblLeftTime
            // 
            this._lblLeftTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this._lblLeftTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this._lblLeftTime.Location = new System.Drawing.Point(2, 26);
            this._lblLeftTime.Name = "_lblLeftTime";
            this._lblLeftTime.Size = new System.Drawing.Size(281, 102);
            this._lblLeftTime.TabIndex = 0;
            this._lblLeftTime.Text = "00:00";
            this._lblLeftTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _lblPeriodes
            // 
            this._lblPeriodes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this._lblPeriodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this._lblPeriodes.Location = new System.Drawing.Point(0, 162);
            this._lblPeriodes.Name = "_lblPeriodes";
            this._lblPeriodes.Size = new System.Drawing.Size(282, 117);
            this._lblPeriodes.TabIndex = 1;
            this._lblPeriodes.Text = "0";
            this._lblPeriodes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _lblText
            // 
            this._lblText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this._lblText.Location = new System.Drawing.Point(0, 134);
            this._lblText.Name = "_lblText";
            this._lblText.Size = new System.Drawing.Size(280, 37);
            this._lblText.TabIndex = 2;
            this._lblText.Text = "Perioda";
            this._lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MatchTimerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._lblText);
            this.Controls.Add(this._lblPeriodes);
            this.Controls.Add(this._lblLeftTime);
            this.Name = "MatchTimerControl";
            this.Size = new System.Drawing.Size(284, 344);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label _lblText;

        private System.Windows.Forms.Label _lblLeftTime;
        private System.Windows.Forms.Label _lblPeriodes;

        #endregion
    }
}