using System;
using System.Windows.Forms;

namespace RSACrypt.src
{
    public partial class Main : Form
    {
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
        
        private void ChangeKeyPairMenu_Click(object sender, EventArgs e)
        {
            ChangePair();
        }

        private void KeysCreateMenu_Click(object sender, EventArgs e)
        {
            Generate();
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void Generate()
        {
            KeysGenerationForm keysGeneration = new KeysGenerationForm();

            keysGeneration.ShowDialog();
        }

        private void Encrypt()
        {
            string text = MainTextbox.Text;

            MainTextbox.Text = Options.FormatEncryptedText(Options.UserPrivateKey.Encrypt(text));
        }

        private void ChangePair()
        {

        }

        private void Exit()
        {
            Application.Exit();
        }
    }
}
