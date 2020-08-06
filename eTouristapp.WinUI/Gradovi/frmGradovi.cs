using eTouristapp.Models.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eTouristapp.WinUI.Gradovi
{
    public partial class frmGradovi : Form
    {
        private readonly APIService _grad = new APIService("Grad");
        private readonly APIService _gradovi = new APIService("Gradovi");
        private readonly APIService _drzave = new APIService("Drzave");
        private readonly APIService _kontinenti = new APIService("Kontinenti");

        public frmGradovi()
        {
            InitializeComponent();
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            GradoviSearchRequest search = new GradoviSearchRequest()
            {
                Naziv=txtNaziv.Text,
                DrzavaId=int.Parse(cmbDrzave.SelectedValue.ToString())

            };
            if (this.ValidateChildren())
            {
                var result = await _gradovi.Get<List<Models.Grad>>(search);
                dgvGradovi.AutoGenerateColumns = false;
                dgvGradovi.DataSource = result;
            }
        }
        
        async Task LoadKontinenti()
        {
            var result = await _kontinenti.Get<List<Models.Kontinent>>(null);
            result.Insert(0, new Models.Kontinent());
            cmbKontinenti.DisplayMember = "Naziv";
            cmbKontinenti.ValueMember = "Id";
            cmbKontinenti.DataSource = result;
            cmbKontinenti.SelectedValue = 0;
        }
        private int? kontinentid = null;
        async Task LoadDrzave(int? id)
        {
            DrzavaSearchRequest request = new DrzavaSearchRequest()
            {
                Naziv = null,
                KontinentId = 0
            };
            if (id.HasValue)
            {
                request.KontinentId = id;
            }
            else
            {
                request.KontinentId = 0;
            }
            var result = await _drzave.Get<List<Models.Drzava>>(request);
            result.Insert(0, new Models.Drzava());
            cmbDrzave.DisplayMember = "Naziv";
            cmbDrzave.ValueMember = "Id";
            cmbDrzave.DataSource = result;
            cmbDrzave.SelectedValue = 0;
        }

        private async void frmGradovi_Load(object sender, EventArgs e)
        {
            await LoadKontinenti();
            await LoadDrzave(null);
        }

        private void dgvGradovi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvGradovi.SelectedRows[0].Cells[0].Value;
            frmGradoviDetalji frm = new frmGradoviDetalji(int.Parse(id.ToString()));
            frm.Show();
        }

        private async void cmbKontinenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            kontinentid = int.Parse(cmbKontinenti.SelectedValue.ToString());
            await LoadDrzave(kontinentid);
        }

        private void cmbKontinenti_Validating(object sender, CancelEventArgs e)
        {
            if (int.Parse(cmbKontinenti.SelectedValue.ToString()) == 0 || cmbKontinenti.SelectedValue == null || cmbKontinenti.SelectedItem == null)
            {
                e.Cancel = true;
                errorProvider1.SetError(cmbKontinenti, "Odaberite vrijednost!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cmbKontinenti, null);

            }
        }

        private void cmbDrzave_Validating(object sender, CancelEventArgs e)
        {
            if (int.Parse(cmbDrzave.SelectedValue.ToString()) == 0 || cmbDrzave.SelectedValue == null || cmbDrzave.SelectedItem == null)
            {
                e.Cancel = true;
                errorProvider1.SetError(cmbDrzave, "Odaberite vrijednost");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cmbDrzave, null);
            }
        }
    }
    
}
