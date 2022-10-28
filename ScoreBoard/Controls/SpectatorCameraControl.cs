using System;
using System.IO;
using System.Windows.Forms;

namespace ScoreBoard.Controls
{
    public partial class SpectatorCameraControl : UserControl
    {
        private string[] _paths;
        private Random _random;
        private int currentGifIndex = 0;

        public SpectatorCameraControl()
        {
            InitializeComponent();
        }

        public void StartCamera()
        {
            _paths = Directory.GetFiles("./gifs/");
            _random = new Random();
            currentGifIndex = _random.Next(0, _paths.Length);
            _picSpectatorCamera.ImageLocation = _paths[currentGifIndex];
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int gifIndex;
            do
            {
                gifIndex = _random.Next(0, _paths.Length);
            } while (gifIndex == currentGifIndex);

            currentGifIndex = gifIndex;

            _picSpectatorCamera.ImageLocation = _paths[currentGifIndex];
        }
    }
}