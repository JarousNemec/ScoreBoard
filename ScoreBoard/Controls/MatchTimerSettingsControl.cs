using System;
using System.Windows.Forms;

namespace ScoreBoard.Controls
{
    public partial class MatchTimerSettingsControl : UserControl
    {
        private MatchTimerControl _matchTimerControl;

        public MatchTimerSettingsControl()
        {
            InitializeComponent();
        }

        public void SetMatchTimerControl(MatchTimerControl matchTimerControl)
        {
            _matchTimerControl = matchTimerControl;
        }

        private TimeSpan _leftTime;
        private int _periodes = 0;
        private bool pause = false;

        private void _btnStartStop_Click(object sender, EventArgs e)
        {
            if (!_timer.Enabled)
            {
                if (!pause)
                {
                    if (_numPeriode.Value > 1)
                    {
                        _leftTime = new TimeSpan(0, (int)_numPeriode.Value, 0);
                        _timer.Start();
                        _btnStartStop.Text = "Pause";
                        pause = false;
                    }
                    else
                    {
                        MessageBox.Show("Nesprávná délka periody!");
                    }
                }
                else
                {
                    _timer.Start();
                    _btnStartStop.Text = "Pause";
                    pause = false;
                }
            }
            else
            {
                _timer.Stop();
                _btnStartStop.Text = "Continue";
                pause = true;
            }
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            if (_leftTime.Ticks < TimeSpan.TicksPerSecond)
            {
                _timer.Stop();
                _btnStartStop.Text = "Start";
                _periodes++;
                _lblLeftTime.Text = $@"{_leftTime.Minutes}:{_leftTime.Seconds}";
                _matchTimerControl.SetPeriode(_periodes);
                _matchTimerControl.SetLeftTime(_leftTime);
                return;
            }
            _matchTimerControl.SetLeftTime(_leftTime);
            _lblLeftTime.Text = $@"{_leftTime.Minutes}:{_leftTime.Seconds}";
            _leftTime -= new TimeSpan(0, 0, 1);
        }
    }
}