using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace fascontacpage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        
        public Page1()  
        {
            InitializeComponent();
            
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();

            //Get All Persons
            var personList = await App.SQLiteDb.GetItemsAsync();
            if (personList != null)
            {
                ProductsView.ItemsSource = personList;
            }
        }
        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }
    }
}