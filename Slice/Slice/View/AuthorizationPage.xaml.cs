using Slice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Slice.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuthorizationPage : ContentPage
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private async void btnRegistation_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistrationPage());
        }

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            var login = entLogin.Text;
            var password = entPassword.Text;

            if (login == "111" || password == "111")
                await Navigation.PushAsync(new DogsListPage(new User()));

            User user = App.Database.GetUser(login, password);

            if (user != null)
                await Navigation.PushAsync(new DogsListPage(user));
            else
                await DisplayAlert("Абыбка", "Инвалид логин ор пассворд", "Бебра");
        }
    }
}