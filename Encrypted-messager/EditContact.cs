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
            nameTextBox.Text = contact.name;
            emailTextBox.Text = contact.email;
            filenameOfSelectedFile.Text = "Old public key not modified...";
            confidenceOld.Text = "Not changed (" + contact.confidence + ")";
        }

        private void EditContact_Load(object sender, EventArgs e)
        {

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
            if (confidenceList.SelectedItem != null)
            {
                XmlElement element = (XmlElement)XmlHandler.xmlcontacts.AppendChild(XmlHandler.xmldoc.CreateElement("Contact"));
                if (contact.name != nameTextBox.Text)
                {
                    element.SetAttribute("name", nameTextBox.Text);
                }
                else
                {
                    element.SetAttribute("name", contact.name);
                }

                if (contact.email != emailTextBox.Text)
                {
                    element.SetAttribute("email", emailTextBox.Text);
                }
                else
                {
                    element.SetAttribute("email", contact.email);
                }

                if (contact.confidence != confidenceList.SelectedItem.ToString())
                {
                    element.SetAttribute("confidence", confidenceList.SelectedItem.ToString());
                }
                else
                {
                    element.SetAttribute("confidence", contact.confidence);
                }

                if (pubkey != contact.publicKey)
                {
                    element.AppendChild(XmlHandler.xmldoc.CreateElement("pgppublickey")).InnerText = pubkey;
                }
                else
                {
                    element.AppendChild(XmlHandler.xmldoc.CreateElement("pgppublickey")).InnerText = contact.publicKey;
                }
                XmlHandler.EditContact(contact.name, element);
                this.Close();
            }
            else
            {
                MessageBox.Show("Select the confidence before continuing", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
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
