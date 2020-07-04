using eTouristapp.Models.Request;
using eTouristapp.WinUI.Termini;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eTouristapp.WinUI.Destinacije
{
    
    public partial class frmDestinacijeDetalji : Form
    {
        private readonly APIService _gradovi = new APIService("Grad");
        private readonly APIService _destinacija = new APIService("Destinacije");
        
        private int? _id = null;
        public frmDestinacijeDetalji(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }
        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }
        private async void frmDestinacijeDetalji_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var destinacija = await _destinacija.GetById<Models.Destinacija>(_id);
                txtNaziv.Text = destinacija.Naziv;
                
               
                
                pbSlika.Image = ByteToImage(destinacija.Slika);

                var result = await _gradovi.Get<List<Models.Grad>>(null);

               
                des.Slika = destinacija.Slika;

                cmbGrad.DisplayMember = "Naziv";
                cmbGrad.ValueMember = "Id";
                
                cmbGrad.DataSource = result;
                cmbGrad.SelectedValue = destinacija.GradId; //radi novog itema u cmblisti
                                                              //implementirati update 


            }
            else
            {
                await LoadGradovi();
            }
            
        }

        private async Task LoadGradovi()
        {
            var result = await _gradovi.Get<List<Models.Grad>>(null);
            result.Insert(0, new Models.Grad());
            cmbGrad.DisplayMember = "Naziv";
            cmbGrad.ValueMember = "Id";
            cmbGrad.DataSource = result;
        }
        DestinacijaInsertRequest des = new DestinacijaInsertRequest();
        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {

            

            var id = cmbGrad.SelectedValue;
            if(int.TryParse(id.ToString(),out int GradId))
            {
                des.GradId = GradId;
            }
            des.Naziv = txtNaziv.Text;
            
            
            if (_id.HasValue)
            {
                await _destinacija.Update<DestinacijaInsertRequest>(_id, des);
            }
            else
            {
                await _destinacija.Insert<DestinacijaInsertRequest>(des);
            }
            MessageBox.Show("Operacija uspjesna");
            this.Close();
            
        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if(result== DialogResult.OK)
            {
                var filename = openFileDialog1.FileName;
                var fileslika = File.ReadAllBytes(filename);
                des.Slika = fileslika;
                txtSlika.Text= filename;

                Image image = Image.FromFile(filename);
                pbSlika.Image = image;

            }
        }
        //private Image Resize(Image img,int iWidth,int iHeight)
        //{
        //    Bitmap bmp = new Bitmap(iWidth, iHeight);
        //    Graphics graphic = Graphics.FromImage((Image)bmp);
        //    graphic.DrawImage(img, 0, 0, iWidth, iHeight);
        //    return (Image)bmp;
        //}

        private void btnTermini_Click(object sender, EventArgs e)
        {
             if(_id.HasValue)
            {
                frmTermini frm = new frmTermini(int.Parse(_id.ToString()));
                frm.Show();
            }
        }

        private void btnNoviTermin_Click(object sender, EventArgs e)
        {
            //if (_id.HasValue)
            //{
            //    frmTerminiDetalji frm = new frmTerminiDetalji(int.Parse(_id.ToString()), null);
            //    frm.Show();
            //}

        }

        private async void btnObrisi_Click(object sender, EventArgs e)
        {
            if(_id.HasValue)
            {
                await _destinacija.Delete<bool>(_id);
                this.Close();
            }
        }
    }
}
