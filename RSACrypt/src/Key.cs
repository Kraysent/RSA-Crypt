using System;
using System.Windows.Forms;
using System.Numerics;

namespace RSACrypt.src
{
    class Key
    {
        public BigInteger Exponent;
        public BigInteger Modulus;
        public string KeyType;
        public string Username;
        public byte[] PasswordHash;

        /// <summary>
        /// Initialises new Key element
        /// </summary>
        /// <param name="exponent"></param>
        /// <param name="modulus"></param>
        /// <param name="keyType">Can only be "pub" or "priv"</param>
        /// <param name="username"></param>
        /// <param name="passwordHash"></param>
        public Key(BigInteger exponent, BigInteger modulus, string keyType, string username, byte[] passwordHash)
        {
            Exponent = exponent;
            Modulus = modulus;
            KeyType = keyType;
            Username = username;
            PasswordHash = passwordHash;
        }

        /// <summary>
        /// Generates a new pair of Keys. Key[0] is public, Key[1] is private
        /// </summary>
        /// <returns></returns>
        public Key[] GeneratePair(string username, string password, int keysLength)
        {
            byte[] passwordHash = Vars.ComputeHash(password);
            
            return null;
        }

        /// <summary>
        /// Gets random number
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        private BigInteger RandomNumber(int length)
        {
            DateTime currentTime = DateTime.Now;
            int cursorX = Cursor.Position.X, cursorY = Cursor.Position.Y, i, currentRnd, currentNumRnd;
            Random rnd = new Random();
            byte[] cXHash = Vars.ComputeHash(cursorX.ToString()), cYHash = Vars.ComputeHash(cursorY.ToString()), timeHash = Vars.ComputeHash(currentTime.ToString());
            string resNumStr = "";

            for (i = 0; i < length; i++)
            {
                currentRnd = rnd.Next(3);
                currentNumRnd = rnd.Next(64);

                switch (currentRnd)
                {
                    case 0:
                        resNumStr += cXHash[currentNumRnd].ToString()[0];
                        break;
                    case 1:
                        resNumStr += cYHash[currentNumRnd].ToString()[0];
                        break;
                    case 2:
                        resNumStr += timeHash[currentNumRnd].ToString()[0];
                        break;
                }
            }

            return BigInteger.Parse(resNumStr);
        }
    }
}
