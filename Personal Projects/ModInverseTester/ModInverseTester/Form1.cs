using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Numerics;

namespace ModInverseTester
{
    public partial class ModInverseTester : Form
    {
        public ModInverseTester()
        {
            InitializeComponent();
        }

        private void beginModInverseTest_Click(object sender, EventArgs e)
        {
            BigInteger a = new BigInteger(probablePrime());
            BigInteger b = new BigInteger(probablePrime());
            while(true)
            {
                if(!a.Equals(b))
                {
                    break;
                }
                a = new BigInteger(probablePrime());
                b = new BigInteger(probablePrime());
            }
            BigInteger c = inverse(a,b);
            if (c.Equals(BigInteger.Zero))
            {
                infoBox.Text += c.ToString() + " is not an inverse of " + a.ToString() + " when mod by " + b.ToString() + "\r\n" +
                    "##############################" + "\r\n";
            }
            else
            {
                infoBox.Text += c.ToString() + " is an inverse of " + a.ToString() + " when mod by " + b.ToString() + "\r\n" + 
                    "##############################" + "\r\n";
            }

        }

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

            if (r > 1)
            {
                t = BigInteger.Zero;
                return t;
            }
            if (t < 0)
            {
                t = BigInteger.Add(t, b);
            }
            return t;
        }
        #endregion

        #region Probable Prime method
        private double probablePrime()
        {
            Random rand = new Random();
            double n = 0;
            while (true)
            {
                n = rand.Next(0,9999);
                if (IsPrime(n))
                {
                    infoBox.Text += n + " is prime." + "\r\n";
                    break;
                }
                else
                {
                    infoBox.Text += n + " is not prime." + "\r\n";
                }
            }
            return n;
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
    }
}
