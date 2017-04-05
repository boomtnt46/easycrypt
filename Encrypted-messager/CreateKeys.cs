using System;
using System.Windows.Forms;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Security;
using System.IO;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Bcpg.OpenPgp;
using Org.BouncyCastle.Bcpg;

namespace Encrypted_messager
{
    public partial class CreateKeys : Form
    {
        public CreateKeys()
        {
            InitializeComponent();
            this.ControlBox = false;
            MessageBox.Show("It seems that this is the first run. Please create a pair of keys. Fill the form to continue.");
        }

        private void CreateKeys_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == repeatPassowrdTextBox.Text)
            {
                MessageBox.Show("The program will now generate the keys. This may take some time. Please wait patiently.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Keys.GenerateKeys(textBox1.Text, passwordTextBox.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter the same password in the tho boxes", "Password mismatch", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void repeatPassowrdTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public static class Keys
    {
        public static void GenerateKeys(string fullname, string password)
        {
            Directory.CreateDirectory(Environment.CurrentDirectory + @"\Keys\");
            GenerateKey(fullname, password, Environment.CurrentDirectory + @"\Keys\");

        }

        public static void GenerateKey(string username, string password, string keyStoreUrl)
        {
            IAsymmetricCipherKeyPairGenerator kpg = new RsaKeyPairGenerator();
            kpg.Init(new RsaKeyGenerationParameters(BigInteger.ValueOf(new SecureRandom().Next(1,999)), new SecureRandom(), 4096, 8));
            AsymmetricCipherKeyPair kp = kpg.GenerateKeyPair();

            FileStream out1 = new FileInfo(string.Format("{0}secret.asc", keyStoreUrl)).OpenWrite();
            FileStream out2 = new FileInfo(string.Format("{0}pub.asc", keyStoreUrl)).OpenWrite();

            ExportKeyPair(out1, out2, kp.Public, kp.Private, username, password.ToCharArray(), true);

        }

        private static void ExportKeyPair(
                Stream secretOut,
                Stream publicOut,
                AsymmetricKeyParameter publicKey,
                AsymmetricKeyParameter privateKey,
                string identity,
                char[] passPhrase,
                bool armor)
        {
            if (armor)
            {
                secretOut = new ArmoredOutputStream(secretOut);
            }

            PgpSecretKey secretKey = new PgpSecretKey(
                PgpSignature.DefaultCertification,
                PublicKeyAlgorithmTag.RsaGeneral,
                publicKey,
                privateKey,
                DateTime.Now,
                identity,
                SymmetricKeyAlgorithmTag.Aes256,
                passPhrase,
                null,
                null,
                new SecureRandom()
                );

            secretKey.Encode(secretOut);
            secretOut.Close();
            if (armor)
            {
                publicOut = new ArmoredOutputStream(publicOut);
            }
            PgpPublicKey key = secretKey.PublicKey;
            key.Encode(publicOut);
            publicOut.Close();
        }
    }
}