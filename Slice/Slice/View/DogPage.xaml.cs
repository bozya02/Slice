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
    public partial class DogPage : ContentPage
    {
        public Dog Dog { get; set; }
        public DogPage(Dog dog, User user)
        {
            InitializeComponent();
            Dog = dog;
            Dog.UserId = user.Id;
            this.BindingContext = this;

            dpBirthday.MinimumDate = DateTime.Now;
        }

        private async void btnSave_Clicked(object sender, EventArgs e)
        {
            App.Database.SaveOrUpdateDog(Dog);
            await Navigation.PopAsync();
        }
    }
}