using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Configuration;
using System.Collections.Specialized;
using Tracker.Views;

namespace Tracker
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
            MainPage = new NavigationPage(new LoginPage());

            // MainPage = new RegistrationPage();
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
