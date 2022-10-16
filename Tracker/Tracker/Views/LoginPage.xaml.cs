using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace Tracker.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {


        private static string clientString = ConfigurationManager.AppSettings["client"];

        FirebaseClient firebaseClient = new Firebase.Database.FirebaseClient(clientString);

        public LoginPage()
        {
            InitializeComponent();
        }

        private async void Login_Clicked(object sender, EventArgs e)
        {

            //---------------- Storing Coordinates as Variables - for biz ----------------------
            try
            {
                var location = await Geolocation.GetLocationAsync();

                if (location != null)
                {
                    string userLat = location.Latitude.ToString();
                    string userLong = location.Longitude.ToString();
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Handle not supported on device exception
            }
            catch (FeatureNotEnabledException fneEx)
            {
                // Handle not enabled on device exception
            }
            catch (PermissionException pEx)
            {
                // Handle permission exception
            }
            catch (Exception ex)
            {
                // Unable to get location
            }
            //---------------- Storing Coordinates as Variables - for biz ----------------------


            Navigation.PushAsync(new MainPage());
            


        }
    }
}