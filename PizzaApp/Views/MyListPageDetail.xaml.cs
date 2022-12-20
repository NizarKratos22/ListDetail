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
    public partial class MyListPageDetail : ContentPage
    {
        public MyListPageDetail(String Name,String Ingredients , String Source)
        {
            InitializeComponent();


            MyItemNameShow.Text = Name;
            MyIngrediantItemShow.Text = Ingredients;
            MyImageCall.Source = new UriImageSource()
            {
                Uri = new Uri(Source)
            };

        }
    }
}