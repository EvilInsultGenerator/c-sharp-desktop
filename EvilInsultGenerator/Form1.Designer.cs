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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnGenerate = new System.Windows.Forms.Button();
            this.combLang = new System.Windows.Forms.ComboBox();
            this.rtxtInsult = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
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
            this.updateCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCopy = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGenerate.Location = new System.Drawing.Point(0, 267);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(699, 105);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "&Generate Insult";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // combLang
            // 
            this.combLang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.combLang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combLang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combLang.Font = new System.Drawing.Font("Calibri", 14F);
            this.combLang.FormattingEnabled = true;
            this.combLang.ItemHeight = 23;
            this.combLang.Items.AddRange(new object[] {
            "ar",
            "bn",
            "de",
            "el",
            "en",
            "es",
            "fr",
            "hi",
            "ja",
            "jv",
            "ko",
            "mr",
            "pt",
            "ru",
            "sw",
            "ta",
            "te",
            "tr",
            "ur",
            "vi",
            "zh"});
            this.combLang.Location = new System.Drawing.Point(313, 230);
            this.combLang.Name = "combLang";
            this.combLang.Size = new System.Drawing.Size(65, 31);
            this.combLang.Sorted = true;
            this.combLang.TabIndex = 2;
            // 
            // rtxtInsult
            // 
            this.rtxtInsult.AutoWordSelection = true;
            this.rtxtInsult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtInsult.CausesValidation = false;
            this.rtxtInsult.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rtxtInsult.DetectUrls = false;
            this.rtxtInsult.Font = new System.Drawing.Font("Arial Black", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtInsult.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.rtxtInsult.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rtxtInsult.Location = new System.Drawing.Point(0, 27);
            this.rtxtInsult.MaximumSize = new System.Drawing.Size(698, 194);
            this.rtxtInsult.MinimumSize = new System.Drawing.Size(698, 194);
            this.rtxtInsult.Name = "rtxtInsult";
            this.rtxtInsult.ReadOnly = true;
            this.rtxtInsult.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtxtInsult.Size = new System.Drawing.Size(698, 194);
            this.rtxtInsult.TabIndex = 3;
            this.rtxtInsult.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.updateCheckToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(699, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.websiteToolStripMenuItem,
            this.proposalToolStripMenuItem,
            this.contactToolStripMenuItem,
            this.newsletterToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.infoToolStripMenuItem.Image = global::EvilInsultGenerator.Properties.Resources.Info_menu;
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
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
            // updateCheckToolStripMenuItem
            // 
            this.updateCheckToolStripMenuItem.Image = global::EvilInsultGenerator.Properties.Resources.Update;
            this.updateCheckToolStripMenuItem.Name = "updateCheckToolStripMenuItem";
            this.updateCheckToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.updateCheckToolStripMenuItem.Text = "Update-Check";
            this.updateCheckToolStripMenuItem.Click += new System.EventHandler(this.updateCheckToolStripMenuItem_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.AutoSize = true;
            this.btnCopy.FlatAppearance.BorderSize = 0;
            this.btnCopy.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCopy.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnCopy.Font = new System.Drawing.Font("Calibri", 14F);
            this.btnCopy.Image = global::EvilInsultGenerator.Properties.Resources.Clipboard;
            this.btnCopy.Location = new System.Drawing.Point(381, 230);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(0);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCopy.Size = new System.Drawing.Size(34, 34);
            this.btnCopy.TabIndex = 4;
            this.btnCopy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCopy.UseMnemonic = false;
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(699, 371);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.rtxtInsult);
            this.Controls.Add(this.combLang);
            this.Controls.Add(this.btnGenerate);
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
        private System.Windows.Forms.ComboBox combLang;
        private System.Windows.Forms.RichTextBox rtxtInsult;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
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
    }
}

