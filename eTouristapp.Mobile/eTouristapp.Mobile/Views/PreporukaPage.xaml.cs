using eTouristapp.Mobile.ViewModels;
using eTouristapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eTouristapp.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PreporukaPage : ContentPage
    {
        PreporukaViewModel model = new PreporukaViewModel();
        public PreporukaPage()
        {
            InitializeComponent();
            BindingContext = model = new PreporukaViewModel()
            {

            };
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.LoadPreporuka();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem!=null)
            {
                var l = e.SelectedItem as Destinacija;
                int id = int.Parse(l.Id.ToString());
                Navigation.PushAsync(new TerminiPage(id));

            }

        }
    }
}