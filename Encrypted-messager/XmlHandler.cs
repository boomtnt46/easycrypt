using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml;
using static Encrypted_messager.Global.Contacts;

namespace Encrypted_messager
{
    public static class XmlHandler
    {
        static XmlDocument xmldoc = new XmlDocument();
        static XmlElement xmlcontacts;
        static string xmlFilePath = Path.GetDirectoryName(Application.ExecutablePath) + @"\DATA.xml";
        static  XmlHandler()
        {
            if (File.Exists(xmlFilePath))
            {
                xmldoc.Load(xmlFilePath);
                xmlcontacts = (XmlElement)xmldoc.FirstChild;
            }
            else
            {
                xmlcontacts = (XmlElement)xmldoc.AppendChild(xmldoc.CreateElement("Contacts"));
                xmldoc.Save(xmlFilePath);
            }

        }

        public static void WriteContactToXML(string name, string email, string confidence, string pubkey)
        {
            XmlElement contact = (XmlElement) xmlcontacts.AppendChild(xmldoc.CreateElement("Contact"));
            contact.SetAttribute("name", name);
            contact.SetAttribute("email", email);
            contact.SetAttribute("confidence", confidence);
            contact.AppendChild(xmldoc.CreateElement("pgppublickey")).InnerText = pubkey;
            xmldoc.Save(xmlFilePath);
        }

        public static BindingList<Contact> LoadContactsFromXML()
        {
            BindingList<Contact> list = new BindingList<Contact>();
            XmlNodeList contactNodes = xmldoc.GetElementsByTagName("Contact");

            foreach (XmlNode xmlnode in contactNodes)
            {

                XmlAttributeCollection xmlAttrs = xmlnode.Attributes;
                XmlNode xmlElem = xmlnode.FirstChild;
                list.Add(new Contact
                {
                    name = xmlAttrs.GetNamedItem("name").InnerText,
                    email = xmlAttrs.GetNamedItem("email").InnerText,
                    confidence = xmlAttrs.GetNamedItem("confidence").InnerText,
                    publicKey = xmlElem.InnerText
                });
            }
            return list;

        }

        public static void DeleteContact(string ContactToRemove)
        {
            try
            {

                XmlNode xmlnode = xmldoc.GetElementsByTagName("Contacts")[0];
                xmlnode.RemoveChild(xmlnode.SelectSingleNode("Contact[@name = '" + ContactToRemove + "']"));
                xmldoc.Save(xmlFilePath);

                MessageBox.Show("Contact deleted");
            }
            catch
            {
                throw new XmlException();
            }
        }
    }
}
