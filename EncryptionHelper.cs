using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption
{
    class EncryptionHelper
    {
        public enum EncryptionMode
        {
            GREEK,
            CAESAR,
            ADFGVX
        }

        public static String Encrypt(String textToEncrypt, EncryptionMode enc, object[] keys)
        {
            switch (enc)
            {
                case EncryptionMode.GREEK:
                    return Encrypt(new OldGreek(), textToEncrypt, keys);
                case EncryptionMode.CAESAR:
                    return Encrypt(new Caesar(), textToEncrypt, keys);
                case EncryptionMode.ADFGVX:
                    return Encrypt(new ADFGVX(), textToEncrypt, keys);
            }

            return textToEncrypt;
        }

        public static String Decrypt(String textToDecrypt, EncryptionMode enc, object[] keys)
        {
            switch (enc)
            {
                case EncryptionMode.GREEK:
                    return Decrypt(new OldGreek(), textToDecrypt, keys);
                case EncryptionMode.CAESAR:
                    return Decrypt(new Caesar(), textToDecrypt, keys);
                case EncryptionMode.ADFGVX:
                    return Decrypt(new ADFGVX(), textToDecrypt, keys);
            }
            return textToDecrypt;
        }

        private static string Encrypt(Algorithm alg, string textToEncrypt, object[] keys)
        {
            return alg.Encrypt(textToEncrypt, keys);
        }

        private static string Decrypt(Algorithm alg, string textToEncrypt, object[] keys)
        {
            return alg.Decrypt(textToEncrypt, keys);
        }
    }
}
