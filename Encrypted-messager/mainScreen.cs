using System;
using System.Linq;
using System.Windows.Forms;
using static Encrypted_messager.Global;

namespace Encrypted_messager
{
    public partial class MainScreen : Form
    {
        ContactList contactsList = new ContactList();
        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            contactListSelection.DataSource = contactsList.contacts.Select(contacts => contacts.name).ToList();
        }

        private void contacts_Click(object sender, EventArgs e)
        {
            ContactsManagerWindow contactsManagerWindow = new ContactsManagerWindow();
            contactsManagerWindow.Show();
            contactsList = new ContactList();
            RefreshList();

        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
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
            RefreshList();
        }

        private void RefreshList()
        {
            contactsList = new ContactList();
            contactListSelection.DataSource = contactsList.contacts.Select(contacts => contacts.name).ToList();
        }
    }
}
