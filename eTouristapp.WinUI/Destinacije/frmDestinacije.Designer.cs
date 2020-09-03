namespace eTouristapp.WinUI.Destinacije
{
    partial class frmDestinacije
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
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDestinacije = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pretraga = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnPretraga = new System.Windows.Forms.Button();
            this.cmbKontinent = new System.Windows.Forms.ComboBox();
            this.cmbDrzava = new System.Windows.Forms.ComboBox();
            this.cmbGrad = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinacije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(12, 43);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(277, 22);
            this.txtPretraga.TabIndex = 0;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDestinacije);
            this.groupBox1.Location = new System.Drawing.Point(0, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 211);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Destinacije";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgvDestinacije
            // 
            this.dgvDestinacije.AllowUserToAddRows = false;
            this.dgvDestinacije.AllowUserToDeleteRows = false;
            this.dgvDestinacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDestinacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Naziv});
            this.dgvDestinacije.Location = new System.Drawing.Point(0, 33);
            this.dgvDestinacije.Name = "dgvDestinacije";
            this.dgvDestinacije.ReadOnly = true;
            this.dgvDestinacije.RowHeadersWidth = 51;
            this.dgvDestinacije.RowTemplate.Height = 24;
            this.dgvDestinacije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDestinacije.Size = new System.Drawing.Size(800, 209);
            this.dgvDestinacije.TabIndex = 0;
            this.dgvDestinacije.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvDestinacije_MouseDoubleClick);
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
            // Pretraga
            // 
            this.Pretraga.AutoSize = true;
            this.Pretraga.Location = new System.Drawing.Point(12, 23);
            this.Pretraga.Name = "Pretraga";
            this.Pretraga.Size = new System.Drawing.Size(63, 17);
            this.Pretraga.TabIndex = 2;
            this.Pretraga.Text = "Pretraga";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Grad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kontinent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Drzava";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(328, 207);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(86, 23);
            this.btnPretraga.TabIndex = 12;
            this.btnPretraga.Text = "Pretraga";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            this.btnPretraga.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnPretraga_MouseClick);
            // 
            // cmbKontinent
            // 
            this.cmbKontinent.FormattingEnabled = true;
            this.cmbKontinent.Location = new System.Drawing.Point(13, 102);
            this.cmbKontinent.Name = "cmbKontinent";
            this.cmbKontinent.Size = new System.Drawing.Size(258, 24);
            this.cmbKontinent.TabIndex = 13;
            this.cmbKontinent.SelectedIndexChanged += new System.EventHandler(this.cmbKontinent_SelectedIndexChanged);
            this.cmbKontinent.Validating += new System.ComponentModel.CancelEventHandler(this.cmbKontinent_Validating);
            // 
            // cmbDrzava
            // 
            this.cmbDrzava.FormattingEnabled = true;
            this.cmbDrzava.Location = new System.Drawing.Point(12, 161);
            this.cmbDrzava.Name = "cmbDrzava";
            this.cmbDrzava.Size = new System.Drawing.Size(258, 24);
            this.cmbDrzava.TabIndex = 14;
            this.cmbDrzava.SelectedIndexChanged += new System.EventHandler(this.cmbDrzava_SelectedIndexChanged);
            this.cmbDrzava.Validating += new System.ComponentModel.CancelEventHandler(this.cmbDrzava_Validating);
            // 
            // cmbGrad
            // 
            this.cmbGrad.FormattingEnabled = true;
            this.cmbGrad.Location = new System.Drawing.Point(13, 208);
            this.cmbGrad.Name = "cmbGrad";
            this.cmbGrad.Size = new System.Drawing.Size(258, 24);
            this.cmbGrad.TabIndex = 15;
            this.cmbGrad.Validating += new System.ComponentModel.CancelEventHandler(this.cmbGrad_Validating);
            // 
            // frmDestinacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbGrad);
            this.Controls.Add(this.cmbDrzava);
            this.Controls.Add(this.cmbKontinent);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pretraga);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPretraga);
            this.Name = "frmDestinacije";
            this.Text = "frmDestinacije";
            this.Load += new System.EventHandler(this.frmDestinacije_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinacije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDestinacije;
        private System.Windows.Forms.Label Pretraga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.ComboBox cmbGrad;
        private System.Windows.Forms.ComboBox cmbDrzava;
        private System.Windows.Forms.ComboBox cmbKontinent;
    }
}