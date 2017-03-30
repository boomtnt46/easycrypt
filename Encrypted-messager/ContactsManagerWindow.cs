using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        }

        private void addContact_Click(object sender, EventArgs e)
        {
            AddContact ac = new AddContact();
            ac.Show();
        }
    }

    class ContactManager
    {
        public List<Contact> contacts = new List<Contact>();
        public ContactManager()
        {

        }
    }
}
