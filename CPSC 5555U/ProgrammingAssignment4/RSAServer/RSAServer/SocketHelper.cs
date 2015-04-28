using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using System.Numerics;

namespace RSAServer
{
    class SocketHelper
    {
        TcpClient mscClient;
        string message;
        string beginMessage;
        byte[] bytesSent;
        BigInteger[][] keys = keyGen();
        public string processMsg(TcpClient client, NetworkStream stream, byte[] bytesReceived)
        {
            string report = "blank";
            /*************************************************************
             * Reads message sent by client then processes the message   *
             * accordingly. If a response is needed, then an appropriate *
             * response is sent.                                         *
             *************************************************************/
            #region Message processing
            message = Encoding.ASCII.GetString(bytesReceived, 0, bytesReceived.Length);
            mscClient = client;
            beginMessage = message.Substring(0, 5);
            /*************************************************************
             * Checks what the beginning of the message. If it is "hello"*
             * ,then the server will send back "ready" to let the client *
             * know that it will be sending over the server's Public     *
             * Key. If the beginning doesn't equal "hello", then the     *
             * server will try to decrypt the bytesReceived. If it is    *
             * successful, then the message is return in report. Else,   *
             * the error is caught, formatted, then returned in report.  *
             *************************************************************/
            if(beginMessage.Equals("hello"))
            {
                bytesSent = Encoding.ASCII.GetBytes("ready");
                stream.Write(bytesSent, 0, bytesSent.Length);
                BigInteger[] PU = keys[0];
                foreach(BigInteger part in PU)
                {
                    Thread.Sleep(5);
                    bytesSent = part.ToByteArray();
                    stream.Write(bytesSent, 0, bytesSent.Length);
                }
                report = "Public key sent to client..." + "\r\n";
            }
            else
            {
                try
                {
                    BigInteger cipher = new BigInteger(bytesReceived);
                    string mess = this.decrypt(cipher, keys[1]);
                    //string mess = cipher.ToString();
                    report = mess;
                }
                catch(Exception e)
                {
                    //reporting any caught errors
                    report += "Error Caught::" + "\r\n" + "########################" + "\r\n" 
                        + e.ToString() + "\r\n" + "########################" + "\r\n";
                }
            }
            #endregion
            return report;
        }

        #region Decrypting the Ciphertext
        public String decrypt(BigInteger cipher, BigInteger[] key)
        {
            string message = "Cipher: " + cipher.ToString() + "\r\n";
            BigInteger M = BigInteger.ModPow(cipher, key[0], key[1]);
            message += "Decrypted cipher: " + M.ToString() + "\r\n";
            Byte[] Mbytes = M.ToByteArray();
            message += "String hidden in cipher: " + System.Text.Encoding.ASCII.GetString(Mbytes);
            //string message = M.ToString();
            return message;
        }
        #endregion

        #region Generate the Public and Private key of the server
        public static BigInteger[][] keyGen()
        {
            Random rand = new Random();
            BigInteger p = new BigInteger(probablePrime(9999999));
            BigInteger q = new BigInteger(probablePrime(9999999));
            while (true)
            {
                if (!BigInteger.Equals(p, q))
                {
                    break;
                }
                else
                {
                    p = new BigInteger(probablePrime(9999999));
                    q = new BigInteger(probablePrime(9999999));
                }
            }

            BigInteger n = BigInteger.Multiply(p, q);
            BigInteger phi = (BigInteger.Multiply((BigInteger.Subtract(p, BigInteger.One)), (BigInteger.Subtract(q, BigInteger.One))));
            BigInteger e = new BigInteger(rand.Next(99999999));
            BigInteger d = new BigInteger();
            while (true)
            {
                if (e < phi)
                {
                    if (BigInteger.Equals(BigInteger.GreatestCommonDivisor(e, phi), BigInteger.One))
                    {
                        d = inverse(e, phi);
                        if (!d.Equals(BigInteger.Zero))
                        {
                            break;
                        }
                    }
                }
                e = new BigInteger(rand.Next(99999999));
            } 
            BigInteger[] Pu = { e, n };
            BigInteger[] Pr = { d, n };
            BigInteger[][] keys = { Pu, Pr };
            return keys;
        }
        #endregion

        #region Generate a Prime number
        public static double probablePrime(int limit)
        {
            Random r = new Random();
            while (true)
            {
                double n = r.Next(2,limit);
                if (IsPrime(n))//calls the Wikipedia Primality test to check and see if random number is prime
                {
                    return n;
                }
            }
        }
        #endregion

        #region Primality Test from Wikipedia, url@http://en.wikipedia.org/wiki/Primality_test
        public static bool IsPrime(double n)
        {
            if (n <= 3)
            {
                return n > 1;
            }
            else if (n % 2 == 0 || n % 3 == 0)
            {
                return false;
            }
            for (ulong i = 5; i * i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region Inverse Modulo function derived from the psuedocode available @http://en.wikipedia.org/wiki/Extended_Euclidean_algorithm#Modular_integers
        public static BigInteger inverse(BigInteger a, BigInteger b)
        {
            BigInteger r = b;
            BigInteger new_r = a;
            BigInteger quotient = new BigInteger();
            BigInteger t = new BigInteger(0);
            BigInteger new_t = new BigInteger(1);
            BigInteger temp = new BigInteger();
            while (new_r != BigInteger.Zero)
            {
                quotient = BigInteger.Divide(r, new_r);
                temp = new_t;
                new_t = BigInteger.Subtract(t, BigInteger.Multiply(quotient, new_t));
                t = temp;
                temp = new_r;
                new_r = BigInteger.Subtract(r, BigInteger.Multiply(quotient, new_r));
                r = temp;
            }

            if(r > 1)
            {
                t = BigInteger.Zero;
                return t;
            }
            if( t < 0)
            {
                t = BigInteger.Add(t, b);
            }
            return t;
        }
        #endregion
    }
}
