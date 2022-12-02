using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Aufgabe7.Form1;

namespace Aufgabe7
{
    public partial class Form1 : Form
    {
        //Allgemeine Variablen
        bool autoan = false;
        bool autoon = true;
        bool audioplayer = true;
        int endspeed = 0;
        int currentGear = 0;
        Auto auto;



        //Wird gebremst oder gasgegeben (Mode)
        public enum Mode
        {
            Accelerate,
            Break
        }

        public Form1()
        {
            InitializeComponent();
            autoswitch.Items.Add(new Auto("Porsche", 250));
            autoswitch.Items.Add(new Auto("Opel", 90));
            autoswitch.Items.Add(new Auto("Ferrari", 370));
            pictureBox1.ImageLocation = @"C:\Users\ÜK-G6\OneDrive - sluz\Dokumente\VS BLJ Semester 1\OOP\oop_aufgaben\Aufgabe7\tresorfalse.png";
            pictureBox3.ImageLocation = @"C:\Users\ÜK-G6\OneDrive - sluz\Dokumente\VS BLJ Semester 1\OOP\oop_aufgaben\Aufgabe7\soundoff.png";
            trackBar1.Hide();
        }

        //Gas geben (Pedale) return currentSpeed -> Aufruf GetSpeed();
        private void button2_Click(object sender, EventArgs e)
        {
                auto.CurrentSpeed = endspeed;
                auto.CurrentGear = currentGear;
                endspeed = auto.GetBreak();
                currentGear = auto.GetGear();
                textBox3.Text = endspeed.ToString();
                textBox2.Text = currentGear.ToString();

            
        }

        //Gas geben (Pedale) return currentSpeed -> Aufruf GetSpeed();
        private void button1_Click(object sender, EventArgs e)
        {
            if (autoan == true)
            {
                endspeed = auto.GetSpeed(Mode.Accelerate);
                currentGear = auto.GetGear();
            }
            textBox3.Text = endspeed.ToString();
            textBox2.Text = currentGear.ToString();
        }

        //Auto start / ende
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (autoon == true) 
            {
                SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\ÜK-G6\OneDrive - sluz\Dokumente\VS BLJ Semester 1\OOP\oop_aufgaben\Aufgabe7\autostart.wav");
                simpleSound.Play();
                System.Threading.Thread.Sleep(8000);
                pictureBox1.ImageLocation = @"C:\Users\ÜK-G6\OneDrive - sluz\Dokumente\VS BLJ Semester 1\OOP\oop_aufgaben\Aufgabe7\tresortrue2.png";
                autoan = true;
                autoon = false;
            }
            else
            {
                SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\ÜK-G6\OneDrive - sluz\Dokumente\VS BLJ Semester 1\OOP\oop_aufgaben\Aufgabe7\autostart.wav");
                simpleSound.Play();
                System.Threading.Thread.Sleep(8000);
                pictureBox1.ImageLocation = @"C:\Users\ÜK-G6\OneDrive - sluz\Dokumente\VS BLJ Semester 1\OOP\oop_aufgaben\Aufgabe7\tresorfalse.png";
                autoan = false;
                autoon = true;
            }
        }

        //Hupen
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (autoan == true) 
            {
                SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\ÜK-G6\OneDrive - sluz\Dokumente\VS BLJ Semester 1\OOP\oop_aufgaben\Aufgabe7\hupen.wav");
                simpleSound.Play();
            }
        }

        //Radio
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Music auswahl aus 2 Tracks
            SoundPlayer simpleSound1 = new SoundPlayer(@"C:\Users\ÜK-G6\OneDrive - sluz\Dokumente\VS BLJ Semester 1\OOP\oop_aufgaben\Aufgabe7\music1.wav");
            SoundPlayer simpleSound2 = new SoundPlayer(@"C:\Users\ÜK-G6\OneDrive - sluz\Dokumente\VS BLJ Semester 1\OOP\oop_aufgaben\Aufgabe7\music2.wav");

            //Volumen von Musiklautstärke
            uint volume = (uint)trackBar1.Value;


            //Radio Switch
            if (audioplayer == true && autoan == true) 
            {
                Random rnd = new Random();
                int randomnum = rnd.Next(1,20);

                if (randomnum < 10) {
                    pictureBox3.ImageLocation = @"C:\Users\ÜK-G6\OneDrive - sluz\Dokumente\VS BLJ Semester 1\OOP\oop_aufgaben\Aufgabe7\soundon.png";

                    simpleSound1.Play();
                    trackBar1.Show();
                }
                else
                {
                    pictureBox3.ImageLocation = @"C:\Users\ÜK-G6\OneDrive - sluz\Dokumente\VS BLJ Semester 1\OOP\oop_aufgaben\Aufgabe7\soundon.png";
                    simpleSound2.Play();
                    trackBar1.Show();
                }
                audioplayer = false;
            }
            else
            {
                pictureBox3.ImageLocation = @"C:\Users\ÜK-G6\OneDrive - sluz\Dokumente\VS BLJ Semester 1\OOP\oop_aufgaben\Aufgabe7\soundoff.png";
                simpleSound1.Stop();
                simpleSound2.Stop();
                trackBar1.Hide();
                trackBar1.Hide();
                audioplayer = true;
            }
        }

        //PS zuweisung und label anzeige
        private void autoswitch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            auto = autoswitch.SelectedItem as Auto;
            label2.Text = Convert.ToString(auto.P_S);
            if (autoan == true)
            {
                endspeed = auto.CurrentSpeed;
                currentGear = auto.CurrentGear;
            }
            textBox3.Text = endspeed.ToString();
            textBox2.Text = currentGear.ToString();
        }
    }
}
