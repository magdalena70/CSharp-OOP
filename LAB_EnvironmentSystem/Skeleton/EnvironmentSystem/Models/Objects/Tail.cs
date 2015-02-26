

using System.Collections.Generic;
namespace EnvironmentSystem.Models.Objects
{
    public class Tail : EnvironmentObject
    {
        private int lifeTime;

        public Tail(int x, int y, int lifeTime = 1)
            : base(x, y, 1, 1)
        {
            this.lifeTime = lifeTime;
            this.ImageProfile = new char[,] { { '*' } };
        }

        public override void Update()
        {
            if (lifeTime < 1) // update onse
            {
                this.Exists = false;
            }

            this.lifeTime--;
        }

        public override void RespondToCollision(CollisionInfo collisionInfo)
        {
        }

        public override IEnumerable<EnvironmentObject> ProduceObjects()
        {
            return new List<EnvironmentObject>();
        }
    }
}
