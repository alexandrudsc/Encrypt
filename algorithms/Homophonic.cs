using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Encryption.algorithms
{
    class Homophonic : Algorithm
    {
        private static readonly Dictionary<char, List<string>> map = new Dictionary<char, List<string>>()
        {
            { 'E', new List<string>() { "00", "06", "13", "32", "52", "53", "71", "72", "83", "93", "94" } },
            { 'T', new List<string>() { "14", "16", "30", "31", "43", "58", "73", "79", "84" } },
            { 'O', new List<string>() { "11", "15", "25", "41", "42", "57", "78", "85" } },
            { 'I', new List<string>() { "03", "10", "34", "35", "54", "56", "77", "86" } },
            { 'A', new List<string>() { "18", "19", "20", "36", "55", "62", "76", "87" } },
            { 'N', new List<string>() { "02", "37", "38", "59", "61", "69", "70" } },
            { 'R', new List<string>() { "09", "26", "39", "60", "75", "88" } },
            { 'H', new List<string>() { "17", "28", "63", "74", "89" } },
            { 'L', new List<string>() { "04", "08", "27", "64" } },
            { 'D', new List<string>() { "05", "29", "66" } },
            { 'U', new List<string>() { "07", "22", "91" } },
            { 'C', new List<string>() { "23", "44", "92" } },
            { 'M', new List<string>() { "33", "51", "80" } },
            { 'P', new List<string>() { "12", "50" } },
            { 'Y', new List<string>() { "49", "68" } },
            { 'F', new List<string>() { "24", "45" } },
            { 'G', new List<string>() { "01", "96" } },
            { 'W', new List<string>() { "81", "98" } },
            { 'B', new List<string>() { "48", "97" } },
            { 'V', new List<string>() { "99" } },
            { 'K', new List<string>() { "67" } },
            { 'X', new List<string>() { "47" } },
            { 'J', new List<string>() { "95" } },
            { 'Q', new List<string>() { "90" } },
            { 'Z', new List<string>() { "46" } }
        };

        public override string Encrypt(string textToEncrypt, object[] keys)
        {
            if (textToEncrypt == null || textToEncrypt.Length == 0)
                return "";

            StringBuilder builder = new StringBuilder();
            Regex rgx = new Regex("[^a-zA-Z0-9]");

            textToEncrypt = textToEncrypt.ToLower();
            textToEncrypt = rgx.Replace(textToEncrypt, "");
            textToEncrypt = textToEncrypt.ToUpper();
            Console.WriteLine(textToEncrypt);

            foreach (char c in textToEncrypt)
            {
                List<string> posibilities = map[c];
                Random r = new Random();
                builder.Append( posibilities[r.Next(0, posibilities.Count - 1)]);
            }

            return builder.ToString();
        }

        public override string Decrypt(string textToDecrypt, object[] keys)
        {
            if (textToDecrypt == null || textToDecrypt.Length == 0)
                return "";

            StringBuilder builder = new StringBuilder();
            Regex rgx = new Regex("[^a-zA-Z0-9]");

            textToDecrypt = textToDecrypt.ToLower();
            textToDecrypt = rgx.Replace(textToDecrypt, "");
            textToDecrypt = textToDecrypt.ToUpper();
            Console.WriteLine(textToDecrypt);

            for (int i = 0; i < textToDecrypt.Length - 1; i += 2)
            {
                String encryptedChar = textToDecrypt[i] + "" + textToDecrypt[i + 1];
                foreach ( KeyValuePair<char, List<string>> entry in map)
                {
                    if (entry.Value.Contains(encryptedChar))
                    {
                        builder.Append(entry.Key);
                        break;
                    }
                }
            }

            return builder.ToString();
        }


    }
}
