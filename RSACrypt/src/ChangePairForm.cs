using RSACryptLibrary;
using System;
using System.IO;
using System.Windows.Forms;

namespace RSACrypt.src
{
    public partial class ChangePairForm : Form
    {
        //-----System methods-----//

        public ChangePairForm()
        {
            InitializeComponent();
        }

        private void ChangePairForm_Load(object sender, EventArgs e)
        {
            
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }
        
        private void AddButton_Click(object sender, EventArgs e)
        {
            Add();
        }

        //-----Non-system methods-----//

        private void Add()
        {
            OpenFileDialog openKeyDialog = new OpenFileDialog();
            string[] outputKeysArray, file1, file2;

            openKeyDialog.Multiselect = true;

            openKeyDialog.ShowDialog();
            outputKeysArray = openKeyDialog.FileNames;
            
            if (outputKeysArray.Length == 2)
            {
                file1 = File.ReadAllLines(outputKeysArray[0]);
                file2 = File.ReadAllLines(outputKeysArray[1]);

                if (Options.GetType(file1) != Options.GetType(file2))
                {

                }
            }
        }

        private void CloseWindow()
        {
            Close();
        }

        //-----Additional methods-----//

        private bool CheckKeys(string[] key1, string[] key2)
        {
            string[] checkPublicFormat = Options.ToFileFormat(Key.SampleKey(KeyType.Public));
            string[] checkPrivateFormat = Options.ToFileFormat(Key.SampleKey(KeyType.Private));
            KeyType type1, type2;

            if (key1[0] == checkPublicFormat[0] && key1[2] == checkPublicFormat[2])
            {
                type1 = KeyType.Public;
            }
            else if (key1[0] == checkPrivateFormat[0] && key1[2] == checkPrivateFormat[2])
            {
                type1 = KeyType.Private;
            }
            else
            {
                return false;
            }

            if (key2[0] == checkPublicFormat[0] && key2[2] == checkPublicFormat[2])
            {
                type2 = KeyType.Public;
            }
            else if (key2[0] == checkPrivateFormat[0] && key2[2] == checkPrivateFormat[2])
            {
                type2 = KeyType.Private;
            }
            else
            {
                return false;
            }

            if (type1 != type2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
