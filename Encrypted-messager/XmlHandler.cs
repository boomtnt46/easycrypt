using System.Windows.Forms;
using System.Xml;
using System.IO;
using static Encrypted_messager.Global;
using static Encrypted_messager.Global.Contacts;
using System.Collections.Generic;
using System.ComponentModel;

namespace Encrypted_messager
{
    public class XmlHandler
    {
        XmlDocument xmldoc = new XmlDocument();
        XmlElement xmlcontacts;
        public string xmlFilePath = @Path.GetDirectoryName(Application.ExecutablePath) + @"\DATA.xml";

        public XmlHandler()
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

        public void WriteContactToXML(string name, string email, string confidence, string pubkey)
        {
            XmlElement contact = (XmlElement)xmlcontacts.AppendChild(xmldoc.CreateElement("Contact"));
            contact.SetAttribute("name", name);
            contact.SetAttribute("email", email);
            contact.SetAttribute("confidence", confidence);
            contact.AppendChild(xmldoc.CreateElement("pgppublickey")).InnerText = pubkey;
            xmldoc.Save(xmlFilePath);
        }

        public BindingList<Contact> LoadContactsFromXML()
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
    }
}
