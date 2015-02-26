using System.Collections.Generic;
namespace EnvironmentSystem.Models.Objects
{
    public class Snowflake : MovingObject
    {
        protected const char SnowflakeCharImage = '*';

        public Snowflake(int x, int y, int width, int height, Point direction)
            : base(x, y, width, height, direction)
        {
            this.ImageProfile = this.GenerateImageProfile();
        }

        protected virtual char[,] GenerateImageProfile()
        {
            return new char[,] { { SnowflakeCharImage } };
        }

        /// <summary>
        /// Solve Problem 2 - Disappearing Snowflakes
        /// Make so that whenever any snowflake hits the ground, it disappears (it is removed from the environment).
        /// Hint: Taka a close look at the base class – see what must be changed in the Snowflake to achieve this.
        /// Note: You are only allowed to edit the contents of Models.Objects namespace.
        /// Solve Problem 3 - Step 2 - Stacking Snow
        /// Make so that snow stacks – i.e. if a snowflake falls on snow – it produces more snow.
        /// </summary>
        public override void RespondToCollision(CollisionInfo collisionInfo)
        {
            var hitObject = collisionInfo.HitObject;
            if (hitObject is Ground || hitObject is Snow)
            {
                this.Exists = false;
            }
        }

        /// <summary>
        /// Solve Problem 3 - Step 1 - Melting Snowflakes
        /// Whenever a snowflake hits the ground it should not only cease to disappear, 
        /// but produce snow. What is actually snow? – it is something that the snowflake produces with quantity of 1. 
        /// It may look however you wish (e.g. '.', to distinguish it from snowflakes).
        /// </summary>
        /// <returns>prodesedObject</returns>
        public override IEnumerable<EnvironmentObject> ProduceObjects()
        {
            List<EnvironmentObject> prodesedObject = new List<EnvironmentObject>();
            if (!this.Exists)
            {
                prodesedObject.Add(new Snow(this.Bounds.TopLeft.X, this.Bounds.TopLeft.Y - 1));
            }

            return prodesedObject;
        }
    }
}
