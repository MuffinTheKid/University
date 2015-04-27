using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public enum MODE { ENCRYPT, DECRYPT }
    class Program
    {
        
        static void Main(string[] args)
        {
            #region Initializing Variables
            string plaintext = "";
            string ciphertext = "";
            string cip_filename = "cipher.txt";
            string pla_filename = "plain.txt";
            string key = "";
            char[] key_char;
            int[] key_array;
            char[] plaintext_char = new char[8];
            int[] plaintext_array = new int[8];
            char[] ciphertext_char = new char[8];
            int[] ciphertext_array = new int[8];
            int[] nonce;
            int[] eXOR_array;
            int[] dXOR_array;
            string plain_path = "";
            string cipher_path = "";
            string key_path = "";
            string mode_code = "";
            MODE mode = new MODE { };
            encryptor encrypto_kun;
            decryptor decrypto_san;
            key key_chan;
            string[] input;
            #endregion
            #region Generating nonce
            nonce = new int[8];
            for (int i = 0; i < nonce.Length; i++)
            {
                Random rand = new Random();
                int x = rand.Next(0, 2);
                nonce[i] = x;
            }
            #endregion

            while (true)
            {
                Console.Out.WriteLine("Please enter the mode, and the necessary files in the following fashion:");
                Console.Out.WriteLine("------------------------------------------------------------------------");
                Console.Out.WriteLine("-mode plain(or cipher).txt key.txt");
                string inpt = Console.ReadLine();
                input = inpt.Split(' ');
                #region Pulling out what mode to operate in and the plain and key file pathways
                foreach (string s in input)
                {
                    String line = s;
                    switch (line)
                    {
                        case "-e":
                            mode_code = line;
                            break;
                        case "-d":
                            mode_code = line;
                            break;
                        case "plain.txt":
                            plain_path = Path.GetFullPath(line);
                            break;
                        case "cipher.txt":
                            cipher_path = Path.GetFullPath(line);
                            break;
                        case "key.txt":
                            key_path = Path.GetFullPath(line);
                            break;
                    }
                }
                #endregion
            
                #region Putting key into an array
                try
                {
                    using (StreamReader str = File.OpenText(key_path))
                    {
                        key = str.ReadToEnd();
                    }
                }
                catch (Exception e)
                {
                    Console.Out.Write(e);
                    Environment.Exit(0);
                }

                key_char = key.ToArray();
                key_array = new int[key_char.Length];
                for (int i = 0; i < key_char.Length; i++)
                {
                    key_array[i] = Convert.ToInt16(key_char[i]);
                }
                #endregion
                
                #region Determining whether to encrypt or decrypt
                switch (mode_code)
                {
                    case "-e":
                        mode = MODE.ENCRYPT;
                        break;
                    case "-d":
                        mode = MODE.DECRYPT;
                        break;
                }
                #endregion
                switch (mode)
                {

                    case MODE.ENCRYPT:
                        eXOR_array = nonce;
                        key_chan = new key(key_array);
                        key_chan.generate();
                        #region Acquiring Plaintext and encrypting it every 8 bit
                        FileInfo fi = new FileInfo(plain_path);
                        using (StreamReader str = File.OpenText(plain_path))
                        {
                            int i = 0;
                            while (i < fi.Length)
                            {
                                #region Converting plaintext_char to plaintext_array
                                str.ReadBlock(plaintext_char, i, 7);
                                for (int x = 0; x < plaintext_char.Length; x++)
                                {
                                    plaintext_array[i] = Convert.ToInt16(plaintext_char[i]);
                                }
                                #endregion
                                #region Encrypting plaintext, then adding it to the ciphertext string
                                encrypto_kun = new encryptor(eXOR_array, key_chan.returnk1(), key_chan.returnk2());
                                ciphertext_array = encrypto_kun.encrypt();
                                #region XORing ciphertext_array with plaintext_array
                                for (int y = 0; y < plaintext_array.Length; y++)
                                {
                                    if (ciphertext_array[y] != plaintext_array[y])
                                    {
                                        ciphertext_array[y] = 1;
                                    }
                                    else
                                    {
                                        ciphertext_array[y] = 0;
                                    }
                                }
                                #endregion
                                #region Building ciphertext file
                                for (int w = 0; w < ciphertext_array.Length; w++)
                                {
                                    ciphertext += ciphertext_array[w].ToString();
                                }
                                #endregion
                                i += 8;
                                eXOR_array = ciphertext_array;
                            }
                        }
                        #endregion
                        File.AppendAllText(cip_filename, ciphertext);
                        #endregion
                        break;
                    case MODE.DECRYPT:
                        dXOR_array = nonce;
                        key_chan = new key(key_array);
                        key_chan.generate();
                        #region Acquiring Ciphertext and decrypting it every 8 bit
                        fi = new FileInfo(cipher_path);
                        using (StreamReader str = File.OpenText(cipher_path))
                        {
                            int i = 0;
                            while (i < fi.Length)
                            {
                                #region Converting ciphertext_char to ciphertext_array
                                str.ReadBlock(ciphertext_char, i, 7);
                                for (int x = 0; x < ciphertext_char.Length; x++)
                                {
                                    ciphertext_array[i] = Convert.ToInt16(ciphertext_char[i]);
                                }
                                #endregion
                                #region Decrypting ciphertext, then adding it to the plaintext string
                                decrypto_san = new decryptor(dXOR_array, key_chan.returnk1(), key_chan.returnk2());
                                ciphertext_array = decrypto_san.decrypt();
                                #region XORing ciphertext_array with plaintext_array
                                for (int y = 0; y < ciphertext_array.Length; y++)
                                {
                                    if (plaintext_array[y] != ciphertext_array[y])
                                    {
                                        plaintext_array[y] = 1;
                                    }
                                    else
                                    {
                                        plaintext_array[y] = 0;
                                    }
                                }
                                #endregion
                                #region Building plaintext file
                                for (int w = 0; w < plaintext_array.Length; w++)
                                {
                                    plaintext += plaintext_array[w].ToString();
                                }
                                #endregion
                                i += 8;
                                dXOR_array = ciphertext_array;
                            }
                        }
                        #endregion
                        File.AppendAllText(pla_filename, plaintext);
                        #endregion
                        break;
                }
            }
            
        }
    }
            
}
