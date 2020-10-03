namespace EvilInsultGenerator
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnGenerate = new System.Windows.Forms.Button();
            this.rtxtInsult = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.combLang = new System.Windows.Forms.ToolStripComboBox();
            this.btnCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.websiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facebookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.legalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proposalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newsletterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.AutoSize = true;
            this.btnGenerate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnGenerate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnGenerate.Location = new System.Drawing.Point(-5, 267);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(711, 105);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "&Generate Insult";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // rtxtInsult
            // 
            this.rtxtInsult.AutoWordSelection = true;
            this.rtxtInsult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtInsult.CausesValidation = false;
            this.rtxtInsult.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rtxtInsult.DetectUrls = false;
            this.rtxtInsult.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtInsult.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rtxtInsult.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rtxtInsult.Location = new System.Drawing.Point(0, 30);
            this.rtxtInsult.MinimumSize = new System.Drawing.Size(698, 194);
            this.rtxtInsult.Name = "rtxtInsult";
            this.rtxtInsult.ReadOnly = true;
            this.rtxtInsult.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxtInsult.Size = new System.Drawing.Size(698, 241);
            this.rtxtInsult.TabIndex = 3;
            this.rtxtInsult.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.combLang,
            this.btnCopy,
            this.updateCheckToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(699, 27);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // combLang
            // 
            this.combLang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combLang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combLang.AutoToolTip = true;
            this.combLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combLang.DropDownWidth = 80;
            this.combLang.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.combLang.ForeColor = System.Drawing.SystemColors.Highlight;
            this.combLang.Items.AddRange(new object[] {
            "en",
            "zh",
            "es",
            "hi",
            "ar",
            "pt",
            "bn",
            "ru",
            "ja",
            "jv",
            "sw",
            "de",
            "ko",
            "fr",
            "te",
            "mr",
            "tr",
            "ta",
            "vi",
            "ur",
            "el",
            "it",
            "cs",
            "la"});
            this.combLang.Name = "combLang";
            this.combLang.Size = new System.Drawing.Size(80, 23);
            this.combLang.ToolTipText = "Language Selection";
            // 
            // btnCopy
            // 
            this.btnCopy.CheckOnClick = true;
            this.btnCopy.Image = global::EvilInsultGenerator.Properties.Resources.Clipboard;
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.btnCopy.ShowShortcutKeys = false;
            this.btnCopy.Size = new System.Drawing.Size(28, 23);
            this.btnCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btnCopy.ToolTipText = "Copy to Clipboard";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // updateCheckToolStripMenuItem
            // 
            this.updateCheckToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.updateCheckToolStripMenuItem.Image = global::EvilInsultGenerator.Properties.Resources.Update;
            this.updateCheckToolStripMenuItem.Name = "updateCheckToolStripMenuItem";
            this.updateCheckToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.updateCheckToolStripMenuItem.Size = new System.Drawing.Size(111, 23);
            this.updateCheckToolStripMenuItem.Text = "Update-Check";
            this.updateCheckToolStripMenuItem.ToolTipText = "Check for Updates";
            this.updateCheckToolStripMenuItem.Click += new System.EventHandler(this.updateCheckToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.websiteToolStripMenuItem,
            this.proposalToolStripMenuItem,
            this.contactToolStripMenuItem,
            this.newsletterToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.infoToolStripMenuItem.Image = global::EvilInsultGenerator.Properties.Resources.Info_menu;
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(56, 23);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // websiteToolStripMenuItem
            // 
            this.websiteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gitHubToolStripMenuItem,
            this.facebookToolStripMenuItem,
            this.twitterToolStripMenuItem,
            this.legalToolStripMenuItem});
            this.websiteToolStripMenuItem.Image = global::EvilInsultGenerator.Properties.Resources.eig32;
            this.websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
            this.websiteToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.websiteToolStripMenuItem.Text = "Website";
            this.websiteToolStripMenuItem.Click += new System.EventHandler(this.websiteToolStripMenuItem_Click);
            // 
            // gitHubToolStripMenuItem
            // 
            this.gitHubToolStripMenuItem.Image = global::EvilInsultGenerator.Properties.Resources.GitHub;
            this.gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
            this.gitHubToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.gitHubToolStripMenuItem.Text = "GitHub";
            // 
            // facebookToolStripMenuItem
            // 
            this.facebookToolStripMenuItem.Image = global::EvilInsultGenerator.Properties.Resources.Facebook;
            this.facebookToolStripMenuItem.Name = "facebookToolStripMenuItem";
            this.facebookToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.facebookToolStripMenuItem.Text = "Facebook";
            this.facebookToolStripMenuItem.Click += new System.EventHandler(this.facebookToolStripMenuItem_Click);
            // 
            // twitterToolStripMenuItem
            // 
            this.twitterToolStripMenuItem.Image = global::EvilInsultGenerator.Properties.Resources.Twitter;
            this.twitterToolStripMenuItem.Name = "twitterToolStripMenuItem";
            this.twitterToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.twitterToolStripMenuItem.Text = "Twitter";
            this.twitterToolStripMenuItem.Click += new System.EventHandler(this.twitterToolStripMenuItem_Click);
            // 
            // legalToolStripMenuItem
            // 
            this.legalToolStripMenuItem.Image = global::EvilInsultGenerator.Properties.Resources.Legal;
            this.legalToolStripMenuItem.Name = "legalToolStripMenuItem";
            this.legalToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.legalToolStripMenuItem.Text = "Legal";
            this.legalToolStripMenuItem.Click += new System.EventHandler(this.legalToolStripMenuItem_Click);
            // 
            // proposalToolStripMenuItem
            // 
            this.proposalToolStripMenuItem.Image = global::EvilInsultGenerator.Properties.Resources.Proposal;
            this.proposalToolStripMenuItem.Name = "proposalToolStripMenuItem";
            this.proposalToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.proposalToolStripMenuItem.Text = "Proposal";
            this.proposalToolStripMenuItem.Click += new System.EventHandler(this.proposalToolStripMenuItem_Click);
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.Image = global::EvilInsultGenerator.Properties.Resources.Contact;
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.contactToolStripMenuItem.Text = "Contact";
            this.contactToolStripMenuItem.Click += new System.EventHandler(this.contactToolStripMenuItem_Click);
            // 
            // newsletterToolStripMenuItem
            // 
            this.newsletterToolStripMenuItem.Image = global::EvilInsultGenerator.Properties.Resources.Newsletter;
            this.newsletterToolStripMenuItem.Name = "newsletterToolStripMenuItem";
            this.newsletterToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.newsletterToolStripMenuItem.Text = "Newsletter";
            this.newsletterToolStripMenuItem.Click += new System.EventHandler(this.newsletterToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::EvilInsultGenerator.Properties.Resources.Info;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(699, 371);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.rtxtInsult);
            this.Controls.Add(this.btnGenerate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(715, 410);
            this.MinimumSize = new System.Drawing.Size(715, 410);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Evil Insult Generator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtxtInsult;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem websiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCheckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem legalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proposalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newsletterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitHubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facebookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox combLang;
        private System.Windows.Forms.ToolStripMenuItem btnCopy;
    }
}

