using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe8
{
    internal class Contact
    {
        string name;
        string email;
        string phone;

        public Contact()
        {

        }

        public string ContactName
        {
            get { return name; }
            set { name = value; }
        }

        public string ContactEmail
        {
            get { return email; }
            set { email = value; }
        }

        public string ContactPhone
        {
            get { return phone; }
            set { phone = value; }
        }
    }
}
