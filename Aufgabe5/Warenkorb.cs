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
    public partial class Warenkorb : Form
    {

        List<OrderItem> items; 


        public Warenkorb(List<OrderItem> orderedItems)
        {
            InitializeComponent();

            items = orderedItems;
        }

        private void Warenkorb_Load(object sender, EventArgs e)
        {
            foreach (OrderItem item in items)
            {
                textBox1.Paste(item.ProductName +"\t\t" + item.Amount+ "\r\n");
            }


        }
    }
}
