using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace PlayGame
{
    public partial class connorSimWindow : Form
    {
        public connorSimWindow()
        {
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.Beep);
            int count = 3;
            while (count >= 1)
            {

                playButton.ForeColor = Color.Black;
                playButton.FlatAppearance.MouseOverBackColor = Color.Black;
                playButton.FlatAppearance.MouseDownBackColor = Color.Black;
                playButton.FlatAppearance.BorderColor = Color.Black;
                playButton.BackColor = Color.Black;
                counterLabel.ForeColor = Color.White;
                counterLabel.Text = ("Game will begin in: " + count);
                count--;
                player.Play();
                Refresh();
                Thread.Sleep(1000);
            }
            playButton.ForeColor = Color.Green;
            playButton.FlatAppearance.MouseOverBackColor = Color.Green;
            playButton.FlatAppearance.MouseDownBackColor = Color.Green;
            playButton.FlatAppearance.BorderColor = Color.Green;
            playButton.BackColor = Color.Green;
            counterLabel.Text = "GO!!!!!!!!!";
                counterLabel.BackColor = Color.Green;
                this.BackColor = Color.Green;
        }
    }
}
