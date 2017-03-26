using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Encryption
{
    class OldGreek : Algorithm
    {
        public override string Encrypt(string textToEncrypt, object[] keys)
        {
            StringBuilder builder = new StringBuilder();
            Regex rgx = new Regex("[^a-zA-Z0-9]");

            textToEncrypt = textToEncrypt.ToLower();
            textToEncrypt = rgx.Replace(textToEncrypt, "");
            Console.WriteLine(textToEncrypt);

            int key = (int)keys[0];
            int pos = 0;

            List<StringBuilder> strings = new List<StringBuilder>();
            StringBuilder str = new StringBuilder();
            char[] chrs = textToEncrypt.ToCharArray();
            Array.Reverse(chrs);
            foreach (char s in chrs)
            {
                if (str.Length == key)
                {
                    strings.Add(str);
                    str = new StringBuilder();
                }
                str.Append(s);
            }
            strings.Add(str);


            while (pos <= key)
            {
                foreach (StringBuilder s in strings)
                {
                    try
                    {
                        builder.Append(s[pos]);
                    }
                    catch
                    {

                    }
                }
                pos++;
            }

            chrs = builder.ToString().ToCharArray();
            Array.Reverse(chrs);
            return new string(chrs);
        }

        public override string Decrypt(string textToDecrypt, object[] keys)
        {
            StringBuilder builder = new StringBuilder();
            Regex rgx = new Regex("[^a-zA-Z0-9]");

            textToDecrypt = textToDecrypt.ToLower();
            textToDecrypt = rgx.Replace(textToDecrypt, "");
            Console.WriteLine(textToDecrypt);
            int key = (int)keys[0];
            int decryptKey = textToDecrypt.Length % key == 0 ? textToDecrypt.Length / key : textToDecrypt.Length / key + 1;
            int pos = 0;
            List<StringBuilder> strings = new List<StringBuilder>();
            StringBuilder str = new StringBuilder();
            char[] chrs = textToDecrypt.ToCharArray();
            Array.Reverse(chrs);
            foreach (char s in chrs)
            {
                if (str.Length == decryptKey)
                {
                    strings.Add(str);
                    str = new StringBuilder();
                }
                str.Append(s);
            }
            strings.Add(str);

            while (pos <= decryptKey)
            {
                foreach (StringBuilder s in strings)
                {
                    try
                    {
                        builder.Append(s[pos]);
                    }
                    catch
                    {

                    }
                }
                pos++;
            }

            chrs = builder.ToString().ToCharArray();
            Array.Reverse(chrs);
            return new string(chrs);
        }
    }
}
