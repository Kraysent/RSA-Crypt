using System.Text;
using System.Numerics;
using System.Collections.Generic;
using System.Security.Cryptography;
using RSACryptLibrary;

namespace RSACrypt.src
{
    class Options
    {
        public const char SplitChar = ' ';
        public const char KeySplitChar = '+';
        
        public static Key UserPrivateKey;
        public static Key ContactPublicKey;
        public static List<Key> UsersList = new List<Key>();
        public static List<Key> ContactsList = new List<Key>();

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
        /// Converts current key to computer-readable format
        /// </summary>
        /// <param name="key"></param>
        /// <param name="keyType"></param>
        /// <returns></returns>
        public static string[] ToFileFormat(Key key)
        {
            string[] outputArray = new string[3];
            
            outputArray[0] = "-----BEGIN RSA CRYPT " + key.Type.ToString().ToUpper() + " KEY-----";
            outputArray[1] = key.Exponent + "+" + key.Modulus;
            outputArray[2] = "-----END RSA CRYPT " + key.Type.ToString().ToUpper() + " KEY-----";

            return outputArray;
        }

        /// <summary>
        /// Gets the type of the key
        /// </summary>
        /// <param name="keyInFileForm"></param>
        /// <returns></returns>
        public static KeyType GetType(string[] keyInFileForm)
        {
            string[] checkPublicFormat = ToFileFormat(Key.SampleKey(KeyType.Public));

            if (keyInFileForm[0] == checkPublicFormat[0] && keyInFileForm[2] == checkPublicFormat[2])
            {
                return KeyType.Public;
            }
            else
            {
                return KeyType.Private;
            }
        }

        /// <summary>
        /// Converts key from file format to KEy
        /// </summary>
        /// <param name="keyInFileForm"></param>
        /// <returns></returns>
        public static Key ToKey(string[] keyInFileForm)
        {
            string[] parameters = keyInFileForm[1].Split('+');

            return new Key(BigInteger.Parse(parameters[0]), BigInteger.Parse(parameters[1]), GetType(keyInFileForm));
        }
    }
}
