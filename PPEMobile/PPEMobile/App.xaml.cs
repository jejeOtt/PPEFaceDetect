using PPEMobile.Page;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PPEMobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new MainPage()); // permet la navigation sur scannerPage
            //MainPage = new NavigationPage(new SignInPage());

            if (!string.IsNullOrEmpty(Settings.AccessToken))
            {
                MainPage = new NavigationPage(new MainPage());
            }
            else if (string.IsNullOrEmpty(Settings.UserName) && string.IsNullOrEmpty(Settings.Password))
            {
                MainPage = new NavigationPage(new SignInPage());
            }
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
