using eTouristapp.Models;
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
    public partial class frmTerminiDetalji : Form
    {
        private readonly APIService _hoteli = new APIService("Hoteli");
        private readonly APIService _termini = new APIService("Termini");
        private readonly APIService _destinacije = new APIService("Destinacije");

        private int? _id = null;
        private int? _destinacijaid = null;

        public frmTerminiDetalji(int? destinacijaid=null,int? id = null)
        {
            InitializeComponent();
            _id = id;
            _destinacijaid = destinacijaid;
        }

        private async Task LoadHoteli()
        {
            var destinacija = await _destinacije.GetById<Models.Destinacija>(_destinacijaid);
            var search = new HotelSearchRequest()
            {
                GradId=destinacija.GradId

            };
            var result = await _hoteli.Get<List<Models.Hotel>>(search);

            result.Insert(0, new Models.Hotel());
            cmbHotel.DisplayMember = "Naziv";
            cmbHotel.ValueMember = "Id";
            cmbHotel.DataSource = result;
            
        }
        private async void frmTerminiDetalji_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var termin = await _termini.GetById<Models.Termin>(_id);
                pickerOd.Value = termin.DatumPolaska;
                pickerDo.Value = termin.DatumDolaska;
                chcboxAktivan.Checked = termin.AktivanTermin;
                txtPopust.Text = termin.Popust.ToString();
                txtCijena.Text = termin.Cijena.ToString();
                txtAkcijskaCijena.Text = termin.CijenaPopust.ToString();


                //var t = await _termini.GetById<Models.Termin>(_id);
                var search = new HotelSearchRequest
                {
                    GradId = termin.GradId
                };
                var result = await _hoteli.Get<List<Models.Hotel>>(search);
                
                
                cmbHotel.DisplayMember = "Naziv";
                cmbHotel.ValueMember = "Id";

                cmbHotel.DataSource = result;
                cmbHotel.SelectedValue = termin.HotelId; //radi novog itema u cmblisti
                                                                //implementirati update 


            }
            else
            {
                await LoadHoteli();
            }


        }

        
        TerminInsertRequest tir = new TerminInsertRequest();
        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var id = cmbHotel.SelectedValue;
            if (int.TryParse(id.ToString(), out int HotelId))
            {
                tir.HotelId = HotelId;
            }
            tir.AktivanTermin = chcboxAktivan.Checked;
            tir.Cijena = decimal.Parse(txtCijena.Text.ToString());
            tir.Popust = float.Parse(txtPopust.Text.ToString());
            tir.DatumDolaska = pickerDo.Value;
            tir.DatumPolaska = pickerOd.Value;
            tir.DestinacijaId = int.Parse(_destinacijaid.ToString());
            var destinacija = await _destinacije.GetById<Models.Destinacija>(_destinacijaid);
            tir.GradId = destinacija.GradId;

            if (_id.HasValue)
            {
                await _termini.Update<Models.Termin>(_id, tir);
            }
            else
            {
                await _termini.Insert<Models.Termin>(tir);
            }
            MessageBox.Show("Operacija uspjesna");
        }
    }
}
