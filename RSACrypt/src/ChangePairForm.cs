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
            OpenFileDialog dialog1 = new OpenFileDialog();
            OpenFileDialog dialog2 = new OpenFileDialog();
            
            //
        }

        private void CloseWindow()
        {
            Close();
        }

    }
}
