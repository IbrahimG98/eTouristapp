namespace eTouristapp.WinUI
{
    partial class frmIndex
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIndex));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.korisnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviKorisnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.destinacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.novaDestinacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hoteliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.noviHotelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podrucjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontinentiPretragaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviKontinentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drzavePretragaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaDrzavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradoviPretragaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviGradToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printPreviewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisnikToolStripMenuItem,
            this.destinacijeToolStripMenuItem,
            this.hoteliToolStripMenuItem,
            this.podrucjaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(843, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // korisnikToolStripMenuItem
            // 
            this.korisnikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem,
            this.noviKorisnikToolStripMenuItem});
            this.korisnikToolStripMenuItem.Name = "korisnikToolStripMenuItem";
            this.korisnikToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.korisnikToolStripMenuItem.Text = "Korisnik";
            // 
            // pretragaToolStripMenuItem
            // 
            this.pretragaToolStripMenuItem.Name = "pretragaToolStripMenuItem";
            this.pretragaToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.pretragaToolStripMenuItem.Text = "Pretraga";
            this.pretragaToolStripMenuItem.Click += new System.EventHandler(this.pretragaToolStripMenuItem_Click);
            // 
            // noviKorisnikToolStripMenuItem
            // 
            this.noviKorisnikToolStripMenuItem.Name = "noviKorisnikToolStripMenuItem";
            this.noviKorisnikToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.noviKorisnikToolStripMenuItem.Text = "Novi korisnik";
            this.noviKorisnikToolStripMenuItem.Click += new System.EventHandler(this.noviKorisnikToolStripMenuItem_Click);
            // 
            // destinacijeToolStripMenuItem
            // 
            this.destinacijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem1,
            this.novaDestinacijaToolStripMenuItem});
            this.destinacijeToolStripMenuItem.Name = "destinacijeToolStripMenuItem";
            this.destinacijeToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.destinacijeToolStripMenuItem.Text = "Destinacije";
            // 
            // pretragaToolStripMenuItem1
            // 
            this.pretragaToolStripMenuItem1.Name = "pretragaToolStripMenuItem1";
            this.pretragaToolStripMenuItem1.Size = new System.Drawing.Size(202, 26);
            this.pretragaToolStripMenuItem1.Text = "Pretraga";
            this.pretragaToolStripMenuItem1.Click += new System.EventHandler(this.pretragaToolStripMenuItem1_Click);
            // 
            // novaDestinacijaToolStripMenuItem
            // 
            this.novaDestinacijaToolStripMenuItem.Name = "novaDestinacijaToolStripMenuItem";
            this.novaDestinacijaToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.novaDestinacijaToolStripMenuItem.Text = "Nova destinacija";
            this.novaDestinacijaToolStripMenuItem.Click += new System.EventHandler(this.novaDestinacijaToolStripMenuItem_Click);
            // 
            // hoteliToolStripMenuItem
            // 
            this.hoteliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem2,
            this.noviHotelToolStripMenuItem});
            this.hoteliToolStripMenuItem.Name = "hoteliToolStripMenuItem";
            this.hoteliToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.hoteliToolStripMenuItem.Text = "Hoteli";
            // 
            // pretragaToolStripMenuItem2
            // 
            this.pretragaToolStripMenuItem2.Name = "pretragaToolStripMenuItem2";
            this.pretragaToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.pretragaToolStripMenuItem2.Text = "Pretraga";
            this.pretragaToolStripMenuItem2.Click += new System.EventHandler(this.pretragaToolStripMenuItem2_Click);
            // 
            // noviHotelToolStripMenuItem
            // 
            this.noviHotelToolStripMenuItem.Name = "noviHotelToolStripMenuItem";
            this.noviHotelToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.noviHotelToolStripMenuItem.Text = "Novi hotel";
            this.noviHotelToolStripMenuItem.Click += new System.EventHandler(this.noviHotelToolStripMenuItem_Click);
            // 
            // podrucjaToolStripMenuItem
            // 
            this.podrucjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kontinentiPretragaToolStripMenuItem,
            this.noviKontinentToolStripMenuItem,
            this.drzavePretragaToolStripMenuItem,
            this.novaDrzavaToolStripMenuItem,
            this.gradoviPretragaToolStripMenuItem,
            this.noviGradToolStripMenuItem});
            this.podrucjaToolStripMenuItem.Name = "podrucjaToolStripMenuItem";
            this.podrucjaToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.podrucjaToolStripMenuItem.Text = "Podrucja";
            // 
            // kontinentiPretragaToolStripMenuItem
            // 
            this.kontinentiPretragaToolStripMenuItem.Name = "kontinentiPretragaToolStripMenuItem";
            this.kontinentiPretragaToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.kontinentiPretragaToolStripMenuItem.Text = "Kontinenti pretraga";
            this.kontinentiPretragaToolStripMenuItem.Click += new System.EventHandler(this.kontinentiPretragaToolStripMenuItem_Click);
            // 
            // noviKontinentToolStripMenuItem
            // 
            this.noviKontinentToolStripMenuItem.Name = "noviKontinentToolStripMenuItem";
            this.noviKontinentToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.noviKontinentToolStripMenuItem.Text = "Novi kontinent";
            this.noviKontinentToolStripMenuItem.Click += new System.EventHandler(this.noviKontinentToolStripMenuItem_Click);
            // 
            // drzavePretragaToolStripMenuItem
            // 
            this.drzavePretragaToolStripMenuItem.Name = "drzavePretragaToolStripMenuItem";
            this.drzavePretragaToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.drzavePretragaToolStripMenuItem.Text = "Drzave pretraga";
            this.drzavePretragaToolStripMenuItem.Click += new System.EventHandler(this.drzavePretragaToolStripMenuItem_Click);
            // 
            // novaDrzavaToolStripMenuItem
            // 
            this.novaDrzavaToolStripMenuItem.Name = "novaDrzavaToolStripMenuItem";
            this.novaDrzavaToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.novaDrzavaToolStripMenuItem.Text = "Nova drzava";
            this.novaDrzavaToolStripMenuItem.Click += new System.EventHandler(this.novaDrzavaToolStripMenuItem_Click);
            // 
            // gradoviPretragaToolStripMenuItem
            // 
            this.gradoviPretragaToolStripMenuItem.Name = "gradoviPretragaToolStripMenuItem";
            this.gradoviPretragaToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.gradoviPretragaToolStripMenuItem.Text = "Gradovi pretraga";
            this.gradoviPretragaToolStripMenuItem.Click += new System.EventHandler(this.gradoviPretragaToolStripMenuItem_Click);
            // 
            // noviGradToolStripMenuItem
            // 
            this.noviGradToolStripMenuItem.Name = "noviGradToolStripMenuItem";
            this.noviGradToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.noviGradToolStripMenuItem.Text = "Novi grad";
            this.noviGradToolStripMenuItem.Click += new System.EventHandler(this.noviGradToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator1,
            this.printToolStripButton,
            this.printPreviewToolStripButton,
            this.toolStripSeparator2,
            this.helpToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 28);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(843, 27);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.newToolStripButton.Text = "New";
            this.newToolStripButton.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.openToolStripButton.Text = "Open";
            this.openToolStripButton.Click += new System.EventHandler(this.OpenFile);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.saveToolStripButton.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.printToolStripButton.Text = "Print";
            // 
            // printPreviewToolStripButton
            // 
            this.printPreviewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printPreviewToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripButton.Image")));
            this.printPreviewToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.printPreviewToolStripButton.Name = "printPreviewToolStripButton";
            this.printPreviewToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.printPreviewToolStripButton.Text = "Print Preview";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.helpToolStripButton.Text = "Help";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 532);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(843, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmIndex";
            this.Text = "frmIndex";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripButton printPreviewToolStripButton;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem korisnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviKorisnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem destinacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem novaDestinacijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hoteliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem noviHotelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem podrucjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kontinentiPretragaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviKontinentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drzavePretragaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaDrzavaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradoviPretragaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviGradToolStripMenuItem;
    }
}



