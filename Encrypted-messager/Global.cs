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

            public class Confidence
            {
                public string low => "low";
                public string medium => "medium";
                public string high => "high";
            }
        }

        public static class ContactList
        {
            static public BindingList<Contact> contacts = new BindingList<Contact>();
            
            static  ContactList()
            {
                contacts = XmlHandler.LoadContactsFromXML();
            }

            public static void ReloadList()
            {
                contacts = XmlHandler.LoadContactsFromXML();
            }
        }

    }
}
