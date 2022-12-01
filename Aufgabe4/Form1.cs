using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked || radioButton2.Checked) 
            {
                int radiobtntrigger = 0;

                if (radioButton1.Checked)
                {
                    radiobtntrigger = 0;
                }
                else if (radioButton2.Checked)
                {
                    radiobtntrigger = 1;
                }

                distanceCalc d = new distanceCalc();

                d.KM_H = double.Parse(textBox1.Text);
                d.Radiobtn = radiobtntrigger;
                d.GetTravelTime();
                double time = d.Traveltime;
                textBox2.Text = Convert.ToString(time);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
