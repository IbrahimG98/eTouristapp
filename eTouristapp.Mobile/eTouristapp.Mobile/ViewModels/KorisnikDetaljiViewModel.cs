using eProdaja.Mobile;
using eTouristapp.Mobile.Models;
using eTouristapp.Models;
using eTouristapp.Models.Request;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTouristapp.Mobile.ViewModels
{
    public class KorisnikDetaljiViewModel:BaseViewModel
    {

        private readonly APIService _korisniciservice = new APIService("Korisnici");

        public KorisnikDetaljiViewModel()
        {

        }

        public ObservableCollection<KorisnikDetaljiModels> KorisnikDetalji { get; set; } = new ObservableCollection<KorisnikDetaljiModels>();

        public string _lozinka = string.Empty;
        public string Lozinka
        {
            get { return _lozinka; }
            set { SetProperty(ref _lozinka, value); }
        }

        public string _lozinkapotvrda = string.Empty;
        public string LozinkaPotvrda
        {
            get { return _lozinkapotvrda; }
            set { SetProperty(ref _lozinkapotvrda, value); }
        }

        public KorisniciInsertRequest request = new KorisniciInsertRequest();
        public async Task LoadDetalji()
        {
            KorisnikDetalji.Clear();

            KorisniciSearchRequest search = new KorisniciSearchRequest()
            {
                KorisnickoIme = APIService.Username
            };

            var listkorisnik = await _korisniciservice.Get<List<Korisnik>>(search);
            var korisnik = listkorisnik.FirstOrDefault();

            KorisnikDetaljiModels detalji = new KorisnikDetaljiModels()
            {
                Id=korisnik.Id,
                Email=korisnik.Email,
                Ime=korisnik.Ime,
                Prezime=korisnik.Prezime,
                KorisnikoIme=korisnik.KorisnikoIme,
                Slika=korisnik.Slika

            };
            KorisnikDetalji.Add(detalji);

            request.Id = korisnik.Id;
            request.Ime = korisnik.Ime;
            request.Prezime = korisnik.Prezime;
            request.Email = korisnik.Email;
            request.KorisnikoIme = korisnik.KorisnikoIme;
            request.Slika = korisnik.Slika;
            request.UlogaId = korisnik.UlogaId;

        }
    }
}
