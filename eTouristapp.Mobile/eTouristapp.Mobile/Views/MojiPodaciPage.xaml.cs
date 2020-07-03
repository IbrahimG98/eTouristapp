using eProdaja.Mobile;
using eTouristapp.Mobile.Models;
using eTouristapp.Mobile.ViewModels;
using eTouristapp.Models;
using eTouristapp.Models.Request;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eTouristapp.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MojiPodaciPage : ContentPage
    {
        MojiPodaciViewModel model = new MojiPodaciViewModel();
        private readonly APIService _karteservice = new APIService("Karte");
        KartaInsertRequest insertkarta = null;
        int kartaid = 0;
        public MojiPodaciPage()
        {
            InitializeComponent();
            BindingContext = model = new MojiPodaciViewModel()
            {
                KarteList = new ObservableCollection<MojeKarte>()
            };
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.LoadKarte();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem!=null)
            {
                var r = e.SelectedItem as MojeKarte;
                kartaid = r.KartaId;
                var objekat = await _karteservice.GetById<Karta>(kartaid);
                insertkarta = new KartaInsertRequest();
                insertkarta.KorisnikId = objekat.KorisnikId;
                insertkarta.TerminId = objekat.TerminId;
                insertkarta.Ponistena = true;
                insertkarta.DatumKreiranja = objekat.DatumKreiranja;
                kartaid = objekat.Id;

              

            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            
            int id = kartaid;
            await _karteservice.Update<Karta>(id,insertkarta);
        }
    }
}