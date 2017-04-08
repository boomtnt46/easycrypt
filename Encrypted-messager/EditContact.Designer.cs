namespace Encrypted_messager
{
    partial class EditContact
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
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.confidenceList = new System.Windows.Forms.ComboBox();
            this.selectPublicKey = new System.Windows.Forms.Button();
            this.filenameOfSelectedFile = new System.Windows.Forms.Label();
            this.confidenceOld = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(351, 148);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(103, 37);
            this.acceptButton.TabIndex = 2;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(242, 148);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(103, 37);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(85, 6);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(369, 30);
            this.nameTextBox.TabIndex = 4;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(85, 42);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(369, 30);
            this.emailTextBox.TabIndex = 6;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Confidence:";
            // 
            // confidenceList
            // 
            this.confidenceList.FormattingEnabled = true;
            this.confidenceList.Items.AddRange(new object[] {
            "None",
            "Low",
            "Medium",
            "High",
            "Total Trust"});
            this.confidenceList.Location = new System.Drawing.Point(132, 81);
            this.confidenceList.Name = "confidenceList";
            this.confidenceList.Size = new System.Drawing.Size(121, 31);
            this.confidenceList.TabIndex = 9;
            this.confidenceList.SelectedIndexChanged += new System.EventHandler(this.confidence_SelectedIndexChanged);
            // 
            // selectPublicKey
            // 
            this.selectPublicKey.Location = new System.Drawing.Point(12, 118);
            this.selectPublicKey.Name = "selectPublicKey";
            this.selectPublicKey.Size = new System.Drawing.Size(186, 30);
            this.selectPublicKey.TabIndex = 10;
            this.selectPublicKey.Text = "Select public key";
            this.selectPublicKey.UseVisualStyleBackColor = true;
            this.selectPublicKey.Click += new System.EventHandler(this.selectPublicKey_Click);
            // 
            // filenameOfSelectedFile
            // 
            this.filenameOfSelectedFile.AutoSize = true;
            this.filenameOfSelectedFile.Location = new System.Drawing.Point(204, 125);
            this.filenameOfSelectedFile.Name = "filenameOfSelectedFile";
            this.filenameOfSelectedFile.Size = new System.Drawing.Size(145, 23);
            this.filenameOfSelectedFile.TabIndex = 11;
            this.filenameOfSelectedFile.Text = "No file selected";
            this.filenameOfSelectedFile.Click += new System.EventHandler(this.filenameOfSelectedFile_Click);
            // 
            // confidenceOld
            // 
            this.confidenceOld.AutoSize = true;
            this.confidenceOld.Location = new System.Drawing.Point(259, 84);
            this.confidenceOld.Name = "confidenceOld";
            this.confidenceOld.Size = new System.Drawing.Size(0, 23);
            this.confidenceOld.TabIndex = 12;
            // 
            // EditContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(457, 191);
            this.ControlBox = false;
            this.Controls.Add(this.confidenceOld);
            this.Controls.Add(this.filenameOfSelectedFile);
            this.Controls.Add(this.selectPublicKey);
            this.Controls.Add(this.confidenceList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "EditContact";
            this.Text = "Edit contact";
            this.Load += new System.EventHandler(this.EditContact_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox confidenceList;
        private System.Windows.Forms.Button selectPublicKey;
        private System.Windows.Forms.Label filenameOfSelectedFile;
        private System.Windows.Forms.Label confidenceOld;
    }
}