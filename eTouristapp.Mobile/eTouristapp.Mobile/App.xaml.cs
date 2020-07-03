using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using eTouristapp.Mobile.Services;
using eTouristapp.Mobile.Views;

namespace eTouristapp.Mobile
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            //MainPage = new MainPage();
            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {

        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
