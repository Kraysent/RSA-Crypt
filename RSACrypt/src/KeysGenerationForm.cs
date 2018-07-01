using RSACryptLibrary;
using System;
using System.IO;
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
            KeysLengthCombobox.Items.Add("512");
            KeysLengthCombobox.Items.Add("1024");
            KeysLengthCombobox.Items.Add("2048");
            KeysLengthCombobox.SelectedIndex = 0;
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
                OpenDirTextbox.Text = folderDialog.SelectedPath;
            }
        }

        private void Cancelation()
        {
            Close();
        }
        
        private void KeysGeneration()
        {
            Key[] generatedKeys;
            string dirPath, outputFileName;
            int keysLength = 512;

            //-----Keys length check-----//

            switch (KeysLengthCombobox.Text)
            {
                case "512":
                    keysLength = 512;
                    break;
                case "1024":
                    keysLength = 1024;
                    break;
                case "2048":
                    keysLength = 2048;
                    break;
            }

            //-----Directory path check-----//

            dirPath = OpenDirTextbox.Text;

            if (Directory.Exists(dirPath) != true)
            {
                MessageBox.Show("Directory does not exists!", "Error!");

                return;
            }

            //-----Generating keys-----//
            
            generatedKeys = Key.GeneratePair(keysLength);

            //-----Keys output-----//

            outputFileName = keysLength + "_" + DateTime.Now.ToString("ddMMyyyy-hhmmss") + "_";
            File.WriteAllLines(dirPath + outputFileName + "public.pub", Options.ToFileFormat(generatedKeys[0]));
            File.WriteAllLines(dirPath + outputFileName + "private.priv", Options.ToFileFormat(generatedKeys[1]));
            MessageBox.Show("Keys were successfully generated! They are saved to following directory: \n" + dirPath, "Keys were successfully generated!");
        }
    }
}
