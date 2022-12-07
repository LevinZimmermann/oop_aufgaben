using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe8
{
    public partial class Form1 : Form
    { 
        ContactList contactList = new ContactList();
        

        public Form1()
        {
            InitializeComponent();
            dgvContacts.DataSource = contactList.Contacts;
        }

        private void ImportCSVBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Kontakte importieren";
            // nur csv-Dateien anzeigen lassen
            openFileDialog.Filter = "csv files (*.csv)|*.csv";
            // "Datei öffnen"-Dialog anzeigen
            if (DialogResult.OK == openFileDialog.ShowDialog())
            {
                // Speicherort des Files einer String-Variable zuweisen
                string path = openFileDialog.FileName;
                contactList.ImportCsv(path);
            }
        }

        private void ExportCSVBTN_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Kontakte exportieren";
            // "Speichern unter"-Dialog anzeigen
            if (DialogResult.OK == saveFileDialog.ShowDialog())
            {
                // Speicherort des Files einer String-Variable zuweisen
                string path = saveFileDialog.FileName;
                contactList.ExportCsv(path);
            }
        }

        private void deleteListBTN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Wirklich alle Kontakte Löschen?",
            "Caption", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                contactList.Clear();
        }

        private void NewContactBTN_Click(object sender, EventArgs e)
        {
            if (NewContactName.Text != "" && NewContactEmail.Text != "" && NewContactPhone.Text != "") 
            {
                Contact contact = new Contact();
                contact.Email = NewContactEmail.Text;
                contact.Phone = NewContactPhone.Text;
                contact.Name = NewContactName.Text;
                contactList.Contacts.Add(contact);

                NewContactEmail.Clear();
                NewContactName.Clear();
                NewContactPhone.Clear();

                NewContactName.Focus();
            }
            else
            {
                MessageBox.Show("Bitte alle felder ausfüllen");
            }
        }
    }
}
