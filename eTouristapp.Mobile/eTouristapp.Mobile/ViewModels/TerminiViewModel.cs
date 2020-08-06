using eProdaja.Mobile;
using eTouristapp.Models;
using eTouristapp.Models.Request;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eTouristapp.Mobile.ViewModels
{
    public class TerminiViewModel:BaseViewModel
    {

        private readonly APIService _terminiservice = new APIService("Termini");
        private readonly APIService _korisniciservice = new APIService("Korisnici");
        private readonly APIService _karteservice = new APIService("Karte");


        public int? DestinacijaID = null;

        
        public TerminiViewModel()
        {
        }

        public ObservableCollection<Termin> TerminiList { get; set; } = new ObservableCollection<Termin>();

        public ICommand LoadTermini { get; set; }

        public async Task Load()
        {
            
            //var termini = await _terminiservice.Get<IEnumerable<Termin>>(null);


            if (DestinacijaID != null)
            {
                var search = new TerminSearchRequest()
                {
                    Aktivan=true

                };
                search.DestinacijaId = int.Parse(DestinacijaID.ToString());

                var list = await _terminiservice.Get<IEnumerable<Termin>>(search);
                TerminiList.Clear();

                foreach (var x in list)
                {
                    TerminiList.Add(x);
                }
            }

        }

        

    }
}
