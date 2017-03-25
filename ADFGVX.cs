using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Encryption
{
    class ADFGVX : Algorithm
    { 
        private static readonly string TEXT = "ADFGVX";
        private static readonly string ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

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

            string key1 = (string)keys[0];
            key1 = String.Join("", key1.Distinct());
            key1 = key1.ToUpper();

            string key2 = (string)keys[1];
            key2 = String.Join("", key2.Distinct());
            key2 = key2.ToUpper();

            char[,] mSubs = CreateSubstitutionMatrix(key1);
            foreach (char c  in textToEncrypt)
            {
                builder.Append(DoSubstitution(mSubs, c));
            }
            Dictionary<char, List<Char>> mTrans = CreateTransposedMatrix(builder, key2);

            builder.Clear();
            foreach(char c in ALPHABET)
            {
                if (mTrans.ContainsKey(c))
                    foreach (char encryptedChar in mTrans[c])
                    {
                        builder.Append(encryptedChar);
                    }
            }
            return builder.ToString();
        }

        public override string  Decrypt(string textToDecrypt, object[] keys)
        {
            if (textToDecrypt == null || textToDecrypt.Length == 0)
                return "";

            StringBuilder builder = new StringBuilder();
            Regex rgx = new Regex("[^a-zA-Z0-9]");

            textToDecrypt = textToDecrypt.ToLower();
            textToDecrypt = rgx.Replace(textToDecrypt, "");
            textToDecrypt = textToDecrypt.ToUpper();
            Console.WriteLine(textToDecrypt);

            string key1 = (string)keys[0];
            key1 = String.Join("", key1.Distinct());
            key1 = key1.ToUpper();

            string key2 = (string)keys[1];
            key2 = String.Join("", key2.Distinct());
            key2 = key2.ToUpper();

            char[,] mSubs = CreateSubstitutionMatrix(key1);


            return builder.ToString();
        }


        //===========================================================================================
        // helper functions
        private static char[,] CreateSubstitutionMatrix(string key)
        {
            List<char> alphabet = new List<char>();
            char[,] mSubs = new char[7, 7];

            for (int i = 0; i < ALPHABET.Length; i++)
                alphabet.Add(ALPHABET[i]);

            mSubs[0,0] = ' ';
            for (int i = 0; i < 6; i++)
                mSubs[0, i + 1] = TEXT[i];

            for (int i = 0; i < 6; i++)
                mSubs[i + 1, 0] = TEXT[i];

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                    if (i * 7 + j < key.Length)
                    {
                        mSubs[i + 1, j + 1] = key[i * 7 + j];
                        alphabet.Remove(key[i * 7 + j]);
                    }
                    else
                    {
                        mSubs[i + 1, j + 1] = alphabet[0];
                        alphabet.RemoveAt(0);
                    }
            }
            return mSubs;
        }

        private static string DoSubstitution(char [,] mSubs, char c)
        {
            for (int i = 1; i < mSubs.GetLength(0); i++)
                for (int j = 1; j < mSubs.GetLength(0); j++)
                    if (mSubs[i, j] == c)
                        return mSubs[i, 0] +  "" + mSubs[0, j];
            return c + "";
        }

        private Dictionary<char, List<Char> > CreateTransposedMatrix(StringBuilder sb, string key2)
        {
            Dictionary<char, List<Char> > mTrans = new Dictionary<char, List<Char> > ();
            int column = 0;

            foreach (char c in key2)
                mTrans.Add(c, new List<Char>());

           foreach (char c in sb.ToString())
            {
                if (column >= key2.Length)
                    column = 0;
                mTrans[key2[column]].Add(c);
                column++;
            }
        
            return mTrans;
        }
        //===========================================================================================
    }
}
