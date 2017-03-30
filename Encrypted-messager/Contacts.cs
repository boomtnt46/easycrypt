using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using Encrypted_messager;


namespace Encrypted_messager
{
    static public class Contacts
    {
        public class Contact
        {
            public string name { get; set; }
            public string confidence { get; set; }
        }

        public class Confidence
        {
            public string low => "low";
            public string medium => "medium";
            public string high => "high";
        }
    }
}
