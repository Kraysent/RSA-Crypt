namespace RSACrypt.src
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainTextbox = new System.Windows.Forms.TextBox();
            this.Version_Label = new System.Windows.Forms.Label();
            this.ContactsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DocsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.IntegrityMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SignatureMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DecryptMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EncryptMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.KeysCreateMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeContactMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeKeyPairMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.OperationsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_Menu = new System.Windows.Forms.MenuStrip();
            this.OptionsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenOptionsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectedKeysMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTextbox
            // 
            this.MainTextbox.Location = new System.Drawing.Point(10, 27);
            this.MainTextbox.Multiline = true;
            this.MainTextbox.Name = "MainTextbox";
            this.MainTextbox.Size = new System.Drawing.Size(668, 360);
            this.MainTextbox.TabIndex = 17;
            // 
            // Version_Label
            // 
            this.Version_Label.AutoSize = true;
            this.Version_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Version_Label.Location = new System.Drawing.Point(12, 390);
            this.Version_Label.Name = "Version_Label";
            this.Version_Label.Size = new System.Drawing.Size(113, 15);
            this.Version_Label.TabIndex = 14;
            this.Version_Label.Text = "Version: v.1.0 alpha";
            // 
            // ContactsMenu
            // 
            this.ContactsMenu.Name = "ContactsMenu";
            this.ContactsMenu.Size = new System.Drawing.Size(157, 22);
            this.ContactsMenu.Text = "Contacts";
            // 
            // HelpMenu
            // 
            this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DocsMenu,
            this.ContactsMenu,
            this.AboutMenu});
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(44, 20);
            this.HelpMenu.Text = "Help";
            // 
            // DocsMenu
            // 
            this.DocsMenu.Name = "DocsMenu";
            this.DocsMenu.Size = new System.Drawing.Size(157, 22);
            this.DocsMenu.Text = "Documentation";
            // 
            // AboutMenu
            // 
            this.AboutMenu.Name = "AboutMenu";
            this.AboutMenu.Size = new System.Drawing.Size(157, 22);
            this.AboutMenu.Text = "About program";
            // 
            // IntegrityMenu
            // 
            this.IntegrityMenu.Name = "IntegrityMenu";
            this.IntegrityMenu.Size = new System.Drawing.Size(171, 22);
            this.IntegrityMenu.Text = "Check integrity";
            // 
            // SignatureMenu
            // 
            this.SignatureMenu.Name = "SignatureMenu";
            this.SignatureMenu.Size = new System.Drawing.Size(171, 22);
            this.SignatureMenu.Text = "Add signature";
            // 
            // DecryptMenu
            // 
            this.DecryptMenu.Name = "DecryptMenu";
            this.DecryptMenu.Size = new System.Drawing.Size(171, 22);
            this.DecryptMenu.Text = "Decrypt";
            // 
            // EncryptMenu
            // 
            this.EncryptMenu.Name = "EncryptMenu";
            this.EncryptMenu.Size = new System.Drawing.Size(171, 22);
            this.EncryptMenu.Text = "Encrypt";
            this.EncryptMenu.Click += new System.EventHandler(this.EncryptMenu_Click);
            // 
            // KeysCreateMenu
            // 
            this.KeysCreateMenu.Name = "KeysCreateMenu";
            this.KeysCreateMenu.Size = new System.Drawing.Size(171, 22);
            this.KeysCreateMenu.Text = "Create pair of keys";
            // 
            // ChangeContactMenu
            // 
            this.ChangeContactMenu.Name = "ChangeContactMenu";
            this.ChangeContactMenu.Size = new System.Drawing.Size(171, 22);
            this.ChangeContactMenu.Text = "Change contact";
            // 
            // ChangeKeyPairMenu
            // 
            this.ChangeKeyPairMenu.Name = "ChangeKeyPairMenu";
            this.ChangeKeyPairMenu.Size = new System.Drawing.Size(171, 22);
            this.ChangeKeyPairMenu.Text = "Change keys\' pair";
            // 
            // OperationsMenu
            // 
            this.OperationsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeKeyPairMenu,
            this.ChangeContactMenu,
            this.KeysCreateMenu,
            this.EncryptMenu,
            this.DecryptMenu,
            this.SignatureMenu,
            this.IntegrityMenu});
            this.OperationsMenu.Name = "OperationsMenu";
            this.OperationsMenu.Size = new System.Drawing.Size(77, 20);
            this.OperationsMenu.Text = "Operations";
            // 
            // Main_Menu
            // 
            this.Main_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OperationsMenu,
            this.HelpMenu,
            this.OptionsMenu,
            this.ExitMenu});
            this.Main_Menu.Location = new System.Drawing.Point(0, 0);
            this.Main_Menu.Name = "Main_Menu";
            this.Main_Menu.Size = new System.Drawing.Size(690, 24);
            this.Main_Menu.TabIndex = 12;
            this.Main_Menu.Text = "Main Menu";
            // 
            // OptionsMenu
            // 
            this.OptionsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenOptionsMenu,
            this.SelectedKeysMenu,
            this.UpdateMenu});
            this.OptionsMenu.Name = "OptionsMenu";
            this.OptionsMenu.Size = new System.Drawing.Size(61, 20);
            this.OptionsMenu.Text = "Options";
            // 
            // OpenOptionsMenu
            // 
            this.OpenOptionsMenu.Name = "OpenOptionsMenu";
            this.OpenOptionsMenu.Size = new System.Drawing.Size(146, 22);
            this.OpenOptionsMenu.Text = "Open options";
            // 
            // SelectedKeysMenu
            // 
            this.SelectedKeysMenu.Name = "SelectedKeysMenu";
            this.SelectedKeysMenu.Size = new System.Drawing.Size(146, 22);
            this.SelectedKeysMenu.Text = "Selected keys";
            // 
            // UpdateMenu
            // 
            this.UpdateMenu.Name = "UpdateMenu";
            this.UpdateMenu.Size = new System.Drawing.Size(146, 22);
            this.UpdateMenu.Text = "Update";
            // 
            // ExitMenu
            // 
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(37, 20);
            this.ExitMenu.Text = "Exit";
            this.ExitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 416);
            this.Controls.Add(this.MainTextbox);
            this.Controls.Add(this.Version_Label);
            this.Controls.Add(this.Main_Menu);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Main_Menu.ResumeLayout(false);
            this.Main_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox MainTextbox;
        private System.Windows.Forms.Label Version_Label;
        private System.Windows.Forms.ToolStripMenuItem ContactsMenu;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStripMenuItem DocsMenu;
        private System.Windows.Forms.ToolStripMenuItem IntegrityMenu;
        private System.Windows.Forms.ToolStripMenuItem SignatureMenu;
        private System.Windows.Forms.ToolStripMenuItem DecryptMenu;
        private System.Windows.Forms.ToolStripMenuItem EncryptMenu;
        private System.Windows.Forms.ToolStripMenuItem KeysCreateMenu;
        private System.Windows.Forms.ToolStripMenuItem ChangeContactMenu;
        private System.Windows.Forms.ToolStripMenuItem ChangeKeyPairMenu;
        private System.Windows.Forms.ToolStripMenuItem OperationsMenu;
        private System.Windows.Forms.MenuStrip Main_Menu;
        private System.Windows.Forms.ToolStripMenuItem OptionsMenu;
        private System.Windows.Forms.ToolStripMenuItem OpenOptionsMenu;
        private System.Windows.Forms.ToolStripMenuItem SelectedKeysMenu;
        private System.Windows.Forms.ToolStripMenuItem UpdateMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitMenu;
        private System.Windows.Forms.ToolStripMenuItem AboutMenu;
    }
}

