using System;
using System.Threading;
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

        private void KeysCreateMenu_Click(object sender, EventArgs e)
        {
            Generate();
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Generate()
        {
            KeysGenerationForm keysGeneration = new KeysGenerationForm();

            keysGeneration.ShowDialog();
        }

        private void Encrypt()
        {
            string text = MainTextbox.Text;

            MainTextbox.Text = Vars.FormatEncryptedText(Vars.UserPrivateKey.Encrypt(text));
        }
    }
}
