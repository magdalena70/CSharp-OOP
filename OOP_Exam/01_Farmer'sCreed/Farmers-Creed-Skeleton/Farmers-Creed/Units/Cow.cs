using FarmersCreed.Interfaces;
using System;
namespace FarmersCreed.Units
{
    public class Cow : Animal
    {
        private const int CowHealth = 15;
        private const int CowProductionQuantity = 6;
        private const int CowProductHealthEffect = 4;

        /// <summary>
        /// Animal with base Health of 15 and Quantity of 6
        /// </summary>
        /// <param name="id"></param>
        public Cow(string id)
            : base(id, CowHealth, CowProductionQuantity)
        {
        }

        /// <summary>
        /// If the cow eats Organic food, it gains the food's HealthEffect * productQuantity. 
        /// If the food is Meat, it loses the HealthEffect * productQuantity from its own Health.
        /// </summary>
        /// <param name="food"></param>
        /// <param name="quantity"></param>
        public override void Eat(IEdible food, int quantity)
        {
            switch (food.FoodType)
            {
                case FoodType.Organic: this.Health += food.HealthEffect * quantity;
                    break;
                case FoodType.Meat: this.Health -= food.HealthEffect * quantity;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Produces a product with ProductType of Milk, FoodType of Organic, HealthEffect of 4 and Quantity of 6.
        /// Loses 2 Health when producing milk.
        /// Cannot produce if dead.
        /// </summary>
        /// <returns></returns>
        public override Product GetProduct()
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException(
                    "Cow is dead. Cannot produce.");
            }

            var product = new Food(this.Id + "Product", ProductType.Milk,
                FoodType.Organic, this.ProductionQuantity, CowProductHealthEffect);

            this.Health -= 2;
            return product;
        }
    }
}
