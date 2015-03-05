using RestaurantManager.Interfaces;
using System;

namespace RestaurantManager.Models
{
    public class Dessert : Meal, IDessert
    {
        public Dessert(string name, decimal price, int calories, 
            int quantityPerServing, int timeToPrepare, bool isVegan)
            : base(name, price,calories, quantityPerServing, timeToPrepare, isVegan)
        {
            this.WithSugar = true;
        }

        public bool WithSugar
        {
            get;
            private set;
        }

        public void ToggleSugar()
        {
            this.WithSugar = !this.WithSugar;
        }

        public override string ToString()
        {
            string sugarString = this.WithSugar ? string.Empty : "[NO SUGAR] ";
            return sugarString + base.ToString();
        }
    }
}
