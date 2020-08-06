using eTouristapp.Models.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Http.ModelBinding;
using System.Windows.Forms;

namespace eTouristapp.WinUI.Korisnici
{
    
    public partial class frmKorisniciDetalji : Form
    {
        private readonly APIService _service = new APIService("Korisnici");
        private readonly APIService _ulogeservice = new APIService("Uloge");
        private int? _id = null;
        public frmKorisniciDetalji(int? id=null)
        {
            InitializeComponent();
            _id = id;

        }
       private async Task LoadUloge()
        {
            var uloge = await _ulogeservice.Get<List<Models.Uloga>>(null);
            uloge.Insert(0, new Models.Uloga());
            cmbUloge.DataSource = uloge;
            cmbUloge.ValueMember = "Id";
            cmbUloge.DisplayMember = "Naziv";
            cmbUloge.SelectedValue = 0;

        }
        private async void frmKorisniciDetalji_Load(object sender, EventArgs e)
        {

            await LoadUloge();
            cmbUloge.SelectedValue = 0;
            if(_id.HasValue)
            {
                var korisnik = await _service.GetById<Models.Korisnik>(_id);
                txtIme.Text = korisnik.Ime;
                txtPrezime.Text = korisnik.Prezime;
                txtEmail.Text = korisnik.Email;
                txtKorisnickoIme.Text = korisnik.KorisnikoIme;
                cmbUloge.SelectedValue = korisnik.UlogaId;
                txtLozinka.Text = " ";
                txtLozinkapotvrda.Text =" ";
                
            }
        }
        Regex myregex = new Regex("[A-Za-z]{2,30}[@][A-Za-z]{2,8}[.][A-Za-z]{2,7}");
        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            //this.ValidateChildren();
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



            //if (korisnik.Ime != null && korisnik.UlogaId != 0 && korisnik.KorisnikoIme != null && korisnik.Email != null && myregex.IsMatch(korisnik.Email)
            //    && korisnik.Prezime != null && !string.IsNullOrWhiteSpace(korisnik.Password) && !string.IsNullOrWhiteSpace(korisnik.PasswordPotvrda) && korisnik.Password == korisnik.PasswordPotvrda)
            //{

            if (this.ValidateChildren())
            {

            
                if (_id.HasValue)
                {
                    await _service.Update<KorisniciInsertRequest>(_id, korisnik);
                    MessageBox.Show("Uspjesna izmjena!");
                    this.Close();
                }
                else
                {



                    await _service.Insert<KorisniciInsertRequest>(korisnik);
                    MessageBox.Show("Uspjesno dodavanje");
                    this.Close();

                }
            }
            //}



        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtIme.Text) || string.IsNullOrEmpty(txtIme.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtIme, "Obavezno polje!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtIme, null);
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text) || string.IsNullOrEmpty(txtPrezime.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPrezime, "Obavezno polje!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPrezime, null);
            }
        }

        private void txtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKorisnickoIme.Text) || string.IsNullOrEmpty(txtKorisnickoIme.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtKorisnickoIme, "Obavezno polje!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtKorisnickoIme, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "Obavezno polje!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, null);
            }

            if (!myregex.IsMatch(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "Netacan format! example@exam.domain");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, null);
            }
        }

        private void txtLozinka_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLozinka.Text) || string.IsNullOrEmpty(txtLozinka.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtLozinka, "Obavezno polje!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtLozinka, null);
            }

        }

        private void txtLozinkapotvrda_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLozinkapotvrda.Text) || string.IsNullOrEmpty(txtLozinkapotvrda.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtLozinkapotvrda, "Obavezno polje!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtLozinkapotvrda, null);
            }
        }

        private async void btnObrisi_Click(object sender, EventArgs e)
        {
            if(_id.HasValue)
            {
                await _service.Delete<Models.Korisnik>(_id);
                MessageBox.Show("Uspjesno obrisano!");
                this.Close();
            }
        }

        private void cmbUloge_Validating(object sender, CancelEventArgs e)
        {
            if(int.Parse(cmbUloge.SelectedValue.ToString())==0 || cmbUloge.SelectedValue==null || cmbUloge.SelectedIndex==0)
            {
                e.Cancel = true;
                errorProvider1.SetError(cmbUloge, "Odaberite vrijednost");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cmbUloge, null);
            }
        }
    }
}
