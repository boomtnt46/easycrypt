using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using static Encrypted_messager.Global.Contacts;
using System.Xml;

namespace Encrypted_messager
{
    public class Global
    {
       
        static public class Contacts
        {
            public class Contact
            {
                public string name { get; set; }
                public string email { get; set; }
                public string confidence { get; set; }
                public string publicKey { get; set; }
            }

            public class Confidence
            {
                public string low => "low";
                public string medium => "medium";
                public string high => "high";
            }
        }

        public class ContactList
        {
            public List<Contact> contacts = new List<Contact>();
            public ContactList()
            {
                
            }
        }

        public class XmlHandler
        {
            XmlElement contact = (XmlElement)contacts.AppendChild(xmldoc.CreateElement("Contact"));
            contact.SetAttribute("Name", name.Text);
            contact.SetAttribute("Last-name", last_name.Text);
            contact.SetAttribute("Nick", nick.Text);

            MessageBox.Show(xmldoc.OuterXml);
            XmlNodeList contactNodes = xmldoc.GetElementsByTagName("Contact");
            XmlNodeList contactsName = xmldoc.GetElementsByTagName("Name");
            XmlNodeList contactsLastName = xmldoc.GetElementsByTagName("Last-name");
            XmlNodeList contactsNick = xmldoc.GetElementsByTagName("Nick");

            foreach (XmlNode xmlnode in contactNodes)
            {
                //contactList.Add(new Contact{ });
                XmlAttributeCollection xmlAttrs = xmlnode.Attributes;
            contactList.Add(new Contact
                {
                    name = xmlAttrs.GetNamedItem("Name").InnerText,
                    last_name = xmlAttrs.GetNamedItem("Last-name").InnerText,
                    nick = xmlAttrs.GetNamedItem("Nick").InnerText
        });
            }
    MessageBox.Show(contactList[0].name + " " + contactList[0].last_name + " " + contactList[0].nick);
        }
    }
}
