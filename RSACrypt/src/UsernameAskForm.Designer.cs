namespace RSACrypt.src
{
    partial class UsernameAskForm
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
            this.OKButton = new System.Windows.Forms.Button();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.EnterUsernameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(13, 60);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(234, 36);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "Done";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Location = new System.Drawing.Point(12, 34);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(234, 20);
            this.UsernameTextbox.TabIndex = 1;
            // 
            // EnterUsernameLabel
            // 
            this.EnterUsernameLabel.AutoSize = true;
            this.EnterUsernameLabel.Location = new System.Drawing.Point(13, 15);
            this.EnterUsernameLabel.Name = "EnterUsernameLabel";
            this.EnterUsernameLabel.Size = new System.Drawing.Size(121, 13);
            this.EnterUsernameLabel.TabIndex = 2;
            this.EnterUsernameLabel.Text = "Enter username, please:";
            // 
            // UsernameAskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 113);
            this.Controls.Add(this.EnterUsernameLabel);
            this.Controls.Add(this.UsernameTextbox);
            this.Controls.Add(this.OKButton);
            this.Name = "UsernameAskForm";
            this.Text = "Username";
            this.Load += new System.EventHandler(this.UsernameAskForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.TextBox UsernameTextbox;
        private System.Windows.Forms.Label EnterUsernameLabel;
    }
}