using RestaurantManager.Interfaces;
using System;

namespace RestaurantManager.Models
{
    public abstract class Meal : Recipe, IMeal
    {
        protected Meal(string name, decimal price, int calories,
            int quantityPerServing, int timeToPrepare, bool isVegan = false)
            : base(name, price, calories, quantityPerServing, timeToPrepare, MetricUnit.Grams)
        {
            this.IsVegan = isVegan;
        }

        public bool IsVegan { get; private set; }

        public virtual void ToggleVegan()
        {
            this.IsVegan = !this.IsVegan;
        }

        public override string ToString()
        {
            string veganString = this.IsVegan ? "[VEGAN] " : string.Empty;

            return veganString + base.ToString();
        }
    }
}
