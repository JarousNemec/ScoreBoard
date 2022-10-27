using System.ComponentModel;

namespace ScoreBoard.Controls
{
    partial class ScoreSettingsControl
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
            this._txtName = new System.Windows.Forms.TextBox();
            this._numScore = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._btnShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._numScore)).BeginInit();
            this.SuspendLayout();
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(0, 40);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(305, 20);
            this._txtName.TabIndex = 0;
            // 
            // _numScore
            // 
            this._numScore.Location = new System.Drawing.Point(0, 169);
            this._numScore.Name = "_numScore";
            this._numScore.Size = new System.Drawing.Size(305, 20);
            this._numScore.TabIndex = 1;
            this._numScore.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Team name";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(0, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Score";
            // 
            // _btnShow
            // 
            this._btnShow.Location = new System.Drawing.Point(0, 66);
            this._btnShow.Name = "_btnShow";
            this._btnShow.Size = new System.Drawing.Size(305, 38);
            this._btnShow.TabIndex = 4;
            this._btnShow.Text = "Show";
            this._btnShow.UseVisualStyleBackColor = true;
            this._btnShow.Click += new System.EventHandler(this._btnShow_Click);
            // 
            // ScoreSettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._btnShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._numScore);
            this.Controls.Add(this._txtName);
            this.Name = "ScoreSettingsControl";
            this.Size = new System.Drawing.Size(305, 189);
            ((System.ComponentModel.ISupportInitialize)(this._numScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button _btnShow;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.NumericUpDown _numScore;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox _txtName;

        #endregion
    }
}