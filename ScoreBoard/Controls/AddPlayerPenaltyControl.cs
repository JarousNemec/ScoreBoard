using System;
using System.Windows.Forms;

namespace ScoreBoard.Controls
{
    public partial class AddPlayerPenaltyControl : UserControl
    {
        public AddPlayerPenaltyControl()
        {
            InitializeComponent();
        }
        
        public delegate void AddPenaltyNotify(int playerNumber, TimeSpan penaltyTime);

        public event AddPenaltyNotify AddPenalty;

        private void _btnAdd_Click(object sender, EventArgs e)
        {
            if (_numPlayerNumber.Value>0 && _numPlayerPenalty.Value>1)
            {
                AddPenalty?.Invoke((int)_numPlayerNumber.Value, new TimeSpan(0,(int)_numPlayerPenalty.Value,0));
            }
            
        }
    }
}