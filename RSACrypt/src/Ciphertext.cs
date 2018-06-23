using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace RSACrypt.src
{
    class Ciphertext
    {
        /// <summary>
        /// Encrypts unencrypted text using public Key
        /// </summary>
        /// <param name="publicKey"></param>
        /// <returns></returns>
        public static string Encrypt(string text, Key publicKey)
        {
            byte[] textByteArray = Vars.ToByteArray(text);
            string[] block = new string[100]; // biggest message
            int j = 0;
            BigInteger currentBIBlock = 0, Encrypted_Message;
            string Output_Text = "";
            Random Random_End = new Random();

            for (int i = 0; i < textByteArray.Length; i++)
            {
                block[j] += textByteArray[i] + "987";

                if (block[j].Length > publicKey.Modulus.ToString().Length - 10)
                {
                    block[j] += Random_End.Next(0, 9);
                    j++;
                }
            }

            for (int i = 0; i <= j; i++)
            {
                currentBIBlock = BigInteger.Parse(block[i]);
                Encrypted_Message = BigInteger.ModPow(currentBIBlock, publicKey.Exponent, publicKey.Modulus);
                Output_Text += Encrypted_Message.ToString() + Vars.SplitChar;
            }

            return Output_Text;
        }
    }
}
