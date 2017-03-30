using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using static Encrypted_messager.ContactManager;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encrypted_messager
{
    public partial class AddContact : Form
    {
        ContactManager contactmanager = new ContactManager();
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
                contactmanager.contacts.Add(new Global.Contacts.Contact { name = name.Text, email = email.Text, publicKey = pubKey, confidence = confidence.SelectedItem.ToString()});
                this.Close();
            }
            else
            {
                MessageBox.Show("Fill in everything first please");
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
            ofd.Filter = "txt files (*.txt)|*.txt|pgp files (*.pgp)|*.pgp|asc files (*.asc)|*.asc";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.OpenFile() != null)
                {
                    StreamReader sr = new StreamReader(ofd.OpenFile());
                    pubKey = sr.ReadToEnd();
                }
            }
            

        }

        private void confidence_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
