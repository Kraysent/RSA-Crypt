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
        /// Converts encrypted text to machine-reading format
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string FormatEncryptedText(string text)
        {
            string outputText;
            
            outputText = "-----BEGIN RSA CRYPT ENCRYPTED MESSAGE-----\n";
            outputText += text + "\n";
            outputText += "-----END RSA CRYPT ENCRYPTED MESSAGE-----";

            return outputText;
        }
    }
}
