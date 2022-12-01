using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1;
            double num2;
            double tryzahl = 0;

            if (textBox1.Text != "" && textBox2.Text != "") 
            {
                textBox4.Hide();

                if (double.TryParse(textBox1.Text, out tryzahl) == true && double.TryParse(textBox2.Text, out tryzahl) == true) 
                {
                    textBox4.Hide();

                    num1 = int.Parse(textBox1.Text);
                    num2 = int.Parse(textBox2.Text);

                    double result = num1* num2;

                    textBox3.Text = result.ToString();

                }
                else 
                {
                    label4.Show();
                    textBox4.Show();
                    textBox4.Text = "Es müssen Zahlen sein!";
                }
            }
            else
            {
                label4.Show();
                textBox4.Show();
                textBox4.Text = "Bitte gebe überall eine Zahl ein!";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "Wollen Sie wirklich beenden?";
            string caption = "Beenden";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(this, message, caption, buttons);

            if (result == DialogResult.Yes)
            {


                Application.Exit();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox4.Hide();
            label4.Hide();
        }
    }
}
