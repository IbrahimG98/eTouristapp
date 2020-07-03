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

namespace eTouristapp.WinUI.Termini
{
    public partial class frmTermini : Form
    {
        private readonly APIService _termini = new APIService("Termini");
        private int? _destinacijaid = null;
        public frmTermini(int? id = null)
        {
            InitializeComponent();
            _destinacijaid = id;
        }

        private async void btnTrazi_Click(object sender, EventArgs e)
        {
            var search = new TerminSearchRequest()
            {
                DestinacijaId=int.Parse(_destinacijaid.ToString())
                //Cijena=decimal.Parse(txtCijena.Text.ToString())
                //DatumPolaska = pickerOd.Value,
                //DatumDolaska=pickerDo.Value

            };

            var result = await _termini.Get<List<Models.Termin>>(search);
            dgvTermini.AutoGenerateColumns = false;
            dgvTermini.DataSource = result;
        }

        private void dgvTermini_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvTermini.SelectedRows[0].Cells[0].Value;
            frmTerminiDetalji frm = new frmTerminiDetalji(int.Parse(_destinacijaid.ToString()), int.Parse(id.ToString()));
            frm.Show();
        }

        private void btnNoviTermin_Click(object sender, EventArgs e)
        {
            frmTerminiDetalji frm = new frmTerminiDetalji(int.Parse(_destinacijaid.ToString()), null);
            frm.Show();
        }
    }
}
