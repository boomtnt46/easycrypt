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
            this.exitButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contactList
            // 
            this.contactList.FormattingEnabled = true;
            this.contactList.Location = new System.Drawing.Point(12, 39);
            this.contactList.Name = "contactList";
            this.contactList.Size = new System.Drawing.Size(384, 31);
            this.contactList.TabIndex = 0;
            this.contactList.SelectedIndexChanged += new System.EventHandler(this.contactList_SelectedIndexChanged);
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
            this.addContact.Location = new System.Drawing.Point(12, 76);
            this.addContact.Name = "addContact";
            this.addContact.Size = new System.Drawing.Size(109, 31);
            this.addContact.TabIndex = 2;
            this.addContact.Text = "Add new";
            this.addContact.UseVisualStyleBackColor = true;
            this.addContact.Click += new System.EventHandler(this.addContact_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(474, 259);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(90, 40);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Accept";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(402, 40);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(62, 30);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(470, 40);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(94, 30);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // ContactsManagerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(568, 311);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addContact);
            this.Controls.Add(this.contactListLabel);
            this.Controls.Add(this.contactList);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ContactsManagerWindow";
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.ContactsManagerWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label contactListLabel;
        private System.Windows.Forms.Button addContact;
        public System.Windows.Forms.ComboBox contactList;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
    }
}