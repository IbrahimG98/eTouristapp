namespace eTouristapp.WinUI.Termini
{
    partial class frmTermini
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTermini));
            this.Termini = new System.Windows.Forms.GroupBox();
            this.dgvTermini = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPolaska = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumDolaska = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktivan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pickerOd = new System.Windows.Forms.DateTimePicker();
            this.pickerDo = new System.Windows.Forms.DateTimePicker();
            this.Od = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.btnNoviTermin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chcbAktivan = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Termini.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Termini
            // 
            this.Termini.Controls.Add(this.dgvTermini);
            this.Termini.Location = new System.Drawing.Point(169, 182);
            this.Termini.Name = "Termini";
            this.Termini.Size = new System.Drawing.Size(731, 327);
            this.Termini.TabIndex = 0;
            this.Termini.TabStop = false;
            this.Termini.Text = "Termini";
            // 
            // dgvTermini
            // 
            this.dgvTermini.AllowUserToAddRows = false;
            this.dgvTermini.AllowUserToDeleteRows = false;
            this.dgvTermini.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvTermini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTermini.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DatumPolaska,
            this.DatumDolaska,
            this.Cijena,
            this.Aktivan});
            this.dgvTermini.Location = new System.Drawing.Point(0, 25);
            this.dgvTermini.Name = "dgvTermini";
            this.dgvTermini.ReadOnly = true;
            this.dgvTermini.RowHeadersWidth = 51;
            this.dgvTermini.RowTemplate.Height = 24;
            this.dgvTermini.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTermini.Size = new System.Drawing.Size(731, 291);
            this.dgvTermini.TabIndex = 0;
            this.dgvTermini.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvTermini_MouseDoubleClick);
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
            // DatumPolaska
            // 
            this.DatumPolaska.DataPropertyName = "DatumPolaska";
            this.DatumPolaska.HeaderText = "DatumPolaska";
            this.DatumPolaska.MinimumWidth = 6;
            this.DatumPolaska.Name = "DatumPolaska";
            this.DatumPolaska.ReadOnly = true;
            this.DatumPolaska.Width = 125;
            // 
            // DatumDolaska
            // 
            this.DatumDolaska.DataPropertyName = "DatumDolaska";
            this.DatumDolaska.HeaderText = "DatumDolaska";
            this.DatumDolaska.MinimumWidth = 6;
            this.DatumDolaska.Name = "DatumDolaska";
            this.DatumDolaska.ReadOnly = true;
            this.DatumDolaska.Width = 125;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.MinimumWidth = 6;
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            this.Cijena.Width = 125;
            // 
            // Aktivan
            // 
            this.Aktivan.DataPropertyName = "AktivanTermin";
            this.Aktivan.HeaderText = "Aktivan";
            this.Aktivan.MinimumWidth = 6;
            this.Aktivan.Name = "Aktivan";
            this.Aktivan.ReadOnly = true;
            this.Aktivan.Width = 125;
            // 
            // pickerOd
            // 
            this.pickerOd.Location = new System.Drawing.Point(189, 84);
            this.pickerOd.Name = "pickerOd";
            this.pickerOd.Size = new System.Drawing.Size(231, 26);
            this.pickerOd.TabIndex = 1;
            // 
            // pickerDo
            // 
            this.pickerDo.Location = new System.Drawing.Point(189, 154);
            this.pickerDo.Name = "pickerDo";
            this.pickerDo.Size = new System.Drawing.Size(231, 26);
            this.pickerDo.TabIndex = 2;
            this.pickerDo.Validating += new System.ComponentModel.CancelEventHandler(this.pickerDo_Validating);
            // 
            // Od
            // 
            this.Od.AutoSize = true;
            this.Od.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Od.Location = new System.Drawing.Point(186, 63);
            this.Od.Name = "Od";
            this.Od.Size = new System.Drawing.Size(31, 18);
            this.Od.TabIndex = 3;
            this.Od.Text = "Od";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(188, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Do";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(445, 87);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(104, 26);
            this.txtCijena.TabIndex = 5;
            this.txtCijena.Validating += new System.ComponentModel.CancelEventHandler(this.txtCijena_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(442, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cijena";
            // 
            // btnTrazi
            // 
            this.btnTrazi.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnTrazi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTrazi.Location = new System.Drawing.Point(571, 145);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(89, 37);
            this.btnTrazi.TabIndex = 7;
            this.btnTrazi.Text = "Trazi";
            this.btnTrazi.UseVisualStyleBackColor = false;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // btnNoviTermin
            // 
            this.btnNoviTermin.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNoviTermin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNoviTermin.Location = new System.Drawing.Point(767, 151);
            this.btnNoviTermin.Name = "btnNoviTermin";
            this.btnNoviTermin.Size = new System.Drawing.Size(119, 37);
            this.btnNoviTermin.TabIndex = 8;
            this.btnNoviTermin.Text = "Novi termin";
            this.btnNoviTermin.UseVisualStyleBackColor = false;
            this.btnNoviTermin.Click += new System.EventHandler(this.btnNoviTermin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(436, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Aktivan";
            // 
            // chcbAktivan
            // 
            this.chcbAktivan.AutoSize = true;
            this.chcbAktivan.Location = new System.Drawing.Point(505, 156);
            this.chcbAktivan.Name = "chcbAktivan";
            this.chcbAktivan.Size = new System.Drawing.Size(18, 17);
            this.chcbAktivan.TabIndex = 10;
            this.chcbAktivan.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 506);
            this.panel1.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.label6);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(10, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "eTourist";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(169, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(731, 43);
            this.panel2.TabIndex = 19;
            // 
            // frmTermini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(900, 506);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chcbAktivan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNoviTermin);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Od);
            this.Controls.Add(this.pickerDo);
            this.Controls.Add(this.pickerOd);
            this.Controls.Add(this.Termini);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmTermini";
            this.Text = "frmTermini";
            this.Load += new System.EventHandler(this.frmTermini_Load);
            this.Termini.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Termini;
        private System.Windows.Forms.DataGridView dgvTermini;
        private System.Windows.Forms.DateTimePicker pickerOd;
        private System.Windows.Forms.DateTimePicker pickerDo;
        private System.Windows.Forms.Label Od;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.Button btnNoviTermin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPolaska;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumDolaska;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aktivan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chcbAktivan;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
    }
}