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
        public frmDestinacije()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private async void Pretraga_Click(object sender, EventArgs e)
        {
            var search = new DestinacijaSearchRequest()
            {
                Naziv = txtPretraga.Text
            };

            var result = await _destinacije.Get<List<Models.Destinacija>>(search);
            dgvDestinacije.AutoGenerateColumns = false;
            dgvDestinacije.DataSource = result;
        }

        private async void btnTrazi_Click(object sender, EventArgs e)
        {
            var search = new DestinacijaSearchRequest()
            {
                Naziv = txtPretraga.Text
            };

            var result = await _destinacije.Get<List<Models.Destinacija>>(search);
            dgvDestinacije.AutoGenerateColumns = false;
            dgvDestinacije.DataSource = result;
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
    }
}
