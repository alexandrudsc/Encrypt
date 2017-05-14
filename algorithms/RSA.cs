using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Collections;
using System.Text.RegularExpressions;

namespace Encryption.algorithms
{
    class RSA : Algorithm
    {
        private static BigInteger one = 1;
        private static Random random = new Random();

        private BigInteger privateKey;
        private BigInteger publicKey;
        private BigInteger modulus;

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

            int key;
            try
            {
                int.TryParse((string)keys[0], out key);
            }
            catch (Exception ex)
            {
                return string.Empty;
            }

            init(key);

            StringBuilder sb = new StringBuilder();
            foreach (char c in textToEncrypt)
                sb.Append(DoEncrypt(c));

            return sb.ToString();
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

            int key;
            try
            {
                int.TryParse((string)keys[0], out key);
            }
            catch (Exception ex)
            {
                return string.Empty;
            }

            init(key);

            StringBuilder sb = new StringBuilder();
            foreach (char c in textToDecrypt)
                sb.Append((int)DoEncrypt(c));

            return sb.ToString();
        }

        public RSA()
        {

        }

        // generate an N-bit (roughly) public and private key
        public void init(int N)
        {
            List<int> listPrimes = GeneratePrimesNaive(N);
            BigInteger p = listPrimes[random.Next(0, N - 1)];
            BigInteger q = listPrimes[random.Next(0, N - 1)];

            BigInteger phi = BigInteger.Multiply( (BigInteger.Subtract (p, one)), 
                BigInteger.Subtract(q, one));

            modulus = BigInteger.Multiply(p, q);
            publicKey = 65537;     // 2^16 + 1
            privateKey = BigInteger.ModPow(publicKey, 1, phi);
        }

        private char DoEncrypt(BigInteger message)
        {
            return (char)BigInteger.ModPow(message, publicKey, modulus);
        }

        private char DoDecrypt(BigInteger encryptedMessage)
        {
            return (char)BigInteger.ModPow(encryptedMessage, privateKey, modulus);
        }

        private static List<int> GeneratePrimesNaive(int n)
        {
            List<int> primes = new List<int>();
            primes.Add(2);
            int nextPrime = 3;
            while (primes.Count < n)
            {
                int sqrt = (int)Math.Sqrt(nextPrime);
                bool isPrime = true;
                for (int i = 0; (int)primes[i] <= sqrt; i++)
                {
                    if (nextPrime % primes[i] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primes.Add(nextPrime);
                }
                nextPrime += 2;
            }
            return primes;
        }

    }
}
