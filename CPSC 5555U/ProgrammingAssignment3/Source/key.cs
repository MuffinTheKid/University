using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class key
    {
        #region Initializing variables
        public int[] key_array;
        public int[] k1 = new int[10];
        public int[] k2 = new int[10];
        #endregion
        public key(int[] kA)
        {
            key_array = kA;
        }

        public void generate()
        {
            int[] p_key = new int[10];
            int[] tempk1 = new int[10];
            int[] tempk2 = new int[10];
            int[] L = new int[5];
            int[] R = new int[5];
            #region Applying P10 on key
            p_key[0] = key_array[2];
            p_key[1] = key_array[4];
            p_key[2] = key_array[1];
            p_key[3] = key_array[6];
            p_key[4] = key_array[3];
            p_key[5] = key_array[9];
            p_key[6] = key_array[0];
            p_key[7] = key_array[8];
            p_key[8] = key_array[7];
            p_key[9] = key_array[5];
            #endregion
            #region Splitting key into left and right sections, called L and R
            for(int i = 0; i < p_key.Length; i++)
            {
                if( i < (p_key.Length / 2))
                {
                    L[i] = p_key[i];
                }
                else
                {
                    R[i - (p_key.Length / 2)] = p_key[i];
                }
            }
            #endregion
            int Lone = L[0];
            int Rone = R[0];
            #region LS-1 on L and R
            for(int a = 0; a < (L.Length - 1); a++)
            {
                if (a == 4)
                {
                    L[a] = Lone;
                    R[a] = Rone;
                }
                else
                {
                    L[a] = L[a + 1];
                    R[a] = R[a + 1];
                }
            }
            #endregion
            #region Combining L and R after LS-1, making tempk1
            for(int b = 0; b < tempk1.Length; b++)
            {
                if(b < (tempk1.Length/2))
                {
                    tempk1[b] = L[b];
                }
                else
                {
                    tempk1[b] = R[b - (tempk1.Length / 2)];
                }
            }
            #endregion
            #region Applying P8 to tempk1, forming K1
            k1[0] = tempk1[5];
            k1[1] = tempk1[2];
            k1[2] = tempk1[6];
            k1[3] = tempk1[3];
            k1[4] = tempk1[7];
            k1[5] = tempk1[4];
            k1[6] = tempk1[9];
            k1[7] = tempk1[8];
            #endregion
            #region Splitting tempk1 into left and right sections, called L and R
            for(int c = 0; c < tempk1.Length; c++)
            {
                if(c < (tempk1.Length/2))
                {
                    L[c] = tempk1[c];
                }
                else
                {
                    R[c - (tempk1.Length / 2)] = tempk1[c];
                }
            }
            #endregion
            #region LS-2 on on L and R
            Lone = L[0];
            int Ltwo = L[1];
            Rone = R[0];
            int Rtwo = R[1];
            for(int d = 0; d < L.Length; d++)
            {
                if( d >= 3 )
                {
                    if(d == 4)
                    {
                        L[d] = Ltwo;
                        R[d] = Rtwo;
                    }
                    L[d] = Lone;
                    R[d] = Rone;
                }
                else
                {
                    L[d] = L[d];
                    R[d] = R[d];
                }
            }
            #endregion
            #region Combining L and R after LS-2, making tempk2
            for(int e = 0; e < tempk2.Length; e++)
            {
                if(e < (tempk2.Length/2))
                {
                    tempk2[e] = L[e];
                }
                else
                {
                    tempk2[e] = R[e - (tempk2.Length / 2)];
                }
            }
            #endregion
            #region Applying P8 to tempk2, forming K2
            k2[0] = tempk2[5];
            k2[1] = tempk2[2];
            k2[2] = tempk2[6];
            k2[3] = tempk2[3];
            k2[4] = tempk2[7];
            k2[5] = tempk2[4];
            k2[6] = tempk2[9];
            k2[7] = tempk2[8];
            #endregion
        }

        public int[] returnk1()
        {
            return k1;
        }
        public int[] returnk2()
        {
            return k2;
        }

    }
}

