﻿namespace eTouristapp.WinUI.Termini
{
    partial class frmTerminiDetalji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTerminiDetalji));
            this.pickerOd = new System.Windows.Forms.DateTimePicker();
            this.pickerDo = new System.Windows.Forms.DateTimePicker();
            this.chcboxAktivan = new System.Windows.Forms.CheckBox();
            this.cmbHotel = new System.Windows.Forms.ComboBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.txtAkcijskaCijena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.txtPopust = new System.Windows.Forms.TextBox();
            this.txtUkupnoKarata = new System.Windows.Forms.TextBox();
            this.txtZarada = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDatumPovratka = new System.Windows.Forms.TextBox();
            this.txtDatumPolaska = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnKarte = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pickerOd
            // 
            this.pickerOd.Location = new System.Drawing.Point(205, 72);
            this.pickerOd.Name = "pickerOd";
            this.pickerOd.Size = new System.Drawing.Size(224, 26);
            this.pickerOd.TabIndex = 1;
            // 
            // pickerDo
            // 
            this.pickerDo.Location = new System.Drawing.Point(205, 143);
            this.pickerDo.Name = "pickerDo";
            this.pickerDo.Size = new System.Drawing.Size(224, 26);
            this.pickerDo.TabIndex = 2;
            this.pickerDo.Validating += new System.ComponentModel.CancelEventHandler(this.pickerDo_Validating);
            // 
            // chcboxAktivan
            // 
            this.chcboxAktivan.AutoSize = true;
            this.chcboxAktivan.Location = new System.Drawing.Point(205, 210);
            this.chcboxAktivan.Name = "chcboxAktivan";
            this.chcboxAktivan.Size = new System.Drawing.Size(18, 17);
            this.chcboxAktivan.TabIndex = 3;
            this.chcboxAktivan.UseVisualStyleBackColor = true;
            // 
            // cmbHotel
            // 
            this.cmbHotel.FormattingEnabled = true;
            this.cmbHotel.Location = new System.Drawing.Point(204, 260);
            this.cmbHotel.Name = "cmbHotel";
            this.cmbHotel.Size = new System.Drawing.Size(226, 26);
            this.cmbHotel.TabIndex = 4;
            this.cmbHotel.SelectedIndexChanged += new System.EventHandler(this.cmbHotel_SelectedIndexChanged);
            this.cmbHotel.Validating += new System.ComponentModel.CancelEventHandler(this.cmbHotel_Validating);
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(206, 328);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(226, 26);
            this.txtCijena.TabIndex = 5;
            this.txtCijena.MouseLeave += new System.EventHandler(this.txtCijena_MouseLeave);
            this.txtCijena.Validating += new System.ComponentModel.CancelEventHandler(this.txtCijena_Validating);
            // 
            // txtAkcijskaCijena
            // 
            this.txtAkcijskaCijena.Location = new System.Drawing.Point(203, 454);
            this.txtAkcijskaCijena.Name = "txtAkcijskaCijena";
            this.txtAkcijskaCijena.ReadOnly = true;
            this.txtAkcijskaCijena.Size = new System.Drawing.Size(226, 26);
            this.txtAkcijskaCijena.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pocetak";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kraj";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Aktivan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Hotel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(204, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cijena";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(200, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Popust(u %)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(199, 432);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Akcijska cijena";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSacuvaj.Location = new System.Drawing.Point(316, 493);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(116, 26);
            this.btnSacuvaj.TabIndex = 15;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // txtPopust
            // 
            this.txtPopust.Location = new System.Drawing.Point(204, 394);
            this.txtPopust.Name = "txtPopust";
            this.txtPopust.Size = new System.Drawing.Size(226, 26);
            this.txtPopust.TabIndex = 16;
            this.txtPopust.MouseLeave += new System.EventHandler(this.txtPopust_MouseLeave);
            this.txtPopust.Validating += new System.ComponentModel.CancelEventHandler(this.txtPopust_Validating);
            // 
            // txtUkupnoKarata
            // 
            this.txtUkupnoKarata.Location = new System.Drawing.Point(80, 236);
            this.txtUkupnoKarata.Name = "txtUkupnoKarata";
            this.txtUkupnoKarata.ReadOnly = true;
            this.txtUkupnoKarata.Size = new System.Drawing.Size(268, 26);
            this.txtUkupnoKarata.TabIndex = 17;
            // 
            // txtZarada
            // 
            this.txtZarada.Location = new System.Drawing.Point(80, 312);
            this.txtZarada.Name = "txtZarada";
            this.txtZarada.ReadOnly = true;
            this.txtZarada.Size = new System.Drawing.Size(268, 26);
            this.txtZarada.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(76, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 18);
            this.label9.TabIndex = 19;
            this.label9.Text = "Ukupno prodatih karata";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(76, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 18);
            this.label10.TabIndex = 20;
            this.label10.Text = "Zarada u KM";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(73, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 18);
            this.label11.TabIndex = 24;
            this.label11.Text = "Datum povratka";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(73, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 18);
            this.label12.TabIndex = 23;
            this.label12.Text = "Datum polaska";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(73, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 18);
            this.label14.TabIndex = 27;
            this.label14.Text = "Naziv destinacije";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(76, 47);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.ReadOnly = true;
            this.txtNaziv.Size = new System.Drawing.Size(272, 26);
            this.txtNaziv.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDatumPovratka);
            this.panel1.Controls.Add(this.txtDatumPolaska);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtUkupnoKarata);
            this.panel1.Controls.Add(this.txtNaziv);
            this.panel1.Controls.Add(this.txtZarada);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(505, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 350);
            this.panel1.TabIndex = 28;
            // 
            // txtDatumPovratka
            // 
            this.txtDatumPovratka.Location = new System.Drawing.Point(80, 176);
            this.txtDatumPovratka.Name = "txtDatumPovratka";
            this.txtDatumPovratka.ReadOnly = true;
            this.txtDatumPovratka.Size = new System.Drawing.Size(268, 26);
            this.txtDatumPovratka.TabIndex = 31;
            // 
            // txtDatumPolaska
            // 
            this.txtDatumPolaska.Location = new System.Drawing.Point(80, 106);
            this.txtDatumPolaska.Name = "txtDatumPolaska";
            this.txtDatumPolaska.ReadOnly = true;
            this.txtDatumPolaska.Size = new System.Drawing.Size(268, 26);
            this.txtDatumPolaska.TabIndex = 30;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPrint.Location = new System.Drawing.Point(792, 432);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(84, 26);
            this.btnPrint.TabIndex = 29;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnObrisi.Location = new System.Drawing.Point(792, 493);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(84, 26);
            this.btnObrisi.TabIndex = 29;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnKarte
            // 
            this.btnKarte.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnKarte.Location = new System.Drawing.Point(498, 432);
            this.btnKarte.Name = "btnKarte";
            this.btnKarte.Size = new System.Drawing.Size(213, 26);
            this.btnKarte.TabIndex = 30;
            this.btnKarte.Text = "Pregled karata za termin";
            this.btnKarte.UseVisualStyleBackColor = false;
            this.btnKarte.Click += new System.EventHandler(this.btnKarte_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 530);
            this.panel2.TabIndex = 31;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(165, 173);
            this.panel4.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(14, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(132, 112);
            this.panel3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(10, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "eTourist";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(169, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(731, 43);
            this.panel5.TabIndex = 32;
            // 
            // frmTerminiDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(900, 530);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnKarte);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtPopust);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAkcijskaCijena);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.cmbHotel);
            this.Controls.Add(this.chcboxAktivan);
            this.Controls.Add(this.pickerDo);
            this.Controls.Add(this.pickerOd);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "frmTerminiDetalji";
            this.Text = "frmTerminiDetalji";
            this.Load += new System.EventHandler(this.frmTerminiDetalji_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker pickerOd;
        private System.Windows.Forms.DateTimePicker pickerDo;
        private System.Windows.Forms.CheckBox chcboxAktivan;
        private System.Windows.Forms.ComboBox cmbHotel;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.TextBox txtAkcijskaCijena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TextBox txtPopust;
        private System.Windows.Forms.TextBox txtUkupnoKarata;
        private System.Windows.Forms.TextBox txtZarada;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.TextBox txtDatumPovratka;
        private System.Windows.Forms.TextBox txtDatumPolaska;
        private System.Windows.Forms.Button btnKarte;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
    }
}