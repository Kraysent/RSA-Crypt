using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text;
using System.Security.Cryptography;

namespace RSACrypt.src
{
    class Vars
    {
        public const char SplitChar = ' ';
        public const char KeySplitChar = '+';

        public static Key ContactPublicKey;
        public static Key UserPrivateKey;

        /// <summary>
        /// Converts text to byte array
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static byte[] ToByteArray(string text)
        {
            return Encoding.Unicode.GetBytes(text);
        }

        /// <summary>
        /// Computes SHA512 hash from input text
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static byte[] ComputeHash(string text)
        {
            return (new SHA512Managed()).ComputeHash(ToByteArray(text));
        }

        /// <summary>
        /// Computes SHA512 hash from input byte array
        /// </summary>
        /// <param name="byteArray"></param>
        /// <returns></returns>
        public static byte[] ComputeHash(byte[] byteArray)
        {
            return (new SHA512Managed()).ComputeHash(byteArray);
        }
        
        /// <summary>
        /// Pauses program for selected number of ms
        /// </summary>
        /// <param name="value"></param>
        public static void Pause(int value)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (sw.ElapsedMilliseconds < value)
                Application.DoEvents();
        }
    }
}
