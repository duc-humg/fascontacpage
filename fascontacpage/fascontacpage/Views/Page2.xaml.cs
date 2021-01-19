using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace fascontacpage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
            
        }
        
        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(firstname1.Text))
            {
                Product product = new Product()
                {
                    firstname = firstname1.Text,
                    lastname = lastname1.Text,
                    phone = phone1.Text,
                    email = mail1.Text
                };
                await App.SQLiteDb.SaveItemAsync(product);
                firstname1.Text = string.Empty;
                lastname1.Text = string.Empty;
                phone1.Text = string.Empty;
                mail1.Text = string.Empty;
                await DisplayAlert("Success", "Person added Successfully", "OK");
                var personList = await App.SQLiteDb.GetItemsAsync();
                if (personList != null)
                {
                    ProductsView.ItemsSource = personList;
                }
            }
            else
            {
                await DisplayAlert("Required", "Please Enter name!", "OK");
            }
        }
    }
}