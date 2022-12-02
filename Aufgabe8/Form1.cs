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
            }
        }

        private void deleteListBTN_Click(object sender, EventArgs e)
        {
            dgvContacts.ClearSelection();
        }

        private void NewContactBTN_Click(object sender, EventArgs e)
        {
            ContactList c = new ContactList();
            c.GetContactListItem();

        }
    }
}
