using FarmersCreed.Interfaces;
using System;
namespace FarmersCreed.Units
{
    public class Swine : Animal
    {
        private const int SwineHealth = 20;
        private const int SwineHealthEffect = 5;

        /// <summary>
        /// Animal with base Health of 20 and ProductionQuantity of 1
        /// </summary>
        /// <param name="id"></param>
        public Swine(string id)
            : base(id, SwineHealth, 1)
        {
        }

        /// <summary>
        /// Eats both Organic and Meat food and gains twice the HealthEffect
        /// </summary>
        /// <param name="food"></param>
        /// <param name="quantity"></param>
        public override void Eat(IEdible food, int quantity)
        {
            switch (food.FoodType)
            {
                case FoodType.Organic:
                case FoodType.Meat:
                    this.Health += 2 * food.HealthEffect * quantity;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Produces a product with ProductType of PorkMeat, FoodType of Meat, 
        /// HealthEffect of 5 and ProductionQuantity of 1.
        /// Dies after producing a product.
        /// Cannot produce if dead.
        /// </summary>
        /// <returns></returns>
        public override Product GetProduct()
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException(
                    "Swine is dead. Cannot produce.");
            }

            var product = new Food(this.Id + "Product",
                ProductType.PorkMeat, FoodType.Meat,
                this.ProductionQuantity, SwineHealthEffect);

            this.Health = 0;
            return product;
        }

        /// <summary>
        /// Starves 3 times as fast as other animals
        /// </summary>
        public override void Starve()
        {
            for (int i = 0; i < 3; i++)
            {
                base.Starve();
            }
        }
    }
}
