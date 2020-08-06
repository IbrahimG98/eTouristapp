using eProdaja.Mobile;
using eTouristapp.Models;
using eTouristapp.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eTouristapp.Mobile.ViewModels
{
    public class RegistracijaViewModel:BaseViewModel
    {

        private readonly APIService _service = new APIService("Korisnici");//ili destinacije
        private readonly APIService _ulogeservice = new APIService("Uloge");

        public RegistracijaViewModel()
        {
            
        }
        Regex myregex = new Regex("[A-Za-z]{2,30}[@][A-Za-z]{2,8}[.][A-Za-z]{2,7}");
        string _ime = string.Empty;
        public string Ime
        {
            get { return _ime; }
            set { SetProperty(ref _ime, value); }
        }

        string _prezime = string.Empty;
        public string Prezime
        {
            get { return _prezime; }
            set { SetProperty(ref _prezime, value); }
        }

        string _korisnickoime = string.Empty;
        public string KorisnickoIme
        {
            get { return _korisnickoime; }
            set { SetProperty(ref _korisnickoime, value); }
        }

        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }
        string _passwordpotvrda = string.Empty;
        public string PasswordPotvrda
        {
            get { return _passwordpotvrda; }
            set { SetProperty(ref _passwordpotvrda, value); }
        }

        string _email = string.Empty;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }
        
        public async Task Registracija()
        {
           
            KorisniciInsertRequest korisnik = new KorisniciInsertRequest()
            {
                Ime = Ime,
                KorisnikoIme=KorisnickoIme,
                Prezime = Prezime,
                UlogaId=1,//putnik
                Email=Email,
                Password=Password,
                PasswordPotvrda=PasswordPotvrda

            };

            if(!string.IsNullOrWhiteSpace(korisnik.Ime) && !string.IsNullOrWhiteSpace(korisnik.KorisnikoIme) && !string.IsNullOrWhiteSpace(korisnik.Prezime) &&
                !string.IsNullOrWhiteSpace(korisnik.Email) && myregex.IsMatch(korisnik.Email) && !string.IsNullOrWhiteSpace(korisnik.Password) &&
                !string.IsNullOrWhiteSpace(korisnik.PasswordPotvrda) && korisnik.Password==korisnik.PasswordPotvrda)
            {
                await _service.Insert<KorisniciInsertRequest>(korisnik);
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Greska", "Podaci nisu ispravni", "OK");
            }
            
        }
        


    }
}
