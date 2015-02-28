namespace FarmersCreed.Units
{
    using System;

    public class CherryTree : FoodPlant
    {
        private const int CherryTreeHealth = 14;
        private const int CherryTreeQuantity = 4;
        private const int CherryTreeGrowtime = 3;
        private const int CherrryProduceHealthEffect = 2;

        /// <summary>
        /// Food plant with base Health of 14, GrowTime of 3 and Quantity of 4 
        /// </summary>
        /// <param name="id"></param>
        public CherryTree(string id)
            : base(id, CherryTreeHealth, CherryTreeQuantity, CherryTreeGrowtime)
        {
        }

        /// <summary>
        /// Produces a food product with ProductType of Cherry, FoodType of Organic, 
        /// Quantity of 4 and HealthEffect of 2.
        /// Cannot produce if dead
        /// </summary>
        /// <returns></returns>
        public override Product GetProduct()
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException("CherryTree is dead. Cannot produce if dead.");
            }

            return new Food(this.Id + "Product",
                ProductType.Cherry, FoodType.Organic,
                this.ProductionQuantity, CherrryProduceHealthEffect);
        }
    }
}
