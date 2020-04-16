using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Machina.service;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Machina
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
        }


        private void BackHistoryPage(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private async void BtnSignUp_Clicked(object sender, EventArgs e)
        {
            ApiService apiServices = new ApiService();
            bool response = await apiServices.RegisterUser(EntMail.Text, EntPassword.Text, EntConfirmPassword.Text);
            if (!response)
            {
                Console.WriteLine(response);
                DisplayAlert("Erreur", "Vous avez mal rentrer votre email ou mot de passe", "Annuler");
            }
            else
            {
                await DisplayAlert("Bienvenue", "Vous compte a bien été crée", "OK");
                await Navigation.PopToRootAsync();
            }
        }
    }
}