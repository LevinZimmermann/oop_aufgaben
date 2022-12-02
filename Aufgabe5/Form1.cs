using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe5
{
    public partial class Form1 : Form
    {
        List<OrderItem> orderedItems = new List<OrderItem>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && numericUpDown1.Value != 0) 
            {
                OrderItem item = new OrderItem();
                item.ProductName = textBox1.Text;
                item.Amount = (int)numericUpDown1.Value;
                
                orderedItems.Add(item);

                
            }
            textBox1.Clear();
            numericUpDown1.Value = 1;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var oldform = new Form1();
            var newform = new Warenkorb(orderedItems);
            newform.ShowDialog();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
