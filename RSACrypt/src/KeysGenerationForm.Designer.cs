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
            this.LengthLabel = new System.Windows.Forms.Label();
            this.OpenDirTextbox = new System.Windows.Forms.TextBox();
            this.OpenDirectoryButton = new System.Windows.Forms.Button();
            this.OpenDirLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(164, 79);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(146, 42);
            this.GenerateButton.TabIndex = 19;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(7, 79);
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
            this.KeysLengthCombobox.Location = new System.Drawing.Point(121, 15);
            this.KeysLengthCombobox.Name = "KeysLengthCombobox";
            this.KeysLengthCombobox.Size = new System.Drawing.Size(189, 21);
            this.KeysLengthCombobox.TabIndex = 17;
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(7, 15);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(109, 13);
            this.LengthLabel.TabIndex = 13;
            this.LengthLabel.Text = "Select length of keys:";
            // 
            // OpenDirTextbox
            // 
            this.OpenDirTextbox.Location = new System.Drawing.Point(121, 47);
            this.OpenDirTextbox.Name = "OpenDirTextbox";
            this.OpenDirTextbox.Size = new System.Drawing.Size(105, 20);
            this.OpenDirTextbox.TabIndex = 20;
            // 
            // OpenDirectoryButton
            // 
            this.OpenDirectoryButton.Location = new System.Drawing.Point(233, 47);
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
            this.OpenDirLabel.Location = new System.Drawing.Point(10, 47);
            this.OpenDirLabel.Name = "OpenDirLabel";
            this.OpenDirLabel.Size = new System.Drawing.Size(83, 13);
            this.OpenDirLabel.TabIndex = 22;
            this.OpenDirLabel.Text = "Select directory:";
            // 
            // KeysGenerationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 131);
            this.Controls.Add(this.OpenDirLabel);
            this.Controls.Add(this.OpenDirectoryButton);
            this.Controls.Add(this.OpenDirTextbox);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.KeysLengthCombobox);
            this.Controls.Add(this.LengthLabel);
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
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.TextBox OpenDirTextbox;
        private System.Windows.Forms.Button OpenDirectoryButton;
        private System.Windows.Forms.Label OpenDirLabel;
    }
}