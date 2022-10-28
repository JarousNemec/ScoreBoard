using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ScoreBoard.Controls
{
    public partial class PlayerPenaltyParentControl : UserControl
    {
        public PlayerPenaltyControl Child { get; set; }

        public delegate void PenaltyEndNotify(PlayerPenaltyParentControl control);

        public event PenaltyEndNotify PenaltyEnd;

        private TimeSpan _penaltyTime;

        public PlayerPenaltyParentControl(int playerNumber, TimeSpan penaltyTime, PlayerPenaltyControl child)
        {
            InitializeComponent();
            Child = child;
            Child.SetPlayerNumber(playerNumber);
            _lblPlayerNumber.Text = playerNumber.ToString();
            _penaltyTime = penaltyTime;
            Child.SetLeftPenaltyTime(_penaltyTime);
            _lblPenaltyTime.Text = $@"{_penaltyTime.Minutes}:{_penaltyTime.Seconds}";
            _timerPenalty.Start();
        }

        private void _timerPenalty_Tick(object sender, EventArgs e)
        {
            if (_penaltyTime.Ticks > 0)
            {
                Child.SetLeftPenaltyTime(_penaltyTime);
                _lblPenaltyTime.Text = $@"{_penaltyTime.Minutes}:{_penaltyTime.Seconds}";
                _penaltyTime -= new TimeSpan(0, 0, 1);
            }
            else
            {
                _timerPenalty.Stop();
                PenaltyEnd?.Invoke(this);
            }
        }
    }
}