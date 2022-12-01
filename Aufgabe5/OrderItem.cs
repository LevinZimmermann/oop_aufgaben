using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe5
{
    public class OrderItem
    {
        int counter = 1;
        string itemname;

        public string ProductName 
        {
            get { return itemname;  } 
            set { if (value.Length > 20) 
                    { throw new Exception("Produktname zu lang"); }
                  else if (value.Length < 3)
                    {
                      throw new Exception("Produktname zu kurz");

                    }
                      else { itemname = value; } 
                    }
        }
        public int Amount 
        {
            get { return counter; }
            set
            {
                if (value > 10 || value < 1)
                { throw new Exception("Zu hohe oder zu kleine Anzahl Produkte"); }
                else { counter = value; }
            }
        }

        public void GetProductOrder()
        {

        }
    }
}
