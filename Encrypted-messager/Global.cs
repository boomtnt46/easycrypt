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

        }

    }
}
