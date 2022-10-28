using System;
using System.Drawing;
using System.Windows.Forms;
using ScoreBoard.Controls;

namespace ScoreBoard.Forms
{
    public partial class ScoreBoardForm : Form
    {
        public ScoreBoardForm()
        {
            InitializeComponent();
        }

        public TeamScoreControl Host => _host;
        public TeamScoreControl Home => _home;
        public MatchTimerControl MatchTimerControl => _mtcTimer;

        public void FullScreen()
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }
        
        public void RemoveControl(PlayerPenaltyControl control)
        {
            Invoke(new Action((() =>
            {
                Controls.Remove(control);
                RenderUi();
            })));
        }
        
        public void AddControl(PlayerPenaltyControl control)
        {
            Invoke(new Action(() =>
            {
                Controls.Add(control);
                RenderUi();
            }));
        }
        
        private void RenderUi()
        {
            int x = 95;
            int y = 450;
            for (int i = 0; i < Controls.Count; i++)
            {
                if (Controls[i].GetType() == typeof(PlayerPenaltyControl))
                {
                    Controls[i].Location = new Point(x, y);
                    x += 10 + Controls[i].Width;
                    if (x + 10 + Controls[i].Width > Width)
                    {
                        y += 10 + Controls[i].Height;
                        x = 95;
                    }
                }
            }
        }
    }
    
}