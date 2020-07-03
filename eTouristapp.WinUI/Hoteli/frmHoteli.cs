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

namespace eTouristapp.WinUI.Hoteli
{
    public partial class frmHoteli : Form
    {
        private readonly APIService _hoteli = new APIService("Hoteli");
        private readonly APIService _gradovi = new APIService("Grad");
        public frmHoteli()
        {
            InitializeComponent();
        }
        private async Task LoadGradovi()
        {
            var result = await _gradovi.Get<List<Models.Grad>>(null);
            result.Insert(0, new Models.Grad());
            cmbGrad.DisplayMember = "Naziv";
            cmbGrad.ValueMember = "Id";
            cmbGrad.DataSource = result;
        }


        private void dgvHoteli_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvHoteli.SelectedRows[0].Cells[0].Value;
            frmHoteliDetalji frm = new frmHoteliDetalji(int.Parse(id.ToString()));
            frm.Show();
        }

        private async void frmHoteli_Load(object sender, EventArgs e)
        {
            await LoadGradovi();
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            var search = new HotelSearchRequest()
            {
                Naziv = txtNaziv.Text

            };

            var result = await _hoteli.Get<List<Models.Hotel>>(search);
            dgvHoteli.AutoGenerateColumns = false;
            dgvHoteli.DataSource = result;

        }
    }
}
