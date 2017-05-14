using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption.algorithms
{
    class Enigma : Algorithm
    {
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

            string originalMsg = textToEncrypt;
            string encryptedMsg = "";
            string originalMsgLetter = "";
            string encyptedLetter = "";
            string Rotation_key_string = "";
            char Original_Message_Letter_Char = ' ';
            char Encrypted_Message_Letter_Char = ' ';

            int Letter_code = 0;
            int Rotation_key_number = 0;
            int Message_Lenght = 0;
            int Counter = 0;
            Rotation_key_string = (string) keys[0];
            Rotation_key_number = int.Parse(Rotation_key_string);

            Message_Lenght = originalMsg.Length;
            Counter = 0;
            while (Counter < Message_Lenght)
            {
                originalMsgLetter = originalMsg.Substring(Counter, 1);
                Original_Message_Letter_Char = char.Parse(originalMsgLetter);

                Letter_code = Original_Message_Letter_Char;
                Letter_code = Letter_code + Rotation_key_number;

                Encrypted_Message_Letter_Char = (char)Letter_code;
                encyptedLetter = Encrypted_Message_Letter_Char.ToString();

                encryptedMsg = encryptedMsg + encyptedLetter;
                Counter = Counter + 1;
            }

            return encryptedMsg;
        }

        public override string Decrypt(string textToDecrypt, object[] keys)
        {
            MessageBox.Show("Not implemented (not requested) see Lab 6");
            return string.Empty;
        }
    }
}
