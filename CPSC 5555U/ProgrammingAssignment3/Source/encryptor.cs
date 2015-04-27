using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class encryptor
    {
        #region initializing variables
        public int[] plaintext { get; }
        public int[] k1 { get; }
        public int[] k2 { get; }
        public int[] ciphertext;

        public int[,] S0 = new int[4, 4] { { 1, 0, 3, 2 },
                                           { 3, 2, 1, 0 },
                                           { 0, 2, 1, 3 },
                                           { 3, 1, 3, 2 } };

        public int[,] S1 = new int[4, 4] { { 0, 1, 2, 3 },
                                           { 2, 0, 1, 3 },
                                           { 3, 0, 1, 0 },
                                           { 2, 1, 0, 3 } };
        #endregion
        public encryptor(int[] pt, int[] tempk1, int[] tempk2)
        {
            plaintext = pt;
            k1 = tempk1;
            k2 = tempk2;
        }

        public int[] encrypt()
        {
            int[] tempPt = new int[plaintext.Length];
            #region Initial Permutation
            tempPt[0] = plaintext[1];
            tempPt[1] = plaintext[5];
            tempPt[2] = plaintext[2];
            tempPt[3] = plaintext[0];
            tempPt[4] = plaintext[3];
            tempPt[5] = plaintext[7];
            tempPt[6] = plaintext[4];
            tempPt[7] = plaintext[6];
            #endregion
            int[] L = new int[plaintext.Length / 2];
            int[] R = new int[plaintext.Length / 2];
            int[] eR = new int[tempPt.Length];
            #region Dividing IP into L and R
            for(int a = 0; a < tempPt.Length; a++)
            {
                if(a < (tempPt.Length/2))
                {
                    L[a] = tempPt[a];
                }
                else
                {
                    R[a - (tempPt.Length / 2)] = tempPt[a];
                }
            }
            #endregion
            #region Applying E/P onto R
            eR[0] = R[3];
            eR[1] = R[0];
            eR[2] = R[1];
            eR[3] = R[2];
            eR[4] = R[1];
            eR[5] = R[2];
            eR[6] = R[3];
            eR[7] = R[0];
            #endregion
            #region K1 XOR R
            for(int b = 0; b < eR.Length; b++)
            {
                if(eR[b] != k1[b])
                {
                    eR[b] = 1;
                }
                else
                {
                    eR[b] = 0;
                }
            }
            #endregion
            int[] otptA = new int[eR.Length / 2];
            int[] otptB = new int[eR.Length / 2];
            #region Splitting XOR'd R into left and right sections, called otptA and otptB
            for(int c = 0; c < eR.Length; c++)
            {
                if(c < (eR.Length/2))
                {
                    otptA[c] = eR[c];
                }
                else
                {
                    otptB[c - (eR.Length / 2)] = eR[c];
                }
            }
            #endregion
            int S0_X;
            #region If statements to determine S0 row number
            if (otptA[0] == 1 && otptA[3] == 0)
            {
                S0_X = 2;
            }
            else if (otptA[0] == 0 && otptA[3] == 1)
            {
                S0_X = 1;
            }
            else if (otptA[0] == 1 && otptA[3] == 1)
            {
                S0_X = 3;
            }
            else
            {
                S0_X = 0;
            } 
            #endregion
            int S0_Y;
            #region If statements to determine S0 column number
            if (otptA[1] == 1 && otptA[2] == 0)
            {
                S0_Y= 2;
            }
            else if (otptA[1] == 0 && otptA[2] == 1)
            {
                S0_Y = 1;
            }
            else if (otptA[1] == 1 && otptA[2] == 1)
            {
                S0_Y = 3;
            }
            else
            {
                S0_Y = 0;
            }
            #endregion
            int S1_X;
            #region If statements to determine S1 row number
            if (otptB[0] == 1 && otptB[3] == 0)
            {
                S1_X = 2;
            }
            else if (otptB[0] == 0 && otptB[3] == 1)
            {
                S1_X = 1;
            }
            else if (otptB[0] == 1 && otptB[3] == 1)
            {
                S1_X = 3;
            }
            else
            {
                S1_X = 0;
            }
            #endregion
            int S1_Y;
            #region If statements to determine S1 column number
            if (otptB[0] == 1 && otptB[3] == 0)
            {
                S1_Y = 2;
            }
            else if (otptB[0] == 0 && otptB[3] == 1)
            {
                S1_Y = 1;
            }
            else if (otptB[0] == 1 && otptB[3] == 1)
            {
                S1_Y = 3;
            }
            else
            {
                S1_Y = 0;
            }
            #endregion
            int S0_O = S0[S0_X,S0_Y];
            int S1_O = S1[S1_X,S1_Y];
            int[] output = new int[4];
            #region Determinnig what the S0 & S1 outputs equal and setting the appropriate indexes in output
            switch(S0_O)
            {
                case 0:
                    output[0] = 0;
                    output[1] = 0;
                    break;
                case 1:
                    output[0] = 0;
                    output[1] = 1;
                    break;
                case 2:
                    output[0] = 1;
                    output[1] = 0;
                    break;
                case 3:
                    output[0] = 1;
                    output[1] = 1;
                    break;
            }
            switch (S1_O)
            {
                case 0:
                    output[2] = 0;
                    output[3] = 0;
                    break;
                case 1:
                    output[2] = 0;
                    output[3] = 1;
                    break;
                case 2:
                    output[2] = 1;
                    output[3] = 0;
                    break;
                case 3:
                    output[2] = 1;
                    output[3] = 1;
                    break;
            }
            #endregion
            int[] f_output = new int[4];
            #region Applying P4 on output
            f_output[0] = output[1];
            f_output[1] = output[3];
            f_output[2] = output[2];
            f_output[3] = output[0];
            #endregion
            #region XORing L and f_output
            for(int i = 0; i < f_output.Length; i++)
            {
                if(L[i] != f_output[i])
                {
                    L[i] = 1;
                }
                else
                {
                    L[i] = 0;
                }
            }
            #endregion
            #region Switching L and R
            int[] temp = L;
            L = R;
            R = temp;
            #endregion
            #region Applying E/P onto R
            eR[0] = R[3];
            eR[1] = R[0];
            eR[2] = R[1];
            eR[3] = R[2];
            eR[4] = R[1];
            eR[5] = R[2];
            eR[6] = R[3];
            eR[7] = R[0];
            #endregion
            #region K2 XOR R
            for (int b = 0; b < eR.Length; b++)
            {
                if (eR[b] != k2[b])
                {
                    eR[b] = 1;
                }
                else
                {
                    eR[b] = 0;
                }
            }
            #endregion
            #region Splitting XOR'd R into left and right sections, called otptA and otptB
            for (int c = 0; c < eR.Length; c++)
            {
                if (c < (eR.Length / 2))
                {
                    otptA[c] = eR[c];
                }
                else
                {
                    otptB[c - (eR.Length / 2)] = eR[c];
                }
            }
            #endregion
            #region If statements to determine S0 row number
            if (otptA[0] == 1 && otptA[3] == 0)
            {
                S0_X = 2;
            }
            else if (otptA[0] == 0 && otptA[3] == 1)
            {
                S0_X = 1;
            }
            else if (otptA[0] == 1 && otptA[3] == 1)
            {
                S0_X = 3;
            }
            else
            {
                S0_X = 0;
            }
            #endregion
            #region If statements to determine S0 column number
            if (otptA[1] == 1 && otptA[2] == 0)
            {
                S0_Y = 2;
            }
            else if (otptA[1] == 0 && otptA[2] == 1)
            {
                S0_Y = 1;
            }
            else if (otptA[1] == 1 && otptA[2] == 1)
            {
                S0_Y = 3;
            }
            else
            {
                S0_Y = 0;
            }
            #endregion
            #region If statements to determine S1 row number
            if (otptB[0] == 1 && otptB[3] == 0)
            {
                S1_X = 2;
            }
            else if (otptB[0] == 0 && otptB[3] == 1)
            {
                S1_X = 1;
            }
            else if (otptB[0] == 1 && otptB[3] == 1)
            {
                S1_X = 3;
            }
            else
            {
                S1_X = 0;
            }
            #endregion
            #region If statements to determine S1 column number
            if (otptB[0] == 1 && otptB[3] == 0)
            {
                S1_Y = 2;
            }
            else if (otptB[0] == 0 && otptB[3] == 1)
            {
                S1_Y = 1;
            }
            else if (otptB[0] == 1 && otptB[3] == 1)
            {
                S1_Y = 3;
            }
            else
            {
                S1_Y = 0;
            }
            #endregion
            S0_O = S0[S0_X, S0_Y];
            S1_O = S1[S1_X, S1_Y];
            #region Determinnig what the S0 & S1 outputs equal and setting the appropriate indexes in output
            switch (S0_O)
            {
                case 0:
                    output[0] = 0;
                    output[1] = 0;
                    break;
                case 1:
                    output[0] = 0;
                    output[1] = 1;
                    break;
                case 2:
                    output[0] = 1;
                    output[1] = 0;
                    break;
                case 3:
                    output[0] = 1;
                    output[1] = 1;
                    break;
            }
            switch (S1_O)
            {
                case 0:
                    output[2] = 0;
                    output[3] = 0;
                    break;
                case 1:
                    output[2] = 0;
                    output[3] = 1;
                    break;
                case 2:
                    output[2] = 1;
                    output[3] = 0;
                    break;
                case 3:
                    output[2] = 1;
                    output[3] = 1;
                    break;
            }
            #endregion
            #region Applying P4 on output
            f_output[0] = output[1];
            f_output[1] = output[3];
            f_output[2] = output[2];
            f_output[3] = output[0];
            #endregion
            #region XORing L and f_output
            for (int i = 0; i < f_output.Length; i++)
            {
                if (L[i] != f_output[i])
                {
                    L[i] = 1;
                }
                else
                {
                    L[i] = 0;
                }
            }
            #endregion
            ciphertext = new int[plaintext.Length];
            int[] temp_cipher = new int[plaintext.Length];
            #region Combining L and R
            for(int i = 0; i < ciphertext.Length; i++)
            {
                if(i < (ciphertext.Length/2))
                {
                    temp_cipher[i] = L[i];
                }
                else
                {
                    temp_cipher[i] = R[i - (ciphertext.Length / 2)];
                }
            }
            #endregion
            #region Applying IP^-1 onto temp_cipher to finalize ciphertext
            ciphertext[0] = temp_cipher[3];
            ciphertext[1] = temp_cipher[0];
            ciphertext[2] = temp_cipher[2];
            ciphertext[3] = temp_cipher[4];
            ciphertext[4] = temp_cipher[6];
            ciphertext[5] = temp_cipher[1];
            ciphertext[6] = temp_cipher[7];
            ciphertext[7] = temp_cipher[5];
            #endregion
            return ciphertext;
        }
    }
}
