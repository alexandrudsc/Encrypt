using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Collections;

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
            throw new NotImplementedException();
        }

        public override string Decrypt(string textToDecrypt, object[] keys)
        {
            throw new NotImplementedException();
        }

        public RSA()
        {

        }

        // generate an N-bit (roughly) public and private key
        RSA(int N)
        {
            List<int> listPrimes = GeneratePrimesNaive(N);
            BigInteger p = listPrimes[random.Next(0, N - 1)];
            BigInteger q = listPrimes[random.Next(0, N - 1)];

            BigInteger phi = BigInteger.Multiply( (BigInteger.Subtract (p, one)), 
                BigInteger.Subtract(q, one));

            modulus = BigInteger.Multiply(modulus, q);
            publicKey = 65537;     // 2^16 + 1
            privateKey = BigInteger.ModPow(publicKey, 1, phi);
        }


        BigInteger encrypt(BigInteger message)
        {
            return BigInteger.ModPow(message, publicKey, modulus);
        }

        BigInteger decrypt(BigInteger encrypted)
        {
            return BigInteger.ModPow(encrypted, privateKey, modulus);
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
