﻿using System;
using System.Threading;
using System.Windows.Forms;
using System.Numerics;

namespace RSACrypt.src
{
    class Key
    {
        //-----Variables-----//

        public BigInteger Exponent;
        public BigInteger Modulus;
        public string KeyType;
        public string Username;
        public byte[] PasswordHash;

        //-----Initialisation-----//

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

        //-----Non-static methods-----//

        /// <summary>
        /// Converts Key to file output format
        /// </summary>
        /// <returns></returns>
        public string[] ToFileFormat()
        {
            string[] outputArray = new string[3];
            string keyTypeText = "";

            if (KeyType == "pub")
            {
                keyTypeText = "PUBLIC";
            }
            else if (KeyType == "priv")
            {
                keyTypeText = "PRIVATE";
            }

            outputArray[0] = "-----BEGIN RSA CRYPT "+ keyTypeText +" KEY-----";
            outputArray[1] = Exponent + "+" + Modulus + "+" + Username + "+" + new BigInteger(PasswordHash);
            outputArray[2] = "-----END RSA CRYPT " + keyTypeText + " KEY-----";

            return outputArray;
        }

        /// <summary>
        /// Encrypts the text using public Key
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public string Encrypt(string text)
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

                if (block[j].Length > Modulus.ToString().Length - 10)
                {
                    block[j] += Random_End.Next(0, 9);
                    j++;
                }
            }

            for (int i = 0; i <= j; i++)
            {
                currentBIBlock = BigInteger.Parse(block[i]);
                Encrypted_Message = BigInteger.ModPow(currentBIBlock, Exponent, Modulus);
                Output_Text += Encrypted_Message.ToString() + Vars.SplitChar;
            }

