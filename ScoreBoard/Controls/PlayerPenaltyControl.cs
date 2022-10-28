using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ScoreBoard.Controls
{
    public partial class PlayerPenaltyControl : UserControl
    {
        public PlayerPenaltyControl()
        {
            InitializeComponent();
        }

        public void SetPlayerNumber(int playerNumber)
        {
            _lblPlayerNumber.Text = playerNumber.ToString();
        }
        public void SetLeftPenaltyTime(TimeSpan penaltyTime)
        {
            _lblPenaltyTime.Text = $@"{penaltyTime.Minutes}:{penaltyTime.Seconds}";
        }
    }
}