using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace demoapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnrannum_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            int num =ran.Next(1, 100);

            lblrannum.Text = "Random Num" + num;
            Console.WriteLine("Random number generated " + num);
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            int num = ran.Next(1,10);

            if (num % 2 == 0)
            {
                pbimage.Image = global::demoapp.Properties.Resources.download;
            }
            else
            {
                pbimage.Image = global::demoapp.Properties.Resources.download__1_;
            }
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(demoapp.Properties.Resources.harley_davidson_daniel_simon);
            player.Load();
            player.Play();
                 
        }
    }
}
