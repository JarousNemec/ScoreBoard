using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScoreBoard.Forms;

namespace ScoreBoard
{
    public partial class Form1 : Form
    {
        public Form1()
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
    }
}