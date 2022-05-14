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
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private async void btnRegistration_Clicked(object sender, EventArgs e)
        {
            User user = new User
            {
                FullName = entFullName.Text,
                Login = entLogin.Text,
                Passwrod = entPassword.Text,
            };

            App.Database.SaveOrUpdateUser(user);
            await Navigation.PopAsync();
        }
    }
}