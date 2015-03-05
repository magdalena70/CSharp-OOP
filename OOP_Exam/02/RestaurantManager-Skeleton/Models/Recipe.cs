using RestaurantManager.Interfaces;
using System;
using System.Text;

namespace RestaurantManager.Models
{
    public abstract class Recipe : IRecipe
    {
        private string name;
        private decimal price;
        private int calories;
        private int quantityPerServing;
        private int timeToPrepare;
        private MetricUnit unit;

        protected Recipe(string name, decimal price, int calories, 
            int quantityPerServing, int timeToPrepare, MetricUnit unit)
        {
            this.Name = name;
            this.Price = price;
            this.Calories = calories;
            this.QuantityPerServing = quantityPerServing;
            this.TimeToPrepare = timeToPrepare;
            this.Unit = unit;
        }

        public string Name
        {
            get { return this.name; }
            private set 
            {
                Validation.ForRequiredString(value);
                this.name = value; 
            }
        }

        public decimal Price
        {
            get { return this.price; }
            private set
            {
                Validation.ForPositiveNumber(value);
                this.price = value;
            }
        }

        public virtual int Calories
        {
            get { return this.calories; }
            protected set
            {
                Validation.ForPositiveNumber(value);
                this.calories = value;
            }
        }

        public int QuantityPerServing
        {
            get { return this.quantityPerServing; }
            private set
            {
                Validation.ForPositiveNumber(value);
                this.quantityPerServing = value;
            }
        }

        public MetricUnit Unit
        {
            get { return this.unit; }
            private set
            {
                this.unit = value;
            }
        }

        public virtual int TimeToPrepare
        {
            get { return this.timeToPrepare; }
            protected set
            {
                Validation.ForPositiveNumber(value);
                this.timeToPrepare = value;
            }
        }

        public override string ToString()
        {
            var recipe = new StringBuilder();
            recipe.AppendFormat("==  {0} == ${1:F2}", this.Name, this.Price).AppendLine()
                .AppendFormat("Per serving: {0} {1}, {2} kcal", 
                this.QuantityPerServing, this.GetUnit(), this.Calories).AppendLine()
                .AppendFormat("Ready in {0} minutes", this.TimeToPrepare);


            return recipe.ToString();
        }

        protected string GetBooleanValueAsString(bool value)
        {
            return value? "yes": "no";
        }

        private string GetUnit()
        {
            switch (this.Unit)
            {
                case MetricUnit.Grams: return "g";
                    
                case MetricUnit.Milliliters: return "ml";

                default: throw new InvalidOperationException("Invalid unit provided.");
            }
        }
    }
}
