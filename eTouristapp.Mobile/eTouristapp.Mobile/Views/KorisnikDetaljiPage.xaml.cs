using eProdaja.Mobile;
using eTouristapp.Mobile.ViewModels;
using eTouristapp.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Graphics.Display;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eTouristapp.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KorisnikDetaljiPage : ContentPage
    {
        KorisnikDetaljiViewModel model = new KorisnikDetaljiViewModel();
        private readonly APIService _korisniciservice = new APIService("Korisnici");
        public KorisnikDetaljiPage()
        {
            InitializeComponent();
            BindingContext = model = new KorisnikDetaljiViewModel()
            {

            };
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.LoadDetalji();
        }

        private async  void Button_Clicked(object sender, EventArgs e)
        {
            await model.UpdateLozinka();
            App.Current.MainPage=new KorisnikDetaljiPage();
        }
    }
}