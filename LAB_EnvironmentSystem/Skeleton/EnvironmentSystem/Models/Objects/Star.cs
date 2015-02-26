using System;
using System.Collections.Generic;

namespace EnvironmentSystem.Models.Objects
{
    class Star : EnvironmentObject
    {
        private const int StarImageUpdateFrame = 10;

        private static readonly Random randomizer = new Random();
        private static char[] starImage = new char[] {'O', '@', '0'};
        private int updateCount = 0;

        public Star(int x, int y)
            : base(x, y, 1, 1)
        {
            this.ImageProfile = new char[,] {{'O'}};
        }

        /// <summary>
        /// Solve Problem 4 - Stars
        /// The star should stay static and only change its image every 10th frame 
        /// (i.e. every 10th engine loop iteration). The image should be one of the following 'O', '@', '0', 
        /// and should be chosen at random. The effect should resemble stars flickering.
        /// </summary>
        public override void Update()
        {
            if (this.updateCount == StarImageUpdateFrame)
            {
                int index = randomizer.Next(0, starImage.Length);
                this.ImageProfile = new char[,] { {starImage[index]} };
                this.updateCount = 0;
            }
            this.updateCount++;
        }

        /// <summary>
        /// Solve Problem 6 - Step 2 – Explosion Damage
        /// Whenever any explosion from an unstable star occurs, 
        /// all stars (static stars, falling, other unstable stars) caught in the explosion radius should be destroyed. 
        /// </summary>
        /// <param name="collisionInfo"></param>
        public override void RespondToCollision(CollisionInfo collisionInfo)
        {
            var hitObject = collisionInfo.HitObject;
            if (hitObject is Explosion)
            {
                this.Exists = false;
            }
        }

        public override IEnumerable<EnvironmentObject> ProduceObjects()
        {
            return new List<EnvironmentObject>();
        }
    }
}
