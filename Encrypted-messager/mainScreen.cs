using System;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Text;
using static Encrypted_messager.Global;

namespace Encrypted_messager
{
    public partial class MainScreen : Form
    {
        public string path = @"C:\Program Files (x86)\GnuPG\bin\gpgd.exe"; //default path for gpg bin file
        public MainScreen()
        {
            InitializeComponent();
            this.Enabled = false;
            (new CreateKeys()).Show();
            this.Enabled = true;
            //This looks for the config file, and if it doesn't exist, creates one.

            /*if (!File.Exists("settings.dat"))
            {
                //TODO: CREATE CONFIG FILE (IF NECCESARY)
            }
            else
            {
                //StreamReader sr = new StreamReader("settings.dat", Encoding.UTF8);
                //@path = sr.ReadLine().Substring(12);
            }
            */

        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            //load contact list for main form
            contactListSelection.DataSource = ContactList.contacts.Select(contacts => contacts.name).ToList();
        }

        private void contacts_Click(object sender, EventArgs e)
        {
            //Show contcts window
            ContactsManagerWindow contactsManagerWindow = new ContactsManagerWindow();
            contactsManagerWindow.Show();
            RefreshList();

        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            //Show about window
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
            //call once the list is clicked
            RefreshList();
        }

        private void RefreshList()

        {
            //refresh contact list
            contactListSelection.DataSource = ContactList.contacts.Select(contacts => contacts.name).ToList();
        }
    }
}
