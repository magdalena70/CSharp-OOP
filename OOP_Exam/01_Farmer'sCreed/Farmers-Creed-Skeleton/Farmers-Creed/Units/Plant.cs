namespace FarmersCreed.Units
{
    using System;

    public abstract class Plant : FarmUnit
    {
        protected Plant(string id, int health, int productionQuantity, int growTime)
            : base(id, health, productionQuantity)
        {
            this.GrowTime = growTime;
        }

        public bool HasGrown
        {
            get 
            { 
                return this.GrowTime <= 0; 
            }
        }

        public int GrowTime { get; set; }
        
        /// <summary>
        /// Plants increase their Health when watered by 2.
        /// </summary>
        public virtual void Water()
        {
            this.Health += 2;
        }

        /// <summary>
        /// Plants decrease their Health when they wither by 1.
        /// </summary>
        public virtual void Wither()
        {
            this.Health--;
        }

        /// <summary>
        /// A plant is a farm unit which can grow by decreasing its GrowTime by 1. 
        /// GrowTime represents the time it takes for a plant to grow. 
        /// </summary>
        public virtual void Grow()
        {
            this.GrowTime--;
        }

        public override string ToString()
        {
            string baseStr = base.ToString();
            if (this.IsAlive)
            {
                baseStr += ", Grown: " + (this.HasGrown ? "Yes" : "No");
            }

            return baseStr;
        }
    }
}
