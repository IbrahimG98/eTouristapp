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

namespace eTouristapp.WinUI.Destinacije
{
    public partial class frmDestinacije : Form
    {
        private readonly APIService _destinacije = new APIService("Destinacije");
        private readonly APIService _gradovi = new APIService("Gradovi");
        private readonly APIService _kontinenti = new APIService("Kontinenti");
        private readonly APIService _drzave = new APIService("Drzave");

        public frmDestinacije()
        {
            InitializeComponent();
        }
        private int? kontinentid = null;
        private int? drzavaid = null;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
        async Task LoadDrzave(int? id)
        {
            DrzavaSearchRequest request = new DrzavaSearchRequest()
            {
                Naziv = null,
                KontinentId = 0
            };
            if(id.HasValue)
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
        private async Task LoadGradovi(int? id)
        {
            GradoviSearchRequest request = new GradoviSearchRequest()
            {
                Naziv = null,
                DrzavaId = 0
            };
            if (id.HasValue)
            {
                request.DrzavaId = id;
            }
            else
            {
                request.DrzavaId = 0;
            }
            
            var result = await _gradovi.Get<List<Models.Grad>>(request);
            result.Insert(0, new Models.Grad());
            cmbGrad.DisplayMember = "Naziv";
            cmbGrad.ValueMember = "Id";
            cmbGrad.DataSource = result;
            cmbGrad.SelectedValue = 0;
        }
        private async void Pretraga_Click(object sender, EventArgs e)
        {
            var search = new DestinacijaSearchRequest()
            {
                Naziv = txtPretraga.Text,
                GradId=int.Parse(cmbGrad.SelectedValue.ToString())
            };
            if (this.ValidateChildren())
            {
                var result = await _destinacije.Get<List<Models.Destinacija>>(search);
                dgvDestinacije.AutoGenerateColumns = false;
                dgvDestinacije.DataSource = result;
            }
        }

        private async void btnTrazi_Click(object sender, EventArgs e)
        {
            var search = new DestinacijaSearchRequest()
            {
                Naziv = txtPretraga.Text,
                GradId=int.Parse(cmbGrad.SelectedValue.ToString())
            };
            if (this.ValidateChildren())
            {
                var result = await _destinacije.Get<List<Models.Destinacija>>(search);
                dgvDestinacije.AutoGenerateColumns = false;
                dgvDestinacije.DataSource = result;
            }
        }

        private void dgvDestinacije_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvDestinacije.SelectedRows[0].Cells[0].Value;
            frmDestinacijeDetalji frm = new frmDestinacijeDetalji(int.Parse(id.ToString()));
            frm.Show();
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {

        }

        private async void frmDestinacije_Load(object sender, EventArgs e)
        {
            await LoadKontinenti();
            await LoadDrzave(null);
            await LoadGradovi(null);
        }

        private async void cmbKontinenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            kontinentid = int.Parse(cmbKontinenti.SelectedValue.ToString());
            await LoadDrzave(kontinentid);
        }

        private async void cmbDrzave_SelectedIndexChanged(object sender, EventArgs e)
        {
            drzavaid = int.Parse(cmbDrzave.SelectedValue.ToString());
            await LoadGradovi(drzavaid);
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
                errorProvider1.SetError(cmbDrzave, "Odaberite vrijednost!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cmbDrzave, null);

            }
        }

        private void cmbGrad_Validating(object sender, CancelEventArgs e)
        {
            if (int.Parse(cmbGrad.SelectedValue.ToString()) == 0 || cmbGrad.SelectedValue == null || cmbGrad.SelectedItem == null)
            {
                e.Cancel = true;
                errorProvider1.SetError(cmbGrad, "Odaberite vrijednost!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cmbGrad, null);

            }
        }
    }
}
