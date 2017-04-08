using System.ComponentModel;
using static Encrypted_messager.Global.Contacts;

namespace Encrypted_messager
{
    public static class Global
    {
       public static string GpgBinaryPath { get; set; }
        static public class Contacts
        {
            public class Contact
            {
                public string name { get; set; }
                public string email { get; set; }
                public string confidence { get; set; }
                public string publicKey { get; set; }
            }

        }

        public static class ContactList
        {
            static public BindingList<Contact> contacts = new BindingList<Contact>();

            public static BindingList<Contact> ReturnList()
            {
                contacts = XmlHandler.LoadContactsFromXML();
                return contacts;
            }

            static ContactList()
            {
                contacts = XmlHandler.LoadContactsFromXML();
            }
        }

    }
}
