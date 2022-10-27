using System.Windows.Forms;

namespace ScoreBoard.Controls
{
    public partial class TeamScoreControl : UserControl
    {
        private string _teamName;
        private int _score;
        
        public TeamScoreControl()
        {
            InitializeComponent();
        }

        public void SetTeamName(string name)
        {
            _teamName = name;
            UpradeUi();
        }

        public void SetScore(int score)
        {
            _score = score;
            UpradeUi();
        }

        private void UpradeUi()
        {
            _lblScore.Text = _score.ToString();
            _lblTeamName.Text = _teamName;
        }
        
    }
}