using System;
using System.Windows.Forms;

namespace Encrypted_messager
{
    class main
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainScreen());

        }
    }
}