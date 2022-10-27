using System;
using System.Windows.Forms;

namespace ScoreBoard.Controls
{
    public partial class MatchTimerControl : UserControl
    {
        private TimeSpan _lefttime;
        private int _periode;

        public MatchTimerControl()
        {
            _lefttime = new TimeSpan();
            _periode = 0;
            InitializeComponent();
        }

        public void SetLeftTime(TimeSpan lefttime)
        {
            _lefttime = lefttime;
            UpdateUi();
        }
        public void SetPeriode(int periode)
        {
            _periode = periode;
            UpdateUi();
        }

        private void UpdateUi()
        {
            _lblPeriodes.Text = _periode.ToString();
            _lblLeftTime.Text = $@"{_lefttime.Minutes}:{_lefttime.Seconds}";
        }
    }
}