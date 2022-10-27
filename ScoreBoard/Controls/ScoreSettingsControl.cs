using System;
using System.Windows.Forms;

namespace ScoreBoard.Controls
{
    public partial class ScoreSettingsControl : UserControl
    {
        public ScoreSettingsControl()
        {
            InitializeComponent();
        }

        private TeamScoreControl _control;
        
        public void SetControl(TeamScoreControl control)
        {
            _control = control;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            _control.SetScore((int)_numScore.Value);
        }

        private void _btnShow_Click(object sender, EventArgs e)
        {
            _control.SetTeamName(_txtName.Text);
        }
    }
}