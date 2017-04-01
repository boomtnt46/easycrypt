using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using static Encrypted_messager.Global;
using static Encrypted_messager.Global.Contacts;

namespace Encrypted_messager
{
    public partial class MainScreen : Form
    {

        ContactList contactList = new ContactList();
        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            contactListSelection.DataSource = contactList.contacts.Select(contacts => contacts.name).ToList();
        }

        private void contacts_Click(object sender, EventArgs e)
        {
            ContactsManagerWindow contactsManagerWindow = new ContactsManagerWindow();
            contactsManagerWindow.Show();
            RefreshList();

        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            
        }

        private void sentMessagesButton_Click(object sender, EventArgs e)
        {

        }

        private void inboxButton_Click(object sender, EventArgs e)
        {

        }

        private void settingsButton_Click(object sender, EventArgs e)
        {

        }

        private void decryptButton_Click(object sender, EventArgs e)
        {

        }

        private void encryptButton_Click(object sender, EventArgs e)
        {

        }

        public void receivedMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void foreignMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void contactListSelection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RefreshList()
        {
            ContactList contactsList = new ContactList();
            contactListSelection.DataSource = contactsList.contacts.Select(contacts => contacts.name).ToList();
        }
    }
}
