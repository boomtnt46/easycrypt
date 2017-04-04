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
            //This looks for the config file, and if it doesn't exist, creates one
            if (!File.Exists("settings.dat"))
            {
                while (!File.Exists(path))
                {
                    var result = MessageBox.Show("It appears that you don't have 'GPG' installed in the default location." +
                        " Please install 'GPG' if you don't have it installed, and then press Retry. If you have 'GPG' installed in a non default location," +
                        " press Ignore and select the binary file of 'GPG' (named gpg.exe)." +
                        " Press Abort if you want to exit.",
                        "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);

                    if (result == DialogResult.Abort)
                    {
                        Environment.Exit(0);

                    }
                    else if (result == DialogResult.Ignore)
                    {
                        OpenFileDialog ofd = new OpenFileDialog();
                        ofd.Filter = "exe files (*.exe)|*.exe";
                        if (ofd.ShowDialog() == DialogResult.OK)
                        {
                            path = ofd.FileName;
                            StreamWriter sw = new StreamWriter("settings.dat", false, Encoding.UTF8);
                            sw.WriteLine("binary-path=" + path);
                            sw.Close();
                        }
                    }
                    else if (result == DialogResult.Retry)
                    {
                        continue;
                    }
                    (new CreateKeys()).Show();
                }
            }
            else
            {
                StreamReader sr = new StreamReader("settings.dat", Encoding.UTF8);
                @path = sr.ReadLine().Substring(12);
            }
            
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
            RefreshList();
        }

        private void RefreshList()

        {
            //refresh contact list
            contactListSelection.DataSource = ContactList.contacts.Select(contacts => contacts.name).ToList();
        }
    }
}
