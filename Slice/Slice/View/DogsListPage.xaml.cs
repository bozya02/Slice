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
    public partial class DogsListPage : ContentPage
    {
        public List<Dog> Dogs { get; set; }
        public User User { get; set; }
        public DogsListPage(User user)
        {
            InitializeComponent();
            Dogs = App.Database.GetDogs(user.Id);
            User = user;
            this.BindingContext = this;
        }

        private async void tbAddDog_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DogPage(new Dog(), new User()));
        }

        private async void lwDogs_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Dog dog = lwDogs.SelectedItem as Dog;
            await Navigation.PushAsync(new DogPage(dog, User));
        }
    }
}