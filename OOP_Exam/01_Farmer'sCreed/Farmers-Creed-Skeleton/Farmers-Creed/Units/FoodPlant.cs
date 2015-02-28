namespace FarmersCreed.Units
{
    /// <summary>
    /// Base class for plants which produce food products
    /// </summary>
    public abstract class FoodPlant : Plant
    {
        public FoodPlant(string id, int health, int productionQuantity, int growTime)
            : base(id, health, productionQuantity, growTime)
        {
        }

        /// <summary>
        /// Increases its Health by 1 when watered
        /// </summary>
        public override void Water()
        {
            this.Health++;
        }

        /// <summary>
        /// Withers twice as fast as other plants.
        /// </summary>
        public override void Wither()
        {
            for (int i = 0; i < 2; i++)
            {
                base.Wither();
            }
        }
    }
}
