using System;
using System.Linq;
using System.IO;
using Org.BouncyCastle.Bcpg;
using Org.BouncyCastle.Bcpg.OpenPgp;
using System.Windows.Forms;
using System.Text;
using static Encrypted_messager.Global;
using static Encrypted_messager.PGP;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.Utilities.Encoders;
using System.Security.Cryptography;
using Org.BouncyCastle.Security;

namespace Encrypted_messager
{
    public partial class MainScreen : Form
    {
        public string path = @"C:\Program Files (x86)\GnuPG\bin\gpgd.exe"; //default path for gpg bin file
        public MainScreen()
        {
            InitializeComponent();
            //This looks for the config file, and if it doesn't exist, creates one.

            if (!File.Exists("settings.dat"))
            {
                this.Enabled = false;
                new CreateKeys().ShowDialog();
                this.Enabled = true;
                StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + @"\settings.dat");
                sw.WriteLine("keys-alredy-created=" + true);
                sw.Close();
                MessageBox.Show("Keys created. The program will now close. Plese start it again.");
                Environment.Exit(1);
            }
            else
            {
                //StreamReader sr = new StreamReader("settings.dat", Encoding.UTF8);
                //@path = sr.ReadLine().Substring(12);
            }

        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            //load contact list for main form
            contactListSelection.DataSource = ContactList.ReturnList().Select(contacts => (contacts.name + " (" + contacts.email + ")")).ToList();

        }

        private void contacts_Click(object sender, EventArgs e)
        {
            //Show contcts window
            ContactsManagerWindow contactsManagerWindow = new ContactsManagerWindow();
            contactsManagerWindow.Show();

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
            byte[] byteString = Encoding.ASCII.GetBytes(textToSend.Text);
            Stream st = new MemoryStream(byteString);

            //ContactList.ReturnList()[contactListSelection.SelectedIndex].publicKey;

            //EncryptFile(st, ("temp" + DateTime.Now.Millisecond), pk, true, true);
        }

        public void receivedMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void textToSend_TextChanged(object sender, EventArgs e)
        {

        }

        private void contactListSelection_DropDown(object sender, EventArgs e)
        {
            contactListSelection.DataSource = ContactList.ReturnList().Select(contacts => (contacts.name + " (" + contacts.email + ")")).ToList();
        }
    }
}
