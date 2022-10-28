using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScoreBoard.Controls;
using ScoreBoard.Forms;

namespace ScoreBoard
{
    public partial class ScoreBoardManagerForm : Form
    {
        public ScoreBoardManagerForm()
        {
            InitializeComponent();
        }

        private ScoreBoardForm _form;
        
        private void openScoreboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_form != null)
            {
                MessageBox.Show("Form is open.");
                return;
            }
                
            _form = new ScoreBoardForm();
            _home.SetControl(_form.Home);
            _host.SetControl(_form.Host);
            _mtscTimer.SetMatchTimerControl(_form.MatchTimerControl);
            _form.Show();
        }

        private void fullScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(_form != null)
                _form.FullScreen();
        } 

        public void addPlayerPenaltyControl_AddPenalty(int playerNumber, TimeSpan penaltyTime)
        {
            var child = new PlayerPenaltyControl();
            _form.AddControl(child);
            var parent = new PlayerPenaltyParentControl(playerNumber, penaltyTime, child);
            parent.PenaltyEnd += ParentOnPenaltyEnd;
            AddControl(parent);
        }

        public void ParentOnPenaltyEnd( PlayerPenaltyParentControl control)
        {
            _form.RemoveControl(control.Child);
            RemoveControl(control);
        }

        private void RemoveControl(PlayerPenaltyParentControl control)
        {
            Invoke(new Action((() =>
            {
                Controls.Remove(control);
                RenderUi();
            })));
        }
        
        private void AddControl(PlayerPenaltyParentControl control)
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
            int y = 350;
            for (int i = 0; i < Controls.Count; i++)
            {
                if (Controls[i].GetType() == typeof(PlayerPenaltyParentControl))
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