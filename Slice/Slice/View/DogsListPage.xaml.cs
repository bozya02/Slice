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
        public DogsListPage(User user)
        {
            InitializeComponent();
            Dogs = App.Database.GetDogs(user.Id);

            this.BindingContext = this;
        }

        private async void tbAddDog_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DogPage(new Dog()));
        }

        private async void lwDogs_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Dog dog = lwDogs.SelectedItem as Dog;
            await Navigation.PushAsync(new DogPage(dog));
        }
    }
}