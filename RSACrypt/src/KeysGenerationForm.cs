﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RSACrypt.src
{
    public partial class KeysGenerationForm : Form
    {
        //-----System methods-----//

        public KeysGenerationForm()
        {
            InitializeComponent();
        }

        private void KeysGenerationForm_Load(object sender, EventArgs e)
        {
            PasswordTextbox.PasswordChar = '*';
            ConfirmTextbox.PasswordChar = '*';
        }

        private void OpenDirectoryButton_Click(object sender, EventArgs e)
        {
            OpeningDirectory();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Cancelation();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            KeysGeneration();
        }
        
        //-----Non-system methods-----//

        private void OpeningDirectory()
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            string outputPath;

            folderDialog.ShowDialog();
            outputPath = folderDialog.SelectedPath;

            if (Directory.Exists(outputPath) == true)
            {
                OpenDirTextbox.Text = folderDialog.SelectedPath + "\\";
            }
        }

        private void Cancelation()
        {
            Close();
        }

        private void KeysGeneration()
        {
            Key[] generatedKeys;
            string username, password, passwordConfirm, dirPath, outputFileName;
            int keysLength = 1024;

            //-----Username check-----//

            username = UsernameTextbox.Text;

            if (username.Length < 2 | username.Length > 30 | username.IndexOf(Vars.KeySplitChar) != -1)
            {
                MessageBox.Show("Username must be longer then 2 symbols, less then 30 symbols and does not contain symbol \"+\"!", "Error!");

                return;
            }

            //-----Password check-----//

            password = PasswordTextbox.Text;

            if (password.Length < 5 | password.Length > 65)
            {
                MessageBox.Show("Password must be longer then 5 symbols and less then 65 symbols!", "Error!");

                return;
            }

            //-----Password confirmation check-----//

            passwordConfirm = ConfirmTextbox.Text;

            if (passwordConfirm != password)
            {
                MessageBox.Show("Passwords are not the same!", "Error!");

                return;
            }

            //-----Directory path check-----//

            dirPath = OpenDirTextbox.Text;

            if (Directory.Exists(dirPath) != true)
            {
                if (dirPath[dirPath.Length - 1] != '\\')
                {
                    MessageBox.Show("Directory does not exists!", "Error!");
                }

                return;
            }

            //-----Generating keys-----//

            generatedKeys = Key.GeneratePair(username, password, keysLength);

            //-----Keys output-----//

            outputFileName = username + "_" + keysLength + "_" + DateTime.Now.ToString("ddMMyyyy-hh:mm:ss") + "_";
            File.WriteAllLines(dirPath + outputFileName + "public", generatedKeys[0].ToFileFormat());
            File.WriteAllLines(dirPath + outputFileName + "private", generatedKeys[1].ToFileFormat());
            MessageBox.Show("Keys were successfully generated! They are saved to following directory: \n" + dirPath, "Keys were successfully generated!");


        }
    }
}