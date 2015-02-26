using System.Collections.Generic;

namespace EnvironmentSystem.Models.Objects
{
    /// <summary>
    /// Solve Problem 6.Unstable Stars -
    /// Some stars don't have much luck and explode before they fall – and that's why they're most beautiful.
    /// Step 1 – Instability
    /// Such stars have a lifetime – i.e. time before they explode. 
    /// Create an unstable star that has a lifetime of 8 (8 frames of life). 
    /// Just like the falling star, it should fall in its direction and at some point explode. 
    /// </summary>
    public class UnstableStar : FallingStar
    {
        private int lifeTime;

        public UnstableStar(int x, int y, Point direction, int lifeTime = 8)
            : base(x, y, direction)
        {
            this.lifeTime = lifeTime;
        }

        public override void Update()
        {
            base.Update();
            this.lifeTime--;
            if (lifeTime < 1)
            {
                this.Exists = false;
            }
        }

        /// <summary>
        /// When it explodes, the unstable falling star should produce an explosion with radius 2 in every direction, 
        /// except the center.
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<EnvironmentObject> ProduceObjects()
        {
            if (!this.Exists)
            {
                List<EnvironmentObject> explosion = new List<EnvironmentObject>();
                for (int y = this.Bounds.TopLeft.Y - 2; y <= this.Bounds.TopLeft.Y + 2; y++)
                {
                    for (int x = this.Bounds.TopLeft.X - 2; x <= this.Bounds.TopLeft.X + 2; x++)
                    {
                        if (!(x == this.Bounds.TopLeft.X && y == this.Bounds.TopLeft.Y))
                        {
                            explosion.Add(new Explosion(x, y));
                        }
                    }
                }

                return explosion;
            }

            return base.ProduceObjects();
        }
    }
}
