using System;
namespace FarmersCreed.Units
{
    public class TobaccoPlant : Plant
    {
        private const int InitialTobaccoHealth = 12;
        private const int TobaccoProductionQuantity = 10;
        private const int InitialTobaccoGrowTime = 4;

        /// <summary>
        /// Plant with base Health of 12, GrowTime of 4 and Quantity of 10
        /// </summary>
        /// <param name="id"></param>
        public TobaccoPlant(string id)
            : base(id, InitialTobaccoHealth, 
            TobaccoProductionQuantity, InitialTobaccoGrowTime)
        {
        }

        /// <summary>
        /// Produces a product with ProductType of Tobacco and Quantity of 10
        /// Products produced by animals/plants should have an Id equal to the producing unit's Id + "Product"
        /// Cannot produce while growing or if dead
        /// </summary>
        /// <returns></returns>
        public override Product GetProduct()
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException(
                    "TobaccoPlant is dead. Cannot produce.");
            }

            if (!this.HasGrown)
            {
                throw new InvalidOperationException(
                    "TobaccoPlant is steel growing. Cannot produce while growing.");
            }

            return new Product(this.Id + "Product", 
                ProductType.Tobacco, 
                this.ProductionQuantity);
        }

        /// <summary>
        /// Tobacco grows twice as fast as other plants
        /// </summary>
        public override void Grow()
        {
            for (int i = 0; i < 2; i++)
            {
                base.Grow();
            }
        }
    }
}
