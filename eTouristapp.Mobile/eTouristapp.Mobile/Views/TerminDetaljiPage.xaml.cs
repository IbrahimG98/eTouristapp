using eTouristapp.Mobile.Models;
using eTouristapp.Mobile.ViewModels;
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
    public partial class TerminDetaljiPage : ContentPage
    {
        TerminDetaljiViewModel model = new TerminDetaljiViewModel();
        public TerminDetaljiPage(int terminid)
        {
            InitializeComponent();
            BindingContext = model = new TerminDetaljiViewModel()
            {
                terminid=int.Parse(terminid.ToString())
            };
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.LoadTerminDetalji();
        }



    }
}