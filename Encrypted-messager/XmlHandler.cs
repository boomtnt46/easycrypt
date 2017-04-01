using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Threading.Tasks;

namespace Encrypted_messager
{
    public class XmlHandler
    {
        XmlDocument xmldoc = new XmlDocument();
        XmlElement xmlcontacts;

        public XmlHandler()
        {
            xmldoc.Load(File.Open("DATA.xml", FileMode.OpenOrCreate));

            if (xmldoc.HasChildNodes == false)
            {
                xmlcontacts = (XmlElement)xmldoc.AppendChild(xmldoc.CreateElement("Contacts"));
            }
        }

        public void WriteContactToXML(string name, string email, string confidence, string pubkey)
        {
            XmlElement contact = (XmlElement)xmlcontacts.AppendChild(xmldoc.CreateElement("Contact"));
            contact.SetAttribute("name", name);
            contact.SetAttribute("email", email);
            contact.SetAttribute("confidence", confidence);
            contact.AppendChild(xmldoc.CreateElement("pgppublickey")).InnerText = pubkey;
        }
    }
}
