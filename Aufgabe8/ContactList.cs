using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Contexts;

namespace Aufgabe8
{
    internal class ContactList
    {
        public BindingList<Contact> Contacts { get; private set; }



        public ContactList()
        {
            Contacts = new BindingList<Contact>();
        }

        public void Clear()
        {
            Contacts.Clear();
        }

        public void ExportCsv(string path)
        {
            string[] CSVContacts = File.ReadAllLines(path);

            if (CSVContacts == null)
            {

                StreamWriter sw = File.CreateText(path + ".csv");


                string csvData = "";

                foreach (Contact c in Contacts)
                {
                    csvData += c.Name + ";" + c.Email + ";" + c.Phone + ";" + Environment.NewLine;
                }

                sw.WriteLine(csvData);
                sw.Close();
            }
            else
            {
                string[] CSVContactsold = File.ReadAllLines(path);
                foreach (string CSVContact in CSVContacts)
                {
                    string[] contactData = CSVContact.Split(';');

                    if (contactData.Length < 3)
                        continue;

                    string CSVName = Convert.ToString(contactData[0]);
                    string CSVEmail = Convert.ToString(contactData[1]);
                    string CSVPhone = Convert.ToString(contactData[2]);

                    Contacts.Add(new Contact { Email = CSVEmail, Name = CSVName, Phone = CSVPhone });
                }

                StreamWriter sw = new StreamWriter(path);

                foreach (Contact c in Contacts)
                {
                    sw.WriteLine(c.Name + ";" + c.Email + ";" + c.Phone + ";");
                }
                sw.Close();
            }
        }



        public void ImportCsv(string path)
        {
            Contacts.Clear();

            string[] CSVContacts = File.ReadAllLines(path);
            foreach (string CSVContact in CSVContacts)
            {
                string[] contactData = CSVContact.Split(';');

                if (contactData.Length < 3) 
                    continue;

                string CSVName = Convert.ToString(contactData[0]);
                string CSVEmail = Convert.ToString(contactData[1]);
                string CSVPhone = Convert.ToString(contactData[2]);

                Contacts.Add(new Contact { Email = CSVEmail, Name = CSVName, Phone = CSVPhone });
            }
        }
    }
}
