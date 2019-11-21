using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;               // You need this to play sounds
using OneArmedBandit.Properties;  // You need this to access Resources

namespace OneArmedBandit
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        // we put all images in array, just so we can reference them by index
        private Image[] wheelImages = { Resources.apple, Resources.banana, Resources.bar, Resources.grape, Resources.orange, Resources.pear, Resources.raspberry, Resources.strawberry };

        public Form1()
        {
            InitializeComponent();
        }

        private void spinButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < theWheels.Length; i++)
            {
                theWheels[i].spin(rand.Next(5, 50));
            }
            updatePictureBoxes();  // redraw the images
            playStart();
        }

        private void playStart() // procedure to play sound in resources
        {
            SoundPlayer audio = new SoundPlayer(Resources.startSound);
            audio.Play();
        }

        private void playSpin() // procedure to play sound in resources
        {
            SoundPlayer audio = new SoundPlayer(Resources.spinSound);
            audio.Play();
        }

        private void playWin() // procedure to play sound in resources
        {
            SoundPlayer audio = new SoundPlayer(Resources.winSound);
            audio.Play();
        }
    }
}