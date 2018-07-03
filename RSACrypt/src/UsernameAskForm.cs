using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RSACrypt.src
{
    public partial class UsernameAskForm : Form
    {
        public string Username;

        public UsernameAskForm()
        {
            InitializeComponent();
        }

        private void UsernameAskForm_Load(object sender, EventArgs e)
        {

        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Done();
        }

        private void Done()
        {
            Username = UsernameTextbox.Text;
            Close();
        }
    }
}
