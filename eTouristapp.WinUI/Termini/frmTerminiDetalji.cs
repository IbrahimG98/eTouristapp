using eTouristapp.Models;
using eTouristapp.Models.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
        private readonly APIService _karte = new APIService("Karte");

        private int? _id = null;
        private int? _destinacijaid = null;
        PrintPreviewDialog previewDialog = new PrintPreviewDialog();
        PrintDocument printDocument = new PrintDocument();



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

        private async Task LoadZaradaiKarte()
        {
            var _termin = await _termini.GetById<Models.Termin>(_id);
            var _destinacija = await _destinacije.GetById<Models.Destinacija>(_termin.DestinacijaId);
            
            KartaSearchRequest request = new KartaSearchRequest()
            {
                TerminID=_termin.Id
            };
            var karte = await _karte.Get<List<Models.Karta>>(request);
            int brojkarata = int.Parse(karte.Count().ToString());
            float cijena = float.Parse(brojkarata.ToString()) * float.Parse(_termin.Cijena.ToString());
            
            txtUkupnoKarata.Text = brojkarata.ToString();
            txtZarada.Text= cijena.ToString();
            pickerDatump.Value = _termin.DatumPolaska;
            pickerDatumd.Value = _termin.DatumDolaska;
            txtNaziv.Text= _destinacija.Naziv;
            


        }
        private async void frmTerminiDetalji_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                await LoadZaradaiKarte();

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
            if(txtPopust.Text == null)
            {
                tir.Popust = 0;
            }
            else
            {
                tir.Popust = float.Parse(txtPopust.Text.ToString());
            }
            
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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print(this.panel1);
        }

        public void Print(Panel panel)
        {
            PrinterSettings printerSettings = new PrinterSettings();
            panel1 = panel;
            GetPrintArea(panel);
            previewDialog.Document = printDocument;
            printDocument.PrintPage += new PrintPageEventHandler(printDocPrintPage);
            previewDialog.ShowDialog();


        }

        private void printDocPrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memorying, (pagearea.Width / 2) - this.panel1.Width / 2, this.panel1.Location.Y);

        }

        Bitmap memorying;
        public void GetPrintArea(Panel panel)
        {
            memorying = new Bitmap(panel.Height, panel.Width);
            panel.DrawToBitmap(memorying, new Rectangle(0, 0, panel.Width, panel.Height));
        }
    }
}