            return Output_Text;
        }

        //-----Static methods-----//

        /// <summary>
        /// Generates a new pair of Keys. Key[0] is public, Key[1] is private
        /// </summary>
        /// <returns></returns>
        public static Key[] GeneratePair(string username, string password, int keysLength)
        {
            byte[] passwordHash = Vars.ComputeHash(password);
            BigInteger p, q, publicExp = 0, privateExp = 0, rem = 0, eylerFunction, modulus = 0;
            Key[] outputKeyArray = new Key[2];

            keysLength = keysLength / 8;

            while (rem != 1)
            {
                p = RandomNumber(keysLength);
                q = RandomNumber(keysLength);
                publicExp = RandomNumber(keysLength);
                
                while (MillerRubenTest(p) != true)
                {
                    p = RandomNumber(keysLength);
                    p = GettingPrimeLoop(p);
                }

                while (MillerRubenTest(q) != true)
                {
                    q = RandomNumber(keysLength);
                    q = GettingPrimeLoop(q);
                }

                while (MillerRubenTest(publicExp) != true)
                {
                    publicExp = RandomNumber(keysLength);
                    publicExp = GettingPrimeLoop(publicExp);
                }

                modulus = BigInteger.Multiply(p, q);
                eylerFunction = BigInteger.Multiply(p - 1, q - 1);
                privateExp = BigInteger.Abs(Inverse(publicExp, eylerFunction));
                BigInteger.DivRem(privateExp * publicExp, eylerFunction, out rem);
            }

            outputKeyArray[0] = new Key(publicExp, modulus, "pub", username, passwordHash);   //Public Key
            outputKeyArray[1] = new Key(privateExp, modulus, "priv", username, passwordHash); //Private Key

            return outputKeyArray;
        }
        
        /// <summary>
        /// Gets random number
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        private static BigInteger RandomNumber(int length)
        {
            int currentTimeMs = DateTime.Now.Millisecond;
            int cursorX = Cursor.Position.X, cursorY = Cursor.Position.Y, i, currentRnd, currentNumRnd;
            Random rnd = new Random();
            byte[] cXHash = Vars.ComputeHash(cursorX.ToString()), cYHash = Vars.ComputeHash(cursorY.ToString()), timeHash = Vars.ComputeHash(currentTimeMs.ToString());
            string resNumStr = "";
            BigInteger outputNumber;

            for (i = 0; i < length; i++)
            {
                currentRnd = rnd.Next(3);
                currentNumRnd = rnd.Next(64);

                switch (currentRnd)
                {
                    case 0:
                        resNumStr += (cXHash[currentNumRnd] * rnd.Next(8)).ToString()[0];
                        break;
                    case 1:
                        resNumStr += (cYHash[currentNumRnd] * rnd.Next(8)).ToString()[0];
                        break;
                    case 2:
                        resNumStr += (timeHash[currentNumRnd] * rnd.Next(8)).ToString()[0];
                        break;
                }
            }

            Thread.Sleep(10);
            outputNumber = BigInteger.Abs(BigInteger.Parse(resNumStr));

            if (outputNumber.IsEven == true)
            {
                outputNumber++;
            }

            return outputNumber;
        }

        /// <summary>
        /// Checks if number is prime or not
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private static bool MillerRubenTest(BigInteger number)
        {
            Random rnd = new Random();
            BigInteger t, rndNum, x;
            int k, i, j, s = 0;
            string rndLine = "";
            bool iterFlag = false;

            k = number.ToString().Length;
            t = number - 1;

            while (t % 2 == 0)
            {
                s++;
                t = t / 2;
            }

            for (i = 0; i < k; i++)
            {
                if (i >= k)
                {
                    break;
                }

                for (j = 0; j < rnd.Next(2, number.ToString().Length - 2); j++)
                {
                    rndLine += rnd.Next(0, 9);
                }

                rndNum = BigInteger.Parse(rndLine);
                x = BigInteger.ModPow(rndNum, t, number);

                if (x == 1 | x == number - 1)
                {
                    continue;
                }

                for (j = 0; j < s - 1; j++)
                {
                    x = BigInteger.ModPow(x, 2, number);

                    if (x == 1)
                    {
                        return false;
                    }

                    if (x == number - 1)
                    {
                        iterFlag = true;
                        break;
                    }
                }

                if (iterFlag == true)
                {
                    iterFlag = false;
                    continue;
                }

                return false;
            }

            return true;
        }

        /// <summary>
        /// Adds 1 to number until it becomes prime
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private static BigInteger GettingPrimeLoop(BigInteger number)
        {
            bool fl = false, fl1 = false;
            BigInteger rem = 0;

            while (fl1 == false)
            {
                for (int i = 2; i <= 256; i++)
                {
                    BigInteger.DivRem(number, i, out rem);

                    if (rem == 0)
                    {
                        fl = true;
                        break;
                    }
                }

                if (fl == true)
                {
                    number++;
                    fl = false;
                }
                else
                {
                    fl1 = true;
                }
            }

            return number;
        }
        
        /// <summary>
        /// Gets multiplicative inverse of a by modulus n
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n">Modulus</param>
        /// <returns></returns>
        public static BigInteger Inverse(BigInteger a, BigInteger n)
        {
            BigInteger d, x, y;
            x = 0;
            y = 0;
            d = 0;
            EuclidFunction(a, n, ref x, ref y, ref d);
            return x;
        }

        /// <summary>
        /// Counts extended euclidean algorithm: ax + by = d
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="d"></param>
        public static void EuclidFunction(BigInteger a, BigInteger b, ref BigInteger x, ref BigInteger y, ref BigInteger d)
        {
            BigInteger q, r, x1, x2, y1, y2;
            if (b == 0)
            {
                d = a;
                x = 1;
                y = 0;
                return;
            }
            x2 = 1;
            x1 = 0;
            y2 = 0;
            y1 = 1;
            while (b > 0)
            {
                q = a / b;
                r = a - q * b;
                x = x2 - q * x1;
                y = y2 - q * y1;
                a = b;
                b = r;
                x2 = x1;
                x1 = x;
                y2 = y1;
                y1 = y;
            }
            d = a;
            x = x2;
            y = y2;
        }
    }
}
