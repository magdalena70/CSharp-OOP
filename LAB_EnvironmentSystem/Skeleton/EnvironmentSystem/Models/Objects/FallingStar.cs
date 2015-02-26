
using System.Collections.Generic;
namespace EnvironmentSystem.Models.Objects
{
    public class FallingStar : MovingObject
    {
        public FallingStar(int x, int y, Point direction)
            : base(x, y, 1, 1, direction)
        {
            this.ImageProfile = new char[,] { {'O'} };
        }

        /// <summary>
        /// Solve Problem 5 - Step 1 – Falling Star
        /// The falling star should pretty much fall in a downward direction. 
        /// Create a class that models such behavior with an image by choice (e.g. 'O'). 
        /// The falling star should disappear on contact with the ground (assume it's the horizon).
        /// Solve Problem 6 - Step 2 – Explosion Damage
        /// </summary>
        /// <param name="collisionInfo"></param>
        public override void RespondToCollision(CollisionInfo collisionInfo)
        {
            var hitObject = collisionInfo.HitObject;
            if (hitObject is Ground || hitObject is Explosion)
            {
                this.Exists = false;
            }
        }

        /// <summary>
        /// Solve Problem 5 - Step 2 - Star Trails
        /// We're forgetting something though – falling stars have leave trails. 
        /// Modify your falling star so that it leaves a trail of 3 '*' while falling.
        /// </summary>
        /// <returns>return produceObjects</returns>
        public override IEnumerable<EnvironmentObject> ProduceObjects()
        {
            List<EnvironmentObject> produceObjects = new List<EnvironmentObject>();
            produceObjects.Add(new Tail(this.Bounds.TopLeft.X - this.Direction.X, 
                this.Bounds.TopLeft.Y - this.Direction.Y));
            produceObjects.Add(new Tail(this.Bounds.TopLeft.X - (2 * this.Direction.X),
                this.Bounds.TopLeft.Y - (2 * this.Direction.Y)));

            return produceObjects;
        }
    }
}
