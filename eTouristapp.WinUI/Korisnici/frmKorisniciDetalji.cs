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

namespace eTouristapp.WinUI.Korisnici
{
    
    public partial class frmKorisniciDetalji : Form
    {
        private readonly APIService _service = new APIService("Korisnici");
        private readonly APIService _putniciservice = new APIService("Putnici");

        private readonly APIService _ulogeservice = new APIService("Uloge");
        private int? _id = null;
        public frmKorisniciDetalji(int? id=null)
        {
            InitializeComponent();
            _id = id;

        }

        private async void frmKorisniciDetalji_Load(object sender, EventArgs e)
        {
            var uloge = await _ulogeservice.Get<List<Models.Uloga>>(null);
            uloge.Insert(0, new Models.Uloga());
            cmbUloge.DataSource = uloge;
            cmbUloge.ValueMember = "Id";
            cmbUloge.DisplayMember = "Naziv";

            if(_id.HasValue)
            {
                var korisnik = await _service.GetById<Models.Korisnik>(_id);
                txtIme.Text = korisnik.Ime;
                txtPrezime.Text = korisnik.Prezime;
                txtEmail.Text = korisnik.Email;
                txtKorisnickoIme.Text = korisnik.KorisnikoIme;
                
            }
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {

            KorisniciInsertRequest korisnik = new KorisniciInsertRequest()
            {
                Ime=txtIme.Text,
                Prezime=txtPrezime.Text,
                Email=txtEmail.Text,
                KorisnikoIme=txtKorisnickoIme.Text,
                Password=txtLozinka.Text,
                PasswordPotvrda=txtLozinkapotvrda.Text,
                UlogaId=int.Parse(cmbUloge.SelectedValue.ToString())
            };

            if(_id.HasValue)
            {
                await _service.Update<Models.Korisnik>(_id, korisnik);
            }
            else
            {
                //if(korisnik.UlogaId==1)
                //{
                //    PutnikInsertRequest putnik = new PutnikInsertRequest()
                //    {
                //        KorisnikId=korisnik.Id,
                //        DatumRegistracije
                //    };
                //    await _putniciservice.Insert<Models.Putnik>(putnik);
                //}
                await _service.Insert<Models.Korisnik>(korisnik);
            }
            MessageBox.Show("Operacija uspjesna");

        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtIme.Text))
            {
                errorProvider1.SetError(txtIme, "Obavezno polje!");
            }
            else
            {
                errorProvider1.SetError(txtIme, null);
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                errorProvider1.SetError(txtPrezime, "Obavezno polje!");
            }
            else
            {
                errorProvider1.SetError(txtPrezime, null);
            }
        }

        private void txtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKorisnickoIme.Text))
            {
                errorProvider1.SetError(txtKorisnickoIme, "Obavezno polje!");
            }
            else
            {
                errorProvider1.SetError(txtKorisnickoIme, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Obavezno polje!");
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            }
        }

        private void txtLozinka_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLozinka.Text))
            {
                errorProvider1.SetError(txtLozinka, "Obavezno polje!");
            }
            else
            {
                errorProvider1.SetError(txtLozinka, null);
            }

        }

        private void txtLozinkapotvrda_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLozinkapotvrda.Text))
            {
                errorProvider1.SetError(txtLozinkapotvrda, "Obavezno polje!");
            }
            else
            {
                errorProvider1.SetError(txtLozinkapotvrda, null);
            }
        }

        private async void btnObrisi_Click(object sender, EventArgs e)
        {
            if(_id.HasValue)
            {
                await _service.Delete<Models.Korisnik>(_id);
                this.Close();
            }
        }
    }
}
