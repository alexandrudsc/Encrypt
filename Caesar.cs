using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Encryption
{
    class Caesar : Algorithm
    {
        private static readonly List<char> alphabet = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

        public override string Encrypt(string textToEncrypt, object[] keys)
        {
            StringBuilder builder = new StringBuilder();
            Regex rgx = new Regex("[^a-zA-Z0-9]");

            textToEncrypt = textToEncrypt.ToLower();
            textToEncrypt = rgx.Replace(textToEncrypt, "");
            textToEncrypt = textToEncrypt.ToUpper();
            Console.WriteLine(textToEncrypt);
            int key = (int)keys[0] - 1;
            if (key < 0)
                return builder.ToString();

            foreach (char c in textToEncrypt)
            {
                builder.Append(alphabet[(alphabet.IndexOf(c) + key) % 26]);
            }

            return builder.ToString();
        }

        public override string Decrypt(string textToEncrypt, object[] keys)
        {
            StringBuilder builder = new StringBuilder();
            Regex rgx = new Regex("[^a-zA-Z0-9]");

            textToEncrypt = textToEncrypt.ToLower();
            textToEncrypt = rgx.Replace(textToEncrypt, "");
            textToEncrypt = textToEncrypt.ToUpper();
            Console.WriteLine(textToEncrypt);
            int key = (int)keys[0] - 1;
            if (key < 0)
                return builder.ToString();


            foreach (char c in textToEncrypt)
            {
                builder.Append(alphabet[(alphabet.IndexOf(c) + (26 - key)) % 26]);
            }
            return builder.ToString();
        }
    }
}
