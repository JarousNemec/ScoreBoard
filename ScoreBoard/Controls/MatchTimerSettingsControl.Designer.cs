using System.ComponentModel;

namespace ScoreBoard.Controls
{
    partial class MatchTimerSettingsControl
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
            this._lblLeftTime = new System.Windows.Forms.Label();
            this._btnStartStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._timer = new System.Windows.Forms.Timer(this.components);
            this._numPeriode = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this._numPeriode)).BeginInit();
            this.SuspendLayout();
            // 
            // _lblLeftTime
            // 
            this._lblLeftTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this._lblLeftTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this._lblLeftTime.Location = new System.Drawing.Point(0, 0);
            this._lblLeftTime.Name = "_lblLeftTime";
            this._lblLeftTime.Size = new System.Drawing.Size(502, 70);
            this._lblLeftTime.TabIndex = 0;
            this._lblLeftTime.Text = "00:00";
            this._lblLeftTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _btnStartStop
            // 
            this._btnStartStop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this._btnStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this._btnStartStop.Location = new System.Drawing.Point(116, 176);
            this._btnStartStop.Name = "_btnStartStop";
            this._btnStartStop.Size = new System.Drawing.Size(288, 39);
            this._btnStartStop.TabIndex = 3;
            this._btnStartStop.Text = "Start";
            this._btnStartStop.UseVisualStyleBackColor = true;
            this._btnStartStop.Click += new System.EventHandler(this._btnStartStop_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(4, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Čas jedné periody v minutách:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // _timer
            // 
            this._timer.Interval = 1000;
            this._timer.Tick += new System.EventHandler(this._timer_Tick);
            // 
            // _numPeriode
            // 
            this._numPeriode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._numPeriode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this._numPeriode.Location = new System.Drawing.Point(3, 132);
            this._numPeriode.Name = "_numPeriode";
            this._numPeriode.Size = new System.Drawing.Size(494, 38);
            this._numPeriode.TabIndex = 5;
            // 
            // MatchTimerSettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._numPeriode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._btnStartStop);
            this.Controls.Add(this._lblLeftTime);
            this.Name = "MatchTimerSettingsControl";
            this.Size = new System.Drawing.Size(504, 230);
            ((System.ComponentModel.ISupportInitialize)(this._numPeriode)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.NumericUpDown _numPeriode;

        private System.Windows.Forms.Timer _timer;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button _btnStartStop;

        private System.Windows.Forms.Label _lblLeftTime;

        #endregion
    }
}