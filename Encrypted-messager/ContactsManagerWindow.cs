using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Encrypted_messager.Global;
using static Encrypted_messager.Global.Contacts;

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
            ContactList contactsList = new ContactList();
            contactList.DataSource = contactsList.contacts.Select(contacts => contacts.name).ToList();
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
            ContactList contactsList = new ContactList();
            contactList.DataSource = contactsList.contacts.Select(contacts => contacts.name).ToList();
        }
    }

}
