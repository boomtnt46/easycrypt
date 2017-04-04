using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Encrypted_messager;
using System.Drawing;
using System.Linq;
using System.Text;
using PgpSharp.GnuPG;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encrypted_messager
{
    public partial class CreateKeys : Form
    {
        public CreateKeys()
        {
            InitializeComponent();
        }

        private void CreateKeys_Load(object sender, EventArgs e)
        {
            GnuPGConfig.GnuPGExePath = (new MainScreen()).path;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Keys.GenerateKeys();
        }
    }

    public static class Keys
    {
        public static void GenerateKeys()
        {
            GnuPGTool pgpsharp = new GnuPGTool();
            pgpsharp.KeyringFolder = Environment.CurrentDirectory + "public-keyring.pkr";
            
        }
    }
}
