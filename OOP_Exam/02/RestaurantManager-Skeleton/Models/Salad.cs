using RestaurantManager.Interfaces;
using System;

namespace RestaurantManager.Models
{
    public class Salad : Meal, ISalad
    {
        public Salad(string name, decimal price, int calories, 
            int quantityPerServing, int timeToPrepare, bool containsPasta)
            : base(name, price, calories, quantityPerServing, timeToPrepare, true)
        {
            this.ContainsPasta = containsPasta;
        }

        public bool ContainsPasta { get; private set; }

        public override void ToggleVegan()
        {
            throw new ArgumentException("A salad must always be vegan.");
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("\nContains pasta: {0}", 
                this.GetBooleanValueAsString(this.ContainsPasta));
        }
    }
}
