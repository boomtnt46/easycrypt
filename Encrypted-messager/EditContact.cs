using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Encrypted_messager;
using System.Text;
using System.Xml;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encrypted_messager
{
    public partial class EditContact : Form
    {
        public Global.Contacts.Contact contact;
        public string pubkey;
        public EditContact(Global.Contacts.Contact item)
        {
            contact = item;
            InitializeComponent();
        }

        private void EditContact_Load(object sender, EventArgs e)
        {
            nameTextBox.Text = contact.name;
            emailTextBox.Text = contact.email;
            confidenceList.SelectedText = contact.confidence;
            filenameOfSelectedFile.Text = "Old public key not modified...";
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void confidence_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void selectPublicKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "asc files (*.asc)|*.asc|pgp files (*.pgp)|*.pgp|txt files (*.txt)|*.txt|any file|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.OpenFile() != null)
                {
                    StreamReader sr = new StreamReader(ofd.OpenFile());
                    pubkey = sr.ReadToEnd();
                }
            }
            filenameOfSelectedFile.Text = ofd.SafeFileName;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            XmlElement element = (XmlElement)XmlHandler.xmlcontacts.AppendChild(XmlHandler.xmldoc.CreateElement("Contact"));
            element.SetAttribute("name", nameTextBox.Text);
            element.SetAttribute("email", emailTextBox.Text);
            element.SetAttribute("confidence", confidenceList.SelectedItem.ToString());
            element.AppendChild(XmlHandler.xmldoc.CreateElement("pgppublickey")).InnerText = pubkey;
            XmlHandler.EditContact(contact.name, element);
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void filenameOfSelectedFile_Click(object sender, EventArgs e)
        {

        }
    }
}
