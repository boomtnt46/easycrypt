namespace Encrypted_messager
{
    partial class ContactsManagerWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.contactList = new System.Windows.Forms.ComboBox();
            this.contactListLabel = new System.Windows.Forms.Label();
            this.addContact = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contactList
            // 
            this.contactList.FormattingEnabled = true;
            this.contactList.Location = new System.Drawing.Point(12, 39);
            this.contactList.Name = "contactList";
            this.contactList.Size = new System.Drawing.Size(297, 31);
            this.contactList.TabIndex = 0;
            // 
            // contactListLabel
            // 
            this.contactListLabel.AutoSize = true;
            this.contactListLabel.ForeColor = System.Drawing.Color.Transparent;
            this.contactListLabel.Location = new System.Drawing.Point(12, 13);
            this.contactListLabel.Name = "contactListLabel";
            this.contactListLabel.Size = new System.Drawing.Size(88, 23);
            this.contactListLabel.TabIndex = 1;
            this.contactListLabel.Text = "Contacts";
            // 
            // addContact
            // 
            this.addContact.Location = new System.Drawing.Point(327, 39);
            this.addContact.Name = "addContact";
            this.addContact.Size = new System.Drawing.Size(109, 31);
            this.addContact.TabIndex = 2;
            this.addContact.Text = "Add new";
            this.addContact.UseVisualStyleBackColor = true;
            this.addContact.Click += new System.EventHandler(this.addContact_Click);
            // 
            // ContactsManagerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(445, 580);
            this.Controls.Add(this.addContact);
            this.Controls.Add(this.contactListLabel);
            this.Controls.Add(this.contactList);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ContactsManagerWindow";
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.ContactsManagerWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox contactList;
        private System.Windows.Forms.Label contactListLabel;
        private System.Windows.Forms.Button addContact;
    }
}