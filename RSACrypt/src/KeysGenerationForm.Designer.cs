namespace RSACrypt.src
{
    partial class KeysGenerationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GenerateButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.KeysLengthCombobox = new System.Windows.Forms.ComboBox();
            this.ConfirmTextbox = new System.Windows.Forms.TextBox();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.OpenDirTextbox = new System.Windows.Forms.TextBox();
            this.OpenDirectoryButton = new System.Windows.Forms.Button();
            this.OpenDirLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(165, 168);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(146, 42);
            this.GenerateButton.TabIndex = 19;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(8, 168);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(151, 42);
            this.CancelButton.TabIndex = 18;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // KeysLengthCombobox
            // 
            this.KeysLengthCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KeysLengthCombobox.FormattingEnabled = true;
            this.KeysLengthCombobox.Location = new System.Drawing.Point(122, 104);
            this.KeysLengthCombobox.Name = "KeysLengthCombobox";
            this.KeysLengthCombobox.Size = new System.Drawing.Size(189, 21);
            this.KeysLengthCombobox.TabIndex = 17;
            // 
            // ConfirmTextbox
            // 
            this.ConfirmTextbox.Location = new System.Drawing.Point(122, 72);
            this.ConfirmTextbox.Name = "ConfirmTextbox";
            this.ConfirmTextbox.Size = new System.Drawing.Size(189, 20);
            this.ConfirmTextbox.TabIndex = 16;
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(122, 41);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(189, 20);
            this.PasswordTextbox.TabIndex = 15;
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Location = new System.Drawing.Point(122, 11);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(189, 20);
            this.UsernameTextbox.TabIndex = 14;
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(8, 104);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(109, 13);
            this.LengthLabel.TabIndex = 13;
            this.LengthLabel.Text = "Select length of keys:";
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.AutoSize = true;
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(8, 72);
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(93, 13);
            this.ConfirmPasswordLabel.TabIndex = 12;
            this.ConfirmPasswordLabel.Text = "Confirm password:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(8, 41);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(106, 13);
            this.PasswordLabel.TabIndex = 11;
            this.PasswordLabel.Text = "Enter your password:";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(8, 11);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(107, 13);
            this.UsernameLabel.TabIndex = 10;
            this.UsernameLabel.Text = "Enter your username:";
            // 
            // OpenDirTextbox
            // 
            this.OpenDirTextbox.Location = new System.Drawing.Point(122, 136);
            this.OpenDirTextbox.Name = "OpenDirTextbox";
            this.OpenDirTextbox.Size = new System.Drawing.Size(105, 20);
            this.OpenDirTextbox.TabIndex = 20;
            // 
            // OpenDirectoryButton
            // 
            this.OpenDirectoryButton.Location = new System.Drawing.Point(234, 136);
            this.OpenDirectoryButton.Name = "OpenDirectoryButton";
            this.OpenDirectoryButton.Size = new System.Drawing.Size(77, 23);
            this.OpenDirectoryButton.TabIndex = 21;
            this.OpenDirectoryButton.Text = "Observe...";
            this.OpenDirectoryButton.UseVisualStyleBackColor = true;
            this.OpenDirectoryButton.Click += new System.EventHandler(this.OpenDirectoryButton_Click);
            // 
            // OpenDirLabel
            // 
            this.OpenDirLabel.AutoSize = true;
            this.OpenDirLabel.Location = new System.Drawing.Point(11, 136);
            this.OpenDirLabel.Name = "OpenDirLabel";
            this.OpenDirLabel.Size = new System.Drawing.Size(83, 13);
            this.OpenDirLabel.TabIndex = 22;
            this.OpenDirLabel.Text = "Select directory:";
            // 
            // KeysGenerationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 224);
            this.Controls.Add(this.OpenDirLabel);
            this.Controls.Add(this.OpenDirectoryButton);
            this.Controls.Add(this.OpenDirTextbox);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.KeysLengthCombobox);
            this.Controls.Add(this.ConfirmTextbox);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.UsernameTextbox);
            this.Controls.Add(this.LengthLabel);
            this.Controls.Add(this.ConfirmPasswordLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KeysGenerationForm";
            this.Text = "Keys generation parameters";
            this.Load += new System.EventHandler(this.KeysGenerationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateButton;
        new private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ComboBox KeysLengthCombobox;
        private System.Windows.Forms.TextBox ConfirmTextbox;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.TextBox UsernameTextbox;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.Label ConfirmPasswordLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox OpenDirTextbox;
        private System.Windows.Forms.Button OpenDirectoryButton;
        private System.Windows.Forms.Label OpenDirLabel;
    }
}