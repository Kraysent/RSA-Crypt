using System;
using RSACryptLibrary;
using System.IO;
using System.Windows.Forms;
using System.Numerics;

namespace RSACrypt.src
{
    public partial class Main : Form
    {
        //-----System methods-----//

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void EncryptMenu_Click(object sender, EventArgs e)
        {
            Encrypt();
        }
        
        private void KeysCreateMenu_Click(object sender, EventArgs e)
        {
            Generate();
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Exit();
        }
        
        private void AddKeyButton_Click(object sender, EventArgs e)
        {
            AddKey();
        }

        private void DecryptMenu_Click(object sender, EventArgs e)
        {
            Decrypt();
        }
        
        private void ContactListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateList();
        }

        //-----Non-system methods-----//

        private void Generate()
        {
            KeysGenerationForm keysGeneration = new KeysGenerationForm();

            keysGeneration.ShowDialog();
        }

        private void Encrypt()
        {
            string text = MainTextbox.Text;

            MainTextbox.Text = Options.ContactPublicKey.Encrypt(text);
        }

        private void Decrypt()
        {
            string text = MainTextbox.Text;

            MainTextbox.Text = Options.UserPrivateKey.Decrypt(text);
        }

        private void AddKey()
        {
            OpenFileDialog openKeyDialog = new OpenFileDialog();
            string[] fileContent;
            string username;
            Key currentKey;
            UsernameAskForm usernameAsk = new UsernameAskForm();

            openKeyDialog.Multiselect = false;
            openKeyDialog.ShowDialog();
            fileContent = File.ReadAllLines(openKeyDialog.FileName)[1].Split('+');
            currentKey = new Key(BigInteger.Parse(fileContent[0]), BigInteger.Parse(fileContent[1]), KeyType.Public);
            Options.ContactPublicKey = currentKey;
            usernameAsk.ShowDialog();
            username = usernameAsk.Username;

            Options.ContactsList.Add(currentKey);
            ContactListbox.Items.Add(username);
            ContactListbox.SelectedIndex = Options.ContactsList.Count - 1;
        }

        private void UpdateList()
        {
            Options.ContactPublicKey = Options.ContactsList[ContactListbox.SelectedIndex];
        }

        private void Exit()
        {
            Application.Exit();
        }
    }
}
