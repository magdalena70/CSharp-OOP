using RestaurantManager.Interfaces;
using System;

namespace RestaurantManager.Models
{
    public class Drink : Recipe, IDrink
    {

        public Drink(string name, decimal price, int calories, int quantityPerServing,
            int timeToPrepare, bool isCarbonated)
            : base(name, price, calories, quantityPerServing, timeToPrepare, MetricUnit.Milliliters)
        {
            this.IsCarbonated = isCarbonated;
        }

        public override int Calories
        {
            get
            {
                return base.Calories;
            }
            protected set
            {
                Validation.ForDrinkCalories(value);
                base.Calories = value;
            }
        }

        public override int TimeToPrepare
        {
            get
            {
                return base.TimeToPrepare;
            }
            protected set
            {
                Validation.ForDrinkTimeToPrepare(value);
                base.TimeToPrepare = value;
            }
        }

        public bool IsCarbonated
        {
            get;
            private set;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format("\nCarbonated: {0}", 
                this.GetBooleanValueAsString(this.IsCarbonated));
        }
    }
}
