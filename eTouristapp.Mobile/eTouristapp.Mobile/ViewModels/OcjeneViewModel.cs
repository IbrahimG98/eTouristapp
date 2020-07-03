using eProdaja.Mobile;
using eTouristapp.Models;
using eTouristapp.Models.Request;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace eTouristapp.Mobile.ViewModels
{
    public class OcjeneViewModel:BaseViewModel
    {
        private readonly APIService _ocjeneservice = new APIService("Ocjene");
        public int? DestinacijaID = null;
        public OcjeneViewModel()
        {

        }
        public ObservableCollection<Ocjena> ListaOcjena { get; set; } = new ObservableCollection<Ocjena>();

        public ICommand LoadOcjene { get; set; }

        public async Task LoadOcjeneDestinacije()
        {

            if (DestinacijaID != null)
            {
                var search = new OcjenaSearchRequest();
                search.DestinacijaID = int.Parse(DestinacijaID.ToString());

                var list = await _ocjeneservice.Get<IEnumerable<Ocjena>>(search);
                ListaOcjena.Clear();

                foreach (var x in list)
                {
                    ListaOcjena.Add(x);
                }
            }

        }
    }
}
