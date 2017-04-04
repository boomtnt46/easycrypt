using System;
using System.Linq;
using System.Windows.Forms;
using static Encrypted_messager.Global;

namespace Encrypted_messager
{
    public partial class ContactsManagerWindow : Form
    {
        public ContactsManagerWindow()
        {
            InitializeComponent();
        }

        private void ContactsManagerWindow_Load(object sender, EventArgs e)
        {
            contactList.DataSource = ContactList.contacts.Select(contacts => contacts.name).ToList();
        }

        private void addContact_Click(object sender, EventArgs e)
        {
            AddContact AddContact = new AddContact();
            AddContact.Show();
            RefreshList();
        }

        public void contactList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshList()
        {
            contactList.DataSource = ContactList.contacts.Select(contacts => contacts.name).ToList();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to remove the selected contact?", "Remove contact", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                XmlHandler.DeleteContact(contactList.SelectedItem.ToString());

            }
        }
    }

}
