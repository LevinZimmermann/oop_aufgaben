using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe7
{
    public partial class Form1 : Form
    {
        bool autoan = false;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.ImageLocation = @"C:\Users\ÜK-G6\OneDrive - sluz\Dokumente\VS BLJ Semester 1\OOP\Aufgabe1\Aufgabe7\tresorfalse.png";
            pictureBox3.ImageLocation = @"C:\Users\ÜK-G6\OneDrive - sluz\Dokumente\VS BLJ Semester 1\OOP\Aufgabe1\Aufgabe7\soundoff.png";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\ÜK-G6\OneDrive - sluz\Dokumente\VS BLJ Semester 1\OOP\Aufgabe1\Aufgabe7\autostart.wav");
            simpleSound.Play();
            System.Threading.Thread.Sleep(8000);
            pictureBox1.ImageLocation = @"C:\Users\ÜK-G6\OneDrive - sluz\Dokumente\VS BLJ Semester 1\OOP\Aufgabe1\Aufgabe7\tresortrue2.png";
            autoan = true;

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (autoan == true) 
            {
                SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\ÜK-G6\OneDrive - sluz\Dokumente\VS BLJ Semester 1\OOP\Aufgabe1\Aufgabe7\hupen.wav");
                simpleSound.Play();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\ÜK-G6\OneDrive - sluz\Dokumente\VS BLJ Semester 1\OOP\Aufgabe1\Aufgabe7\music2.wav");
            bool audioplayer = true;
            if (audioplayer == true) 
            {
                pictureBox3.ImageLocation = @"C:\Users\ÜK-G6\OneDrive - sluz\Dokumente\VS BLJ Semester 1\OOP\Aufgabe1\Aufgabe7\soundon.png";
                simpleSound.Play();
                audioplayer = false;
            }
            else
            {
                pictureBox3.ImageLocation = @"C:\Users\ÜK-G6\OneDrive - sluz\Dokumente\VS BLJ Semester 1\OOP\Aufgabe1\Aufgabe7\soundoff.png";
                simpleSound.Stop();
            }
        }
    }
}
