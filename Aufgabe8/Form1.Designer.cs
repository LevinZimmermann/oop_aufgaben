namespace Aufgabe8
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.deleteListBTN = new System.Windows.Forms.Button();
            this.ImportCSVBTN = new System.Windows.Forms.Button();
            this.ExportCSVBTN = new System.Windows.Forms.Button();
            this.dgvContacts = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NewContactBTN = new System.Windows.Forms.Button();
            this.NewContactPhone = new System.Windows.Forms.TextBox();
            this.NewContactEmail = new System.Windows.Forms.TextBox();
            this.NewContactName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteListBTN
            // 
            this.deleteListBTN.Location = new System.Drawing.Point(12, 29);
            this.deleteListBTN.Name = "deleteListBTN";
            this.deleteListBTN.Size = new System.Drawing.Size(87, 23);
            this.deleteListBTN.TabIndex = 0;
            this.deleteListBTN.Text = "Liste Löschen";
            this.deleteListBTN.UseVisualStyleBackColor = true;
            this.deleteListBTN.Click += new System.EventHandler(this.deleteListBTN_Click);
            // 
            // ImportCSVBTN
            // 
            this.ImportCSVBTN.Location = new System.Drawing.Point(418, 29);
            this.ImportCSVBTN.Name = "ImportCSVBTN";
            this.ImportCSVBTN.Size = new System.Drawing.Size(75, 23);
            this.ImportCSVBTN.TabIndex = 1;
            this.ImportCSVBTN.Text = "Import csv";
            this.ImportCSVBTN.UseVisualStyleBackColor = true;
            this.ImportCSVBTN.Click += new System.EventHandler(this.ImportCSVBTN_Click);
            // 
            // ExportCSVBTN
            // 
            this.ExportCSVBTN.Location = new System.Drawing.Point(499, 29);
            this.ExportCSVBTN.Name = "ExportCSVBTN";
            this.ExportCSVBTN.Size = new System.Drawing.Size(75, 23);
            this.ExportCSVBTN.TabIndex = 2;
            this.ExportCSVBTN.Text = "Export csv";
            this.ExportCSVBTN.UseVisualStyleBackColor = true;
            this.ExportCSVBTN.Click += new System.EventHandler(this.ExportCSVBTN_Click);
            // 
            // dgvContacts
            // 
            this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacts.Location = new System.Drawing.Point(12, 58);
            this.dgvContacts.Name = "dgvContacts";
            this.dgvContacts.Size = new System.Drawing.Size(562, 419);
            this.dgvContacts.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NewContactBTN);
            this.groupBox1.Controls.Add(this.NewContactPhone);
            this.groupBox1.Controls.Add(this.NewContactEmail);
            this.groupBox1.Controls.Add(this.NewContactName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 483);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 198);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Neuer Kontakt";
            // 
            // NewContactBTN
            // 
            this.NewContactBTN.Location = new System.Drawing.Point(394, 156);
            this.NewContactBTN.Name = "NewContactBTN";
            this.NewContactBTN.Size = new System.Drawing.Size(98, 23);
            this.NewContactBTN.TabIndex = 5;
            this.NewContactBTN.Text = "Hinzufügen";
            this.NewContactBTN.UseVisualStyleBackColor = true;
            this.NewContactBTN.Click += new System.EventHandler(this.NewContactBTN_Click);
            // 
            // NewContactPhone
            // 
            this.NewContactPhone.Location = new System.Drawing.Point(129, 118);
            this.NewContactPhone.Name = "NewContactPhone";
            this.NewContactPhone.Size = new System.Drawing.Size(363, 20);
            this.NewContactPhone.TabIndex = 5;
            // 
            // NewContactEmail
            // 
            this.NewContactEmail.Location = new System.Drawing.Point(129, 82);
            this.NewContactEmail.Name = "NewContactEmail";
            this.NewContactEmail.Size = new System.Drawing.Size(363, 20);
            this.NewContactEmail.TabIndex = 4;
            // 
            // NewContactName
            // 
            this.NewContactName.Location = new System.Drawing.Point(129, 47);
            this.NewContactName.Name = "NewContactName";
            this.NewContactName.Size = new System.Drawing.Size(363, 20);
            this.NewContactName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phonenumber:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "E-Mail:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 710);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvContacts);
            this.Controls.Add(this.ExportCSVBTN);
            this.Controls.Add(this.ImportCSVBTN);
            this.Controls.Add(this.deleteListBTN);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button deleteListBTN;
        private System.Windows.Forms.Button ImportCSVBTN;
        private System.Windows.Forms.Button ExportCSVBTN;
        private System.Windows.Forms.DataGridView dgvContacts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button NewContactBTN;
        private System.Windows.Forms.TextBox NewContactPhone;
        private System.Windows.Forms.TextBox NewContactEmail;
        private System.Windows.Forms.TextBox NewContactName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

