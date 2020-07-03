using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eTouristapp.Models.Request;
using Flurl.Http;
namespace eTouristapp.WinUI.Korisnici
{
    public partial class frmKorisnici : Form
    {
        private readonly APIService _apiService = new APIService("Korisnici");
        public frmKorisnici()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private async void btnGo_Click(object sender, EventArgs e)
        {
            var search = new KorisniciSearchRequest()
            {
                Ime=txtPretraga.Text
                

            };

            var result = await _apiService.Get<List<Models.Korisnik>>(search);
            dgvKorisnici.AutoGenerateColumns = false;
            dgvKorisnici.DataSource= result;
            
        }

        private void dgvKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvKorisnici_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvKorisnici.SelectedRows[0].Cells[0].Value;

            frmKorisniciDetalji frm = new frmKorisniciDetalji(int.Parse(id.ToString()));
            frm.Show();
            //frmKorisniciUpdate frm = new frmKorisniciUpdate(int.Parse(id.ToString()));
            //frm.Show();

        }

        private void frmKorisnici_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
