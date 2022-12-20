using PizzaApp.Models;
using PizzaApp.ViewModel;
using PizzaApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PizzaApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MylistPage : ContentPage
    {
        public MylistPage()
        {
            InitializeComponent();
            BindingContext = new MyListPageViewModel();
        }
        private async void OnItemSelected(Object sender, ItemTappedEventArgs e)
        {
            var mydetails = e.Item as MyListModel;
            await Navigation.PushAsync(new MyListPageDetail(mydetails.Name, mydetails.Ingredients, mydetails.Image));

        }
    }
}