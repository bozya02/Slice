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
        public DogPage(Dog dog)
        {
            InitializeComponent();
            Dog = dog;
            this.BindingContext = this;
        }

        private async void btnSave_Clicked(object sender, EventArgs e)
        {
            App.Database.SaveOrUpdateDog(Dog);
            await Navigation.PopAsync();
        }
    }
}