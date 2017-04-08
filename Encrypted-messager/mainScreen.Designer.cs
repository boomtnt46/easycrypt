namespace Encrypted_messager
{
    partial class MainScreen
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
            this.foreignMessage = new System.Windows.Forms.TextBox();
            this.receivedMessage = new System.Windows.Forms.TextBox();
            this.contactsButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.encryptButton = new System.Windows.Forms.Button();
            this.contactListSelection = new System.Windows.Forms.ComboBox();
            this.settingsButton = new System.Windows.Forms.Button();
            this.inboxButton = new System.Windows.Forms.Button();
            this.sentMessagesButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // foreignMessage
            // 
            this.foreignMessage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreignMessage.Location = new System.Drawing.Point(1155, 54);
            this.foreignMessage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.foreignMessage.Multiline = true;
            this.foreignMessage.Name = "foreignMessage";
            this.foreignMessage.Size = new System.Drawing.Size(894, 1002);
            this.foreignMessage.TabIndex = 0;
            this.foreignMessage.TextChanged += new System.EventHandler(this.foreignMessage_TextChanged);
            // 
            // receivedMessage
            // 
            this.receivedMessage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receivedMessage.Location = new System.Drawing.Point(253, 54);
            this.receivedMessage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.receivedMessage.Multiline = true;
            this.receivedMessage.Name = "receivedMessage";
            this.receivedMessage.Size = new System.Drawing.Size(894, 1002);
            this.receivedMessage.TabIndex = 1;
            this.receivedMessage.TextChanged += new System.EventHandler(this.receivedMessage_TextChanged);
            // 
            // contactsButton
            // 
            this.contactsButton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactsButton.Location = new System.Drawing.Point(1, 54);
            this.contactsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.contactsButton.Name = "contactsButton";
            this.contactsButton.Size = new System.Drawing.Size(244, 91);
            this.contactsButton.TabIndex = 2;
            this.contactsButton.Text = "Contacts";
            this.contactsButton.UseVisualStyleBackColor = true;
            this.contactsButton.Click += new System.EventHandler(this.contacts_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptButton.Location = new System.Drawing.Point(253, 1);
            this.decryptButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(895, 46);
            this.decryptButton.TabIndex = 3;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // encryptButton
            // 
            this.encryptButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptButton.Location = new System.Drawing.Point(1155, 1);
            this.encryptButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(672, 46);
            this.encryptButton.TabIndex = 4;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // contactListSelection
            // 
            this.contactListSelection.FormattingEnabled = true;
            this.contactListSelection.Location = new System.Drawing.Point(1835, 10);
            this.contactListSelection.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.contactListSelection.Name = "contactListSelection";
            this.contactListSelection.Size = new System.Drawing.Size(214, 31);
            this.contactListSelection.TabIndex = 5;
            this.contactListSelection.DropDown += new System.EventHandler(this.contactListSelection_DropDown);
            // 
            // settingsButton
            // 
            this.settingsButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.Location = new System.Drawing.Point(1, 1);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(244, 46);
            this.settingsButton.TabIndex = 6;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // inboxButton
            // 
            this.inboxButton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inboxButton.Location = new System.Drawing.Point(1, 152);
            this.inboxButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inboxButton.Name = "inboxButton";
            this.inboxButton.Size = new System.Drawing.Size(244, 91);
            this.inboxButton.TabIndex = 7;
            this.inboxButton.Text = "Inbox";
            this.inboxButton.UseVisualStyleBackColor = true;
            this.inboxButton.Click += new System.EventHandler(this.inboxButton_Click);
            // 
            // sentMessagesButton
            // 
            this.sentMessagesButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sentMessagesButton.Location = new System.Drawing.Point(1, 250);
            this.sentMessagesButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sentMessagesButton.Name = "sentMessagesButton";
            this.sentMessagesButton.Size = new System.Drawing.Size(244, 128);
            this.sentMessagesButton.TabIndex = 8;
            this.sentMessagesButton.Text = "Sent messages";
            this.sentMessagesButton.UseVisualStyleBackColor = true;
            this.sentMessagesButton.Click += new System.EventHandler(this.sentMessagesButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.Location = new System.Drawing.Point(1, 1011);
            this.aboutButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(244, 46);
            this.aboutButton.TabIndex = 9;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(2055, 1058);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.sentMessagesButton);
            this.Controls.Add(this.inboxButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.contactListSelection);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.contactsButton);
            this.Controls.Add(this.receivedMessage);
            this.Controls.Add(this.foreignMessage);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainScreen";
            this.Text = "Easycrypt";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox foreignMessage;
        private System.Windows.Forms.TextBox receivedMessage;
        private System.Windows.Forms.Button contactsButton;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.ComboBox contactListSelection;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button inboxButton;
        private System.Windows.Forms.Button sentMessagesButton;
        private System.Windows.Forms.Button aboutButton;
    }
}