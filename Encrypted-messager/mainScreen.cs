using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using static Encrypted_messager.Global;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encrypted_messager
{
    public partial class MainScreen : Form
    {
        ContactList contactList = new ContactList();
        ContactsManagerWindow contactsManagerWindow = new ContactsManagerWindow();
        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            contactListSelection.DataSource = contactList.contacts.Select(contact => contact.name).ToList();
        }

        private void contacts_Click(object sender, EventArgs e)
        {

            contactsManagerWindow.Show();
            contactsManagerWindow = new ContactsManagerWindow();
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

    }
}
