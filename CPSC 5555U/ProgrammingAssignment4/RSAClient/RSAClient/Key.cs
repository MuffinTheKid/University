using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace RSAClient
{
    class Key
    {
        BigInteger[] key;

        public Key(BigInteger a, BigInteger b)
        {
            key = new BigInteger[] { a, b };
        }

        public BigInteger[] returnKey()
        {
            return key;
        }
    }
}
