using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe8
{
    internal class ContactList
    {
        public List<Contact> Contacts = new List<Contact>();

        string email;
        string name;
        string phone;

        public ContactList()
        {
            
        }

        public void GetContactListItem()
        {
            Contact c = new Contact();
            email = c.ContactEmail;
            name = c.ContactName;
            phone = c.ContactPhone;
            Contacts.Add(c);
        }
   
    }
}
