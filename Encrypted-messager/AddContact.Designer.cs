namespace Encrypted_messager
{
    partial class AddContact
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
            this.closeAddContactWindow = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.selectPublicKey = new System.Windows.Forms.Button();
            this.confidence = new System.Windows.Forms.ComboBox();
            this.confidenceLabel = new System.Windows.Forms.Label();
            this.filenameOfSelectedFile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeAddContactWindow
            // 
            this.closeAddContactWindow.Location = new System.Drawing.Point(388, 174);
            this.closeAddContactWindow.Name = "closeAddContactWindow";
            this.closeAddContactWindow.Size = new System.Drawing.Size(95, 34);
            this.closeAddContactWindow.TabIndex = 0;
            this.closeAddContactWindow.Text = "Save";
            this.closeAddContactWindow.UseVisualStyleBackColor = true;
            this.closeAddContactWindow.Click += new System.EventHandler(this.closeAddContactWindow_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.ForeColor = System.Drawing.Color.Transparent;
            this.nameLabel.Location = new System.Drawing.Point(12, 28);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(67, 23);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(85, 28);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(398, 30);
            this.name.TabIndex = 2;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(85, 65);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(398, 30);
            this.email.TabIndex = 3;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.ForeColor = System.Drawing.Color.Transparent;
            this.emailLabel.Location = new System.Drawing.Point(12, 68);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(64, 23);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "Email:";
            // 
            // selectPublicKey
            // 
            this.selectPublicKey.Location = new System.Drawing.Point(12, 139);
            this.selectPublicKey.Name = "selectPublicKey";
            this.selectPublicKey.Size = new System.Drawing.Size(186, 30);
            this.selectPublicKey.TabIndex = 5;
            this.selectPublicKey.Text = "Select public key";
            this.selectPublicKey.UseVisualStyleBackColor = true;
            this.selectPublicKey.Click += new System.EventHandler(this.selectPublicKey_Click);
            // 
            // confidence
            // 
            this.confidence.FormattingEnabled = true;
            this.confidence.Items.AddRange(new object[] {
            "None",
            "Low",
            "Medium",
            "High",
            "Total Trust"});
            this.confidence.Location = new System.Drawing.Point(132, 102);
            this.confidence.Name = "confidence";
            this.confidence.Size = new System.Drawing.Size(121, 31);
            this.confidence.TabIndex = 6;
            this.confidence.SelectedIndexChanged += new System.EventHandler(this.confidence_SelectedIndexChanged);
            // 
            // confidenceLabel
            // 
            this.confidenceLabel.AutoSize = true;
            this.confidenceLabel.ForeColor = System.Drawing.Color.Transparent;
            this.confidenceLabel.Location = new System.Drawing.Point(12, 105);
            this.confidenceLabel.Name = "confidenceLabel";
            this.confidenceLabel.Size = new System.Drawing.Size(114, 23);
            this.confidenceLabel.TabIndex = 7;
            this.confidenceLabel.Text = "Confidence:";
            // 
            // filenameOfSelectedFile
            // 
            this.filenameOfSelectedFile.AutoSize = true;
            this.filenameOfSelectedFile.ForeColor = System.Drawing.Color.Transparent;
            this.filenameOfSelectedFile.Location = new System.Drawing.Point(219, 143);
            this.filenameOfSelectedFile.Name = "filenameOfSelectedFile";
            this.filenameOfSelectedFile.Size = new System.Drawing.Size(145, 23);
            this.filenameOfSelectedFile.TabIndex = 8;
            this.filenameOfSelectedFile.Text = "No file selected";
            this.filenameOfSelectedFile.Click += new System.EventHandler(this.filenameOfSelectedFile_Click);
            // 
            // AddContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(487, 220);
            this.Controls.Add(this.filenameOfSelectedFile);
            this.Controls.Add(this.confidenceLabel);
            this.Controls.Add(this.confidence);
            this.Controls.Add(this.selectPublicKey);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.email);
            this.Controls.Add(this.name);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.closeAddContactWindow);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AddContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Contact";
            this.Load += new System.EventHandler(this.AddContact_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeAddContactWindow;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button selectPublicKey;
        private System.Windows.Forms.ComboBox confidence;
        private System.Windows.Forms.Label confidenceLabel;
        private System.Windows.Forms.Label filenameOfSelectedFile;
    }
}