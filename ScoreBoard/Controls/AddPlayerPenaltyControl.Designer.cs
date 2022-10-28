using System.ComponentModel;

namespace ScoreBoard.Controls
{
    partial class AddPlayerPenaltyControl
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
            this._btnAdd = new System.Windows.Forms.Button();
            this._numPlayerNumber = new System.Windows.Forms.NumericUpDown();
            this._numPlayerPenalty = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._numPlayerNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numPlayerPenalty)).BeginInit();
            this.SuspendLayout();
            // 
            // _btnAdd
            // 
            this._btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this._btnAdd.Location = new System.Drawing.Point(0, 25);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(139, 32);
            this._btnAdd.TabIndex = 0;
            this._btnAdd.Text = "Add";
            this._btnAdd.UseVisualStyleBackColor = true;
            this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
            // 
            // _numPlayerNumber
            // 
            this._numPlayerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this._numPlayerNumber.Location = new System.Drawing.Point(145, 28);
            this._numPlayerNumber.Name = "_numPlayerNumber";
            this._numPlayerNumber.Size = new System.Drawing.Size(155, 26);
            this._numPlayerNumber.TabIndex = 1;
            // 
            // _numPlayerPenalty
            // 
            this._numPlayerPenalty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this._numPlayerPenalty.Location = new System.Drawing.Point(306, 28);
            this._numPlayerPenalty.Name = "_numPlayerPenalty";
            this._numPlayerPenalty.Size = new System.Drawing.Size(161, 26);
            this._numPlayerPenalty.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(145, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "PlayerNumber:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(306, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "PenaltyTime:";
            // 
            // AddPlayerPenaltyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._numPlayerPenalty);
            this.Controls.Add(this._numPlayerNumber);
            this.Controls.Add(this._btnAdd);
            this.Name = "AddPlayerPenaltyControl";
            this.Size = new System.Drawing.Size(471, 57);
            ((System.ComponentModel.ISupportInitialize)(this._numPlayerNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numPlayerPenalty)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.NumericUpDown _numPlayerNumber;
        private System.Windows.Forms.NumericUpDown _numPlayerPenalty;

        private System.Windows.Forms.Button _btnAdd;

        #endregion
    }
}