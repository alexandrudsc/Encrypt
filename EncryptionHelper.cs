using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using Encryption.algorithms;

namespace Encryption
{
    class EncryptionHelper
    {
        public enum EncryptionMode
        {
            GREEK,
            CAESAR,
            PLAYFAIR,
            ADFGVX,
            HOMOPHONIC,
            ENIGMA
        }

        public static String Encrypt(String textToEncrypt, EncryptionMode enc, object[] keys)
        {
            switch (enc)
            {
                case EncryptionMode.GREEK:
                    return Encrypt(new OldGreek(), textToEncrypt, keys);
                case EncryptionMode.CAESAR:
                    return Encrypt(new Caesar(), textToEncrypt, keys);
                case EncryptionMode.PLAYFAIR:
                    return Encrypt(new Playfair(), textToEncrypt, keys);
                case EncryptionMode.ADFGVX:
                    return Encrypt(new ADFGVX(), textToEncrypt, keys);
                case EncryptionMode.HOMOPHONIC:
                    return Encrypt(new Homophonic(), textToEncrypt, keys);
                case EncryptionMode.ENIGMA:
                    return Encrypt(new Enigma(), textToEncrypt, keys);
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
                case EncryptionMode.PLAYFAIR:
                    return Decrypt(new Playfair(), textToDecrypt, keys);
                case EncryptionMode.ADFGVX:
                    return Decrypt(new ADFGVX(), textToDecrypt, keys);
                case EncryptionMode.HOMOPHONIC:
                    return Decrypt(new Homophonic(), textToDecrypt, keys);
                case EncryptionMode.ENIGMA:
                    return Decrypt(new Enigma(), textToDecrypt, keys);
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
