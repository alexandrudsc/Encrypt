using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    abstract class Algorithm
    {
        public abstract string Encrypt(string textToEncrypt, object[] keys);

        public abstract string Decrypt(string textToDecrypt, object[] keys);

    }
}
