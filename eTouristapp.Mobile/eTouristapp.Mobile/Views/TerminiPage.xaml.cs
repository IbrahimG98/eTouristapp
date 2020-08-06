using eProdaja.Mobile;
using eTouristapp.Mobile.ViewModels;
using eTouristapp.Models;
using eTouristapp.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace eTouristapp.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TerminiPage : ContentPage
    {
        TerminiViewModel model = new TerminiViewModel();
        private readonly APIService _karte = new APIService("Karte");
        private readonly APIService _korisniciservice = new APIService("Korisnici");

        public TerminiPage(int destinacijaid)
        {
            InitializeComponent();
            BindingContext = model = new TerminiViewModel()
            {
                DestinacijaID = int.Parse(destinacijaid.ToString())
            };
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Load();
        }
        KartaInsertRequest karta = null;
        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                var termin = e.SelectedItem as Termin;
                KorisniciSearchRequest ksr = new KorisniciSearchRequest()
                {
                    KorisnickoIme = APIService.Username
                };
                var k = await _korisniciservice.Get<List<Korisnik>>(ksr);


                karta = new KartaInsertRequest();
                karta.KorisnikId = k.FirstOrDefault().Id;
                karta.Ponistena = false;
                karta.DatumKreiranja = System.DateTime.Now;
                karta.TerminId = termin.Id;

                

                

                //await _karte.Insert<KartaInsertRequest>(karta);


            }

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            bool postoji = true;
            KartaSearchRequest kartasearch = null;

            if (karta != null)
            {


                kartasearch = new KartaSearchRequest();

                kartasearch.KorisnikID = int.Parse(karta.KorisnikId.ToString());
                kartasearch.TerminID = int.Parse(karta.TerminId.ToString());
                kartasearch.Ponistena = false;

               
            }

            var provjera = await _karte.Get<List<Karta>>(kartasearch);
            if(provjera.Count==0)
            {
                postoji = false;
            }


            if (karta != null && postoji == false)
            {
                await _karte.Insert<KartaInsertRequest>(karta);
                
            }
           

           

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(model.DestinacijaID.ToString());
            Navigation.PushAsync(new OcjenePage(id));

        }
    }
}