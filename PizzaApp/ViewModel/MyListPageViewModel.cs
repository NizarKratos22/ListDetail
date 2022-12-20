using PizzaApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PizzaApp.ViewModel
{
    public class MyListPageViewModel
    {

        public ObservableCollection<MyListModel> FoodList { get; set; }

        public MyListPageViewModel()
        {


            FoodList = new ObservableCollection<MyListModel>();
            FoodList.Add(new MyListModel { Name = "Margherita", Image = "https://lelocalapizzas.fr/wp-content/uploads/2022/02/Pizza-Margherita.jpg",Prix="15DT", Detail = "La pizza Margherita ou napolitaine, est l’une des plus anciennes pizzas italiennes avec la Marinara", Ingredients = " Tomate,Mozzarella,Basilic" });
            FoodList.Add(new MyListModel { Name = "Sicilienne", Image = "https://lelocalapizzas.fr/wp-content/uploads/2022/02/pizza-sicilienne.jpg",Prix="16DT", Detail = "La pizza sicilienne Sfincione est originaire de Palerme", Ingredients = "Sauce tomates, mozzarella, olives noires, oignons, câpres et anchois" });
            FoodList.Add(new MyListModel { Name = "Quattro Formaggi ", Image = "https://lelocalapizzas.fr/wp-content/uploads/2022/02/pizza-4-fromages.jpg",Prix="20DT", Detail = "La pizza Quattro Formaggi a une pâte fine et croustillante,composée de 4 fromages différents", Ingredients = "Sauce tomate ou sauce blanche,Mozzarella,Gruyère,Emmental,comté" });
            FoodList.Add(new MyListModel { Name = "La végétarienne", Image = "https://lelocalapizzas.fr/wp-content/uploads/2022/02/pizza-vegetarienne.jpg",Prix="20DT", Detail = "La végétarienne est une variante délicieuse", Ingredients = "Sauce tomates, mozzarella, poivrons, courgettes et aubergines grillées" });
            FoodList.Add(new MyListModel { Name = "Quattro Stagioni", Image = "https://lelocalapizzas.fr/wp-content/uploads/2022/02/pizza-4-saisons.jpg",Prix="25DT", Detail = "La Quattro Stagioni fait référence aux 4 saisons de l’année et se compose de 4 parties différentes", Ingredients = "Sauce tomates, mozzarella, des olives noires, des artichauts et du jambon " });
            FoodList.Add(new MyListModel { Name = "La Frutti di Mare", Image = "https://lelocalapizzas.fr/wp-content/uploads/2022/02/pizza-fruit-de-mer.jpg",Prix="30DT", Detail = "La Frutti di Mare,est une pizza qui sort des sentiers battus et qui offre un goût unique", Ingredients = "Sauce tomate,Mozzarella,Crevettes, calamars, moules, poulpe ou pétoncles" });
            //you can add here multiple list items 
            //FoodList.Add(new MyListModel { Name = "Test2", Image = "https://media.istockphoto.com/photos/double-cheese-and-bacon-cheeseburger-picture-id511484502?k=6&m=511484502&s=612x612&w=0&h=2d8oTGH_E7KHkd4TIdftWIxjLsBP3CfdF44zy65FD0o=", Detail = "This is our burger",Ingredients="This is our detail page details to be listed" });

        }
    }
}