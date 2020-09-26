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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPodrucja = new System.Windows.Forms.Button();
            this.btnDestinacije = new System.Windows.Forms.Button();
            this.btnHoteli = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
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
            this.menuStrip.Size = new System.Drawing.Size(726, 28);
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
            this.pretragaToolStripMenuItem2.Size = new System.Drawing.Size(161, 26);
            this.pretragaToolStripMenuItem2.Text = "Pretraga";
            this.pretragaToolStripMenuItem2.Click += new System.EventHandler(this.pretragaToolStripMenuItem2_Click);
            // 
            // noviHotelToolStripMenuItem
            // 
            this.noviHotelToolStripMenuItem.Name = "noviHotelToolStripMenuItem";
            this.noviHotelToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
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
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 532);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(726, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnPodrucja);
            this.panel1.Controls.Add(this.btnDestinacije);
            this.panel1.Controls.Add(this.btnHoteli);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 504);
            this.panel1.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(12, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(142, 126);
            this.panel4.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(12, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(119, 89);
            this.panel3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(8, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "eTourist";
            // 
            // btnPodrucja
            // 
            this.btnPodrucja.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPodrucja.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPodrucja.Image = ((System.Drawing.Image)(resources.GetObject("btnPodrucja.Image")));
            this.btnPodrucja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPodrucja.Location = new System.Drawing.Point(2, 384);
            this.btnPodrucja.Name = "btnPodrucja";
            this.btnPodrucja.Size = new System.Drawing.Size(160, 67);
            this.btnPodrucja.TabIndex = 6;
            this.btnPodrucja.Text = "Podrucja";
            this.btnPodrucja.UseVisualStyleBackColor = false;
            // 
            // btnDestinacije
            // 
            this.btnDestinacije.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDestinacije.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDestinacije.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDestinacije.Image = ((System.Drawing.Image)(resources.GetObject("btnDestinacije.Image")));
            this.btnDestinacije.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDestinacije.Location = new System.Drawing.Point(3, 213);
            this.btnDestinacije.Name = "btnDestinacije";
            this.btnDestinacije.Size = new System.Drawing.Size(160, 67);
            this.btnDestinacije.TabIndex = 6;
            this.btnDestinacije.Text = "  Destinacije";
            this.btnDestinacije.UseVisualStyleBackColor = false;
            this.btnDestinacije.Click += new System.EventHandler(this.btnDestinacije_Click);
            // 
            // btnHoteli
            // 
            this.btnHoteli.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnHoteli.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHoteli.Image = ((System.Drawing.Image)(resources.GetObject("btnHoteli.Image")));
            this.btnHoteli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoteli.Location = new System.Drawing.Point(2, 297);
            this.btnHoteli.Name = "btnHoteli";
            this.btnHoteli.Size = new System.Drawing.Size(160, 67);
            this.btnHoteli.TabIndex = 7;
            this.btnHoteli.Text = "Hoteli";
            this.btnHoteli.UseVisualStyleBackColor = false;
            this.btnHoteli.Click += new System.EventHandler(this.btnHoteli_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "Korisnik";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(160, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(566, 28);
            this.panel2.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(160, 56);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(566, 476);
            this.panel5.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(255, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 73);
            this.label4.TabIndex = 2;
            this.label4.Text = "u";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(164, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 73);
            this.label3.TabIndex = 1;
            this.label3.Text = "eTourist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(121, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 73);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dobrodošli";
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(726, 558);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmIndex";
            this.Text = "frmIndex";
            this.Load += new System.EventHandler(this.frmIndex_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPodrucja;
        private System.Windows.Forms.Button btnDestinacije;
        private System.Windows.Forms.Button btnHoteli;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}



