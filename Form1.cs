using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LifeGraphics
{
    public partial class LifeMainForm : Form
    {
        private Game _game;
        private GDIRenderer _renderer; 

        public LifeMainForm()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            int size = (int)numericUpDownSize.Value;

            _game = new Game(size);

            float offset = (float)pictureBoxGameScreen.Width / (float)size;

            _renderer = new GDIRenderer(pictureBoxGameScreen, offset);

            timerGame.Start();
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            _renderer.Draw(_game.getField());
            _game.Update();
            pictureBoxGameScreen.Refresh();
        }
        private void buttonStop_Click(object sender, EventArgs e)
        {
            timerGame.Stop();
        }

        private void buttonBegin_Click(object sender, EventArgs e)
        {
            timerGame.Start();
        }
    }
}
