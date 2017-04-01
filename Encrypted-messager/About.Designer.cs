namespace Encrypted_messager
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.linkToTwitter = new System.Windows.Forms.LinkLabel();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkToTwitter
            // 
            this.linkToTwitter.AutoSize = true;
            this.linkToTwitter.Location = new System.Drawing.Point(12, 584);
            this.linkToTwitter.Name = "linkToTwitter";
            this.linkToTwitter.Size = new System.Drawing.Size(287, 23);
            this.linkToTwitter.TabIndex = 0;
            this.linkToTwitter.TabStop = true;
            this.linkToTwitter.Text = "Visit me on twitter @boomtnt46";
            this.linkToTwitter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkToTwitter_LinkClicked);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(12, 18);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(914, 552);
            this.infoLabel.TabIndex = 1;
            this.infoLabel.Text = resources.GetString("infoLabel.Text");
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 616);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.linkToTwitter);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "About";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkToTwitter;
        private System.Windows.Forms.Label infoLabel;
    }
}