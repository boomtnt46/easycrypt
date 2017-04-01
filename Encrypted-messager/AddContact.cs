using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static Encrypted_messager.Global;

namespace Encrypted_messager
{
    public partial class AddContact : Form
    {
        ContactList contactmanager = new ContactList();
        ContactsManagerWindow contactmanagerwindow = new ContactsManagerWindow();
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
                contactmanager.contacts.Add(new Contacts.Contact { name = name.Text, email = email.Text, publicKey = pubKey, confidence = confidence.SelectedItem.ToString()});
                Console.WriteLine(contactmanager.contacts.Count);
                contactmanagerwindow.contactList.BeginUpdate();
                contactmanagerwindow.contactList.DataSource = contactmanager.contacts.Select(cont => cont.name).ToList();
                contactmanagerwindow.contactList.EndUpdate();
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
