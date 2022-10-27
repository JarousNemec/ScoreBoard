namespace ScoreBoard
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openScoreboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._home = new ScoreBoard.Controls.ScoreSettingsControl();
            this._host = new ScoreBoard.Controls.ScoreSettingsControl();
            this._mtscTimer = new ScoreBoard.Controls.MatchTimerSettingsControl();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.fileToolStripMenuItem, this.toolsToolStripMenuItem, this.windowToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1414, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.openScoreboardToolStripMenuItem, this.fullScreenToolStripMenuItem });
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // openScoreboardToolStripMenuItem
            // 
            this.openScoreboardToolStripMenuItem.Name = "openScoreboardToolStripMenuItem";
            this.openScoreboardToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.openScoreboardToolStripMenuItem.Text = "Open Scoreboard";
            this.openScoreboardToolStripMenuItem.Click += new System.EventHandler(this.openScoreboardToolStripMenuItem_Click);
            // 
            // fullScreenToolStripMenuItem
            // 
            this.fullScreenToolStripMenuItem.Name = "fullScreenToolStripMenuItem";
            this.fullScreenToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.fullScreenToolStripMenuItem.Text = "FullScreen";
            this.fullScreenToolStripMenuItem.Click += new System.EventHandler(this.fullScreenToolStripMenuItem_Click);
            // 
            // _home
            // 
            this._home.Location = new System.Drawing.Point(12, 36);
            this._home.Name = "_home";
            this._home.Size = new System.Drawing.Size(308, 199);
            this._home.TabIndex = 1;
            // 
            // _host
            // 
            this._host.Location = new System.Drawing.Point(1095, 36);
            this._host.Name = "_host";
            this._host.Size = new System.Drawing.Size(307, 199);
            this._host.TabIndex = 2;
            // 
            // _mtscTimer
            // 
            this._mtscTimer.Location = new System.Drawing.Point(433, 36);
            this._mtscTimer.Name = "_mtscTimer";
            this._mtscTimer.Size = new System.Drawing.Size(579, 222);
            this._mtscTimer.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 907);
            this.Controls.Add(this._mtscTimer);
            this.Controls.Add(this._host);
            this.Controls.Add(this._home);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private ScoreBoard.Controls.MatchTimerSettingsControl _mtscTimer;

        private System.Windows.Forms.ToolStripMenuItem fullScreenToolStripMenuItem;

        private ScoreBoard.Controls.ScoreSettingsControl _home;
        private ScoreBoard.Controls.ScoreSettingsControl _host;

        private System.Windows.Forms.ToolStripMenuItem openScoreboardToolStripMenuItem;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;

        #endregion
    }
}