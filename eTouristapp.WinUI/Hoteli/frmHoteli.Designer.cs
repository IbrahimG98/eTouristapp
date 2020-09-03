namespace eTouristapp.WinUI.Hoteli
{
    partial class frmHoteli
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
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.dgvHoteli = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojZvjezdica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hoteli = new System.Windows.Forms.GroupBox();
            this.Grad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbKontinent = new System.Windows.Forms.ComboBox();
            this.cmbDrzava = new System.Windows.Forms.ComboBox();
            this.cmbGrad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoteli)).BeginInit();
            this.Hoteli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(21, 32);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(400, 22);
            this.txtNaziv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naziv";
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(296, 196);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(85, 33);
            this.btnPretraga.TabIndex = 4;
            this.btnPretraga.Text = "Pretraga";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // dgvHoteli
            // 
            this.dgvHoteli.AllowUserToAddRows = false;
            this.dgvHoteli.AllowUserToDeleteRows = false;
            this.dgvHoteli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoteli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Naziv,
            this.BrojZvjezdica});
            this.dgvHoteli.Location = new System.Drawing.Point(0, 21);
            this.dgvHoteli.Name = "dgvHoteli";
            this.dgvHoteli.ReadOnly = true;
            this.dgvHoteli.RowHeadersWidth = 51;
            this.dgvHoteli.RowTemplate.Height = 24;
            this.dgvHoteli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoteli.Size = new System.Drawing.Size(798, 253);
            this.dgvHoteli.TabIndex = 5;
            this.dgvHoteli.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvHoteli_MouseDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.MinimumWidth = 6;
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            this.Naziv.Width = 125;
            // 
            // BrojZvjezdica
            // 
            this.BrojZvjezdica.DataPropertyName = "BrojZvjezdica";
            this.BrojZvjezdica.HeaderText = "BrojZvjezdica";
            this.BrojZvjezdica.MinimumWidth = 6;
            this.BrojZvjezdica.Name = "BrojZvjezdica";
            this.BrojZvjezdica.ReadOnly = true;
            this.BrojZvjezdica.Width = 125;
            // 
            // Hoteli
            // 
            this.Hoteli.Controls.Add(this.dgvHoteli);
            this.Hoteli.Location = new System.Drawing.Point(0, 234);
            this.Hoteli.Name = "Hoteli";
            this.Hoteli.Size = new System.Drawing.Size(798, 214);
            this.Hoteli.TabIndex = 6;
            this.Hoteli.TabStop = false;
            this.Hoteli.Text = "Hoteli";
            // 
            // Grad
            // 
            this.Grad.AutoSize = true;
            this.Grad.Location = new System.Drawing.Point(21, 184);
            this.Grad.Name = "Grad";
            this.Grad.Size = new System.Drawing.Size(40, 17);
            this.Grad.TabIndex = 8;
            this.Grad.Text = "Grad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kontinent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Drzava";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmbKontinent
            // 
            this.cmbKontinent.FormattingEnabled = true;
            this.cmbKontinent.Location = new System.Drawing.Point(21, 96);
            this.cmbKontinent.Name = "cmbKontinent";
            this.cmbKontinent.Size = new System.Drawing.Size(225, 24);
            this.cmbKontinent.TabIndex = 12;
            this.cmbKontinent.SelectedIndexChanged += new System.EventHandler(this.cmbKontinent_SelectedIndexChanged);
            this.cmbKontinent.Validating += new System.ComponentModel.CancelEventHandler(this.cmbKontinent_Validating);
            // 
            // cmbDrzava
            // 
            this.cmbDrzava.FormattingEnabled = true;
            this.cmbDrzava.Location = new System.Drawing.Point(21, 156);
            this.cmbDrzava.Name = "cmbDrzava";
            this.cmbDrzava.Size = new System.Drawing.Size(225, 24);
            this.cmbDrzava.TabIndex = 13;
            this.cmbDrzava.SelectedIndexChanged += new System.EventHandler(this.cmbDrzava_SelectedIndexChanged);
            this.cmbDrzava.Validating += new System.ComponentModel.CancelEventHandler(this.cmbDrzava_Validating);
            // 
            // cmbGrad
            // 
            this.cmbGrad.FormattingEnabled = true;
            this.cmbGrad.Location = new System.Drawing.Point(21, 205);
            this.cmbGrad.Name = "cmbGrad";
            this.cmbGrad.Size = new System.Drawing.Size(225, 24);
            this.cmbGrad.TabIndex = 14;
            this.cmbGrad.SelectedIndexChanged += new System.EventHandler(this.cmbGrad_SelectedIndexChanged);
            this.cmbGrad.Validating += new System.ComponentModel.CancelEventHandler(this.cmbGrad_Validating);
            // 
            // frmHoteli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbGrad);
            this.Controls.Add(this.cmbDrzava);
            this.Controls.Add(this.cmbKontinent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Grad);
            this.Controls.Add(this.Hoteli);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNaziv);
            this.Name = "frmHoteli";
            this.Text = "frmHoteli";
            this.Load += new System.EventHandler(this.frmHoteli_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoteli)).EndInit();
            this.Hoteli.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.DataGridView dgvHoteli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojZvjezdica;
        private System.Windows.Forms.GroupBox Hoteli;
        private System.Windows.Forms.Label Grad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cmbGrad;
        private System.Windows.Forms.ComboBox cmbDrzava;
        private System.Windows.Forms.ComboBox cmbKontinent;
    }
}