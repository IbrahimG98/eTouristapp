using eProdaja.Mobile;
using eTouristapp.Models;
using eTouristapp.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml;
using Xamarin.Forms;

namespace eTouristapp.Mobile.ViewModels
{
    public class DodajOcjeneViewModel:BaseViewModel
    {
        private readonly APIService _ocjeneservice = new APIService("Ocjene");
        private readonly APIService _korisniciservice = new APIService("Korisnici");
        public int? DestinacijaID = null;
        public DodajOcjeneViewModel()
        {
            //DKomentar = new Command(async () => await DodajKomentar());
            
        }

        string _komentar = string.Empty;
        public string Komentar
        {
            get { return _komentar; }
            set { SetProperty(ref _komentar, value); }
        }

        int? _ocjena = null;
        public int? Ocjena
        {
            get { return _ocjena; }
            set { SetProperty(ref _ocjena, value); }
        }
        public ICommand DKomentar { get; set; }
        public async Task DodajKomentar()
        {
            KorisniciSearchRequest ksr = new KorisniciSearchRequest()
            {
                KorisnickoIme = APIService.Username
            };
            var k = await _korisniciservice.Get<List<Korisnik>>(ksr);
            OcjenaInsertRequest ocj = new OcjenaInsertRequest()
            {
                KorisnikId=k.FirstOrDefault().Id,
                DestinacijaId=DestinacijaID,
                Komentar=Komentar,
                OcjenaUsluge=int.Parse(Ocjena.ToString())
            };

           

            await _ocjeneservice.Insert<Ocjena>(ocj);
            
        }


    }
}
