using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tanne t = new Tanne();
            t.Stammwidth = Convert.ToInt32(textBox1.Text);
            t.Stammheight = Convert.ToInt32(textBox2.Text);
            t.Kroeneheight = Convert.ToInt32(textBox3.Text);
            t.Draw();

            textBox4.Text = t.Drawing;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
        }
    }
}
