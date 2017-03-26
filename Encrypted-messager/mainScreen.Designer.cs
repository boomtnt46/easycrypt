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
            this.foreignMessage.Location = new System.Drawing.Point(945, 47);
            this.foreignMessage.Multiline = true;
            this.foreignMessage.Name = "foreignMessage";
            this.foreignMessage.Size = new System.Drawing.Size(732, 872);
            this.foreignMessage.TabIndex = 0;
            this.foreignMessage.TextChanged += new System.EventHandler(this.foreignMessage_TextChanged);
            // 
            // receivedMessage
            // 
            this.receivedMessage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receivedMessage.Location = new System.Drawing.Point(207, 47);
            this.receivedMessage.Multiline = true;
            this.receivedMessage.Name = "receivedMessage";
            this.receivedMessage.Size = new System.Drawing.Size(732, 872);
            this.receivedMessage.TabIndex = 1;
            this.receivedMessage.TextChanged += new System.EventHandler(this.receivedMessage_TextChanged);
            // 
            // contactsButton
            // 
            this.contactsButton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactsButton.Location = new System.Drawing.Point(1, 47);
            this.contactsButton.Name = "contactsButton";
            this.contactsButton.Size = new System.Drawing.Size(200, 79);
            this.contactsButton.TabIndex = 2;
            this.contactsButton.Text = "Contacts";
            this.contactsButton.UseVisualStyleBackColor = true;
            this.contactsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptButton.Location = new System.Drawing.Point(207, 1);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(732, 40);
            this.decryptButton.TabIndex = 3;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // encryptButton
            // 
            this.encryptButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptButton.Location = new System.Drawing.Point(945, 1);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(575, 40);
            this.encryptButton.TabIndex = 4;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // contactListSelection
            // 
            this.contactListSelection.FormattingEnabled = true;
            this.contactListSelection.Location = new System.Drawing.Point(1526, 9);
            this.contactListSelection.Name = "contactListSelection";
            this.contactListSelection.Size = new System.Drawing.Size(151, 28);
            this.contactListSelection.TabIndex = 5;
            this.contactListSelection.SelectedIndexChanged += new System.EventHandler(this.contactListSelection_SelectedIndexChanged);
            // 
            // settingsButton
            // 
            this.settingsButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.Location = new System.Drawing.Point(1, 1);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(200, 40);
            this.settingsButton.TabIndex = 6;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // inboxButton
            // 
            this.inboxButton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inboxButton.Location = new System.Drawing.Point(1, 132);
            this.inboxButton.Name = "inboxButton";
            this.inboxButton.Size = new System.Drawing.Size(200, 79);
            this.inboxButton.TabIndex = 7;
            this.inboxButton.Text = "Inbox";
            this.inboxButton.UseVisualStyleBackColor = true;
            this.inboxButton.Click += new System.EventHandler(this.inboxButton_Click);
            // 
            // sentMessagesButton
            // 
            this.sentMessagesButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sentMessagesButton.Location = new System.Drawing.Point(1, 217);
            this.sentMessagesButton.Name = "sentMessagesButton";
            this.sentMessagesButton.Size = new System.Drawing.Size(200, 81);
            this.sentMessagesButton.TabIndex = 8;
            this.sentMessagesButton.Text = "Sent messages";
            this.sentMessagesButton.UseVisualStyleBackColor = true;
            this.sentMessagesButton.Click += new System.EventHandler(this.sentMessagesButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.Location = new System.Drawing.Point(1, 879);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(200, 40);
            this.aboutButton.TabIndex = 9;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1681, 920);
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
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainScreen";
            this.Text = "Easycrypt";
            this.Load += new System.EventHandler(this.Form1_Load);
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