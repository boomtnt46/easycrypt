using System;
using System.Collections.Generic;
using System.Linq;
using Org.BouncyCastle.Bcpg;
using Org.BouncyCastle.Bcpg.OpenPgp;
using Org.BouncyCastle.Security;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encrypted_messager
{
    public static class PGP
    {
        public static Stream EncryptFile(Stream outputStream, string fileName, PgpPublicKey pubkey, bool armor, bool withIntegrityCheck)
        {
            if (armor)
            {
                outputStream = new ArmoredOutputStream(outputStream);
            }

            MemoryStream bOut = new MemoryStream();

            PgpCompressedDataGenerator comData = new PgpCompressedDataGenerator(CompressionAlgorithmTag.Zip);

            PgpUtilities.WriteFileToLiteralData(comData.Open(bOut), PgpLiteralData.Binary, new FileInfo(fileName));

            comData.Close();

            byte[] bytes = bOut.ToArray();

            PgpEncryptedDataGenerator pgpencrypteddatagenerator = new PgpEncryptedDataGenerator(SymmetricKeyAlgorithmTag.Cast5, withIntegrityCheck, new SecureRandom());

            pgpencrypteddatagenerator.AddMethod(pubkey);

            Stream cOut = pgpencrypteddatagenerator.Open(outputStream, bytes.Length);

            cOut.Write(bytes, 0, bytes.Length);

            cOut.Close();

            if (armor)
            {
                outputStream.Close();
            }
            MessageBox.Show(cOut.ToString());
            return cOut;

        }


    }
}
