using eProdaja.Mobile;
using eTouristapp.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Windows.Forms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eTouristapp.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DodajOcjenePage : ContentPage
    {
        DodajOcjeneViewModel model = new DodajOcjeneViewModel();
        private readonly APIService _ocjeneservice = new APIService("Ocjene");
        public DodajOcjenePage(int destinacijaid)
        {
            InitializeComponent();
            BindingContext = model = new DodajOcjeneViewModel()
            {

                DestinacijaID = int.Parse(destinacijaid.ToString())
            };
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            model.Ocjena = 0;
            model.Komentar = " ";
            
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
           
            await model.DodajKomentar();
            if (string.IsNullOrEmpty(model.Obavijest))
            {
                int id = Convert.ToInt32(model.DestinacijaID.ToString());
                await Navigation.PushAsync(new TerminiPage(id));
            }
            
           
            
        }
    }
}