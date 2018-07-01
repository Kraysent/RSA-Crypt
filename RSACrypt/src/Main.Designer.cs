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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.MainTextbox = new System.Windows.Forms.TextBox();
            this.Version_Label = new System.Windows.Forms.Label();
            this.ContactsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DocsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckSignMenu = new System.Windows.Forms.ToolStripMenuItem();
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
            resources.ApplyResources(this.MainTextbox, "MainTextbox");
            this.MainTextbox.Name = "MainTextbox";
            // 
            // Version_Label
            // 
            resources.ApplyResources(this.Version_Label, "Version_Label");
            this.Version_Label.Name = "Version_Label";
            // 
            // ContactsMenu
            // 
            this.ContactsMenu.Name = "ContactsMenu";
            resources.ApplyResources(this.ContactsMenu, "ContactsMenu");
            // 
            // HelpMenu
            // 
            this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DocsMenu,
            this.ContactsMenu,
            this.AboutMenu});
            this.HelpMenu.Name = "HelpMenu";
            resources.ApplyResources(this.HelpMenu, "HelpMenu");
            // 
            // DocsMenu
            // 
            this.DocsMenu.Name = "DocsMenu";
            resources.ApplyResources(this.DocsMenu, "DocsMenu");
            // 
            // AboutMenu
            // 
            this.AboutMenu.Name = "AboutMenu";
            resources.ApplyResources(this.AboutMenu, "AboutMenu");
            // 
            // CheckSignMenu
            // 
            this.CheckSignMenu.Name = "CheckSignMenu";
            resources.ApplyResources(this.CheckSignMenu, "CheckSignMenu");
            // 
            // SignatureMenu
            // 
            this.SignatureMenu.Name = "SignatureMenu";
            resources.ApplyResources(this.SignatureMenu, "SignatureMenu");
            // 
            // DecryptMenu
            // 
            this.DecryptMenu.Name = "DecryptMenu";
            resources.ApplyResources(this.DecryptMenu, "DecryptMenu");
            // 
            // EncryptMenu
            // 
            this.EncryptMenu.Name = "EncryptMenu";
            resources.ApplyResources(this.EncryptMenu, "EncryptMenu");
            this.EncryptMenu.Click += new System.EventHandler(this.EncryptMenu_Click);
            // 
            // KeysCreateMenu
            // 
            this.KeysCreateMenu.Name = "KeysCreateMenu";
            resources.ApplyResources(this.KeysCreateMenu, "KeysCreateMenu");
            this.KeysCreateMenu.Click += new System.EventHandler(this.KeysCreateMenu_Click);
            // 
            // ChangeContactMenu
            // 
            this.ChangeContactMenu.Name = "ChangeContactMenu";
            resources.ApplyResources(this.ChangeContactMenu, "ChangeContactMenu");
            // 
            // ChangeKeyPairMenu
            // 
            this.ChangeKeyPairMenu.Name = "ChangeKeyPairMenu";
            resources.ApplyResources(this.ChangeKeyPairMenu, "ChangeKeyPairMenu");
            this.ChangeKeyPairMenu.Click += new System.EventHandler(this.ChangeKeyPairMenu_Click);
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
            this.CheckSignMenu});
            this.OperationsMenu.Name = "OperationsMenu";
            resources.ApplyResources(this.OperationsMenu, "OperationsMenu");
            // 
            // Main_Menu
            // 
            this.Main_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OperationsMenu,
            this.HelpMenu,
            this.OptionsMenu,
            this.ExitMenu});
            resources.ApplyResources(this.Main_Menu, "Main_Menu");
            this.Main_Menu.Name = "Main_Menu";
            // 
            // OptionsMenu
            // 
            this.OptionsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenOptionsMenu,
            this.SelectedKeysMenu,
            this.UpdateMenu});
            this.OptionsMenu.Name = "OptionsMenu";
            resources.ApplyResources(this.OptionsMenu, "OptionsMenu");
            // 
            // OpenOptionsMenu
            // 
            this.OpenOptionsMenu.Name = "OpenOptionsMenu";
            resources.ApplyResources(this.OpenOptionsMenu, "OpenOptionsMenu");
            // 
            // SelectedKeysMenu
            // 
            this.SelectedKeysMenu.Name = "SelectedKeysMenu";
            resources.ApplyResources(this.SelectedKeysMenu, "SelectedKeysMenu");
            // 
            // UpdateMenu
            // 
            this.UpdateMenu.Name = "UpdateMenu";
            resources.ApplyResources(this.UpdateMenu, "UpdateMenu");
            // 
            // ExitMenu
            // 
            this.ExitMenu.Name = "ExitMenu";
            resources.ApplyResources(this.ExitMenu, "ExitMenu");
            this.ExitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainTextbox);
            this.Controls.Add(this.Version_Label);
            this.Controls.Add(this.Main_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Main";
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
        private System.Windows.Forms.ToolStripMenuItem CheckSignMenu;
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

