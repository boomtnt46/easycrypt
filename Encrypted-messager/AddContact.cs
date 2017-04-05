using System;
using System.IO;
using System.Windows.Forms;

namespace Encrypted_messager
{
    public partial class AddContact : Form
    {
        public string pubKey;
        public AddContact()
        {
            InitializeComponent();
            pubKey = null;
        }

        private void AddContact_Load(object sender, EventArgs e)
        {
        }

        private void closeAddContactWindow_Click(object sender, EventArgs e)
        {
            if (name.Text != String.Empty && email.Text != String.Empty && pubKey != String.Empty && confidence.SelectedItem != null)
            {
                XmlHandler.WriteContactToXML(name.Text, email.Text, confidence.SelectedItem.ToString(), pubKey);
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Fill in everything first please", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void selectPublicKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt files (*.txt)|*.txt|pgp files (*.pgp)|*.pgp|asc files (*.asc)|*.asc|any file|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.OpenFile() != null)
                {
                    StreamReader sr = new StreamReader(ofd.OpenFile());
                    pubKey = sr.ReadToEnd();
                }
            }
            filenameOfSelectedFile.Text = ofd.SafeFileName;
        }

        private void confidence_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void filenameOfSelectedFile_Click(object sender, EventArgs e)
        {

        }
    }
}
