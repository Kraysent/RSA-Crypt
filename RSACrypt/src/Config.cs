using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RSACrypt.src
{
    class Config
    {
        private string configPath = Directory.GetCurrentDirectory() + "/config.txt";
        private const string lastPairBlockBegin = "_lastpairkeyb_";
        private const string lastPairBlockEnd = "_lastpairkeye_";
        private const string listPairBlockBegin = "_listofpairsb_";
        private const string listPairBlockEnd = "_listofpairse_";
        private const char pathsSpliChar = ':';

        /// <summary>
        /// Creates configuration file
        /// </summary>
        public void Create()
        {
            int blocksNumber = 2;
            string[] initialContent = new string[blocksNumber * 2];

            initialContent[0] = lastPairBlockBegin; 
            initialContent[1] = lastPairBlockEnd;

            initialContent[2] = listPairBlockBegin;
            initialContent[3] = listPairBlockEnd;
            
            File.WriteAllLines(configPath, initialContent);
        }

        /// <summary>
        /// Addes new pair to configuration file
        /// </summary>
        /// <param name="pubKeyPath"></param>
        /// <param name="privKeyPath"></param>
        public void AddPair(string pubKeyPath, string privKeyPath)
        {
            int i;
            string[] configContents;

            if (CheckKey(pubKeyPath, "pub") == true && CheckKey(pubKeyPath, "priv") == true)
            {
                if (File.Exists(configPath) != true)
                {
                    Create();
                }

                configContents = File.ReadAllLines(configPath);

                for (i = 0; i < configContents.Length; i++)
                {
                    if (configContents[i] == listPairBlockBegin)
                    {
                        InsertString(pubKeyPath + pathsSpliChar + privKeyPath, i + 1);
                    }
                }

                for (i = 0; i < configContents.Length; i++)
                {
                    if (configContents[i] == lastPairBlockBegin)
                    {
                        ReplaceString(pubKeyPath + pathsSpliChar + privKeyPath, i + 1);
                    }
                }
            }
        }

        /// <summary>
        /// Checks if key file is in right format
        /// </summary>
        /// <param name="path"></param>
        /// <param name="keyType"></param>
        /// <returns></returns>
        private bool CheckKey(string path, string keyType)
        {
            Key standartKey;
            string[] standartFormattedKey;
            string[] fileContents;
            int i, index1 = 0, index2 = 0;

            if (File.Exists(path) == true)
            {
                fileContents = File.ReadAllLines(path);
                standartKey = new Key(0, 0, keyType, "user", Vars.ComputeHash("123"));
                standartFormattedKey = standartKey.ToFileFormat();

                for (i = 0; i < fileContents.Length; i++)
                {
                    if (fileContents[i].IndexOf(standartFormattedKey[0]) != -1)
                    {
                        index1 = i;
                    }

                    if (fileContents[i].IndexOf(standartFormattedKey[2]) != -1)
                    {
                        index2 = i;
                    }
                }

                if (index2 - index1 == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Inserts string into the configuration file in selected line index
        /// </summary>
        /// <param name="str"></param>
        /// <param name="lineIndex"></param>
        private void InsertString(string str, int lineIndex)
        {
            string[] configContents = File.ReadAllLines(configPath);
            string[] outpitConfig = new string[configContents.Length + 1];
            int i;

            for (i = 0; i < lineIndex; i++)
            {
                outpitConfig[i] = configContents[i];
            }

            outpitConfig[lineIndex] = str;

            for (i = lineIndex + 1; i < outpitConfig.Length; i++)
            {
                outpitConfig[i] = configContents[i - 1];
            }

            File.Delete(configPath);
            File.WriteAllLines(configPath, outpitConfig);
        }

        /// <summary>
        /// Replaces string in the configuration file in selected line index
        /// </summary>
        /// <param name="str"></param>
        /// <param name="lineIndex"></param>
        private void ReplaceString(string str, int lineIndex)
        {
            string[] configContents = File.ReadAllLines(configPath);

            configContents[lineIndex] = str;
            File.WriteAllLines(configPath, configContents);
        }
    }
}
