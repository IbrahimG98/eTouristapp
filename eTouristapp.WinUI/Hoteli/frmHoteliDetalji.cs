using eTouristapp.Models.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eTouristapp.WinUI.Hoteli
{
    public partial class frmHoteliDetalji : Form
    {
        private readonly APIService _gradovi = new APIService("Grad");
        private readonly APIService _hotel = new APIService("Hoteli");
        private int? _id = null;
        public frmHoteliDetalji(int? id = null)
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

        private async void frmHoteliDetalji_Load(object sender, EventArgs e)
        {
            if(_id.HasValue)
            {
                var hotel = await _hotel.GetById<Models.Hotel>(_id);
                txtNaziv.Text = hotel.Naziv;

                txtZvjezdice.Text = hotel.BrojZvjezdica.ToString();

                pbSlika.Image = ByteToImage(hotel.Slika);


                var result = await _gradovi.Get<List<Models.Grad>>(null);

                cmbGrad.DisplayMember = "Naziv";
                cmbGrad.ValueMember = "Id";

                cmbGrad.DataSource = result;
                cmbGrad.SelectedValue = hotel.GradId;
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
        HotelInsertRequest hot = new HotelInsertRequest();

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            var result = openFileDialog2.ShowDialog();
            if (result == DialogResult.OK)
            {
                var filename = openFileDialog2.FileName;
                var fileslika = File.ReadAllBytes(filename);
                hot.Slika = fileslika;
                txtSlika.Text = filename;

                Image image = Image.FromFile(filename);
                //image = Resize(image, 50, 50);
                pbSlika.Image = image;

            }
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var id = cmbGrad.SelectedValue;
            if (int.TryParse(id.ToString(), out int GradId))
            {
                hot.GradId = GradId;
            }
            hot.BrojZvjezdica = int.Parse(txtZvjezdice.Text.ToString());
            hot.Naziv = txtNaziv.Text;


            if (_id.HasValue)
            {
                await _hotel.Update<HotelInsertRequest>(_id, hot);
            }
            else
            {
                await _hotel.Insert<HotelInsertRequest>(hot);
            }
            MessageBox.Show("Operacija uspjesna");
            this.Close();
        }

        //private Image Resize(Image img, int iWidth, int iHeight)
        //{
        //    Bitmap bmp = new Bitmap(iWidth, iHeight);
        //    Graphics graphic = Graphics.FromImage((Image)bmp);
        //    graphic.DrawImage(img, 0, 0, iWidth, iHeight);
        //    return (Image)bmp;
        //}
    }
}
