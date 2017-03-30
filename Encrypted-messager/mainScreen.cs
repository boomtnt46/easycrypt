using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encrypted_messager
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void contacts_Click(object sender, EventArgs e)
        {
            ContactsManagerWindow cmw = new ContactsManagerWindow();
            cmw.Show();
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
