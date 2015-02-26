namespace EnvironmentSystem.Core.Generator
{
    using System;
    using System.Collections.Generic;

    using EnvironmentSystem.Models;
    using EnvironmentSystem.Models.Objects;

    public class ObjectGenerator
    {
        private const int SnowflakeCount = 10;

        private readonly int WorldWidth;
        private readonly int WorldHeight;

        public ObjectGenerator(int worldWidth, int worldHeight)
        {
            this.WorldWidth = worldWidth;
            this.WorldHeight = worldHeight;
        }

        /// <summary>
        /// Adds objects only once to the passed collection.
        /// </summary>
        /// <param name="objects"></param>
        public void Initiliaze(List<EnvironmentObject> objects)
        {
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int x = rnd.Next(0, this.WorldWidth);
                int y = rnd.Next(0, this.WorldHeight / 2);
                objects.Add(new Star(x, y)); // Test new Star by adding several of it to the ObjectGenerator.
            }
            objects.Add(new FallingStar(28, 15, new Point(-1, 1))); // Test new FallingStar to the ObjectGenerator.
            objects.Add(new UnstableStar(32, 1, new Point(-2, 1))); // Test new UnstableStar to the ObjectGenerator.
            objects.Add(new Ground(0, 25, 50, 2));
        }

        /// <summary>
        /// Dynamically adds objects to the passed collection.
        /// </summary>
        /// <param name="objects"></param>
        public void DynamicallyAdd(List<EnvironmentObject> objects)
        {
            Random rnd = new Random();
            for (int i = 0; i < SnowflakeCount; i++)
            {
                int generateFlag = rnd.Next(0, 5);

                if (generateFlag == 1)
                {
                    int x = rnd.Next(0, WorldWidth);
                    var envObject = new Snowflake(x, 1, 1, 1, new Point(0, 1));

                    objects.Add(envObject);
                }
            }
        }
    }
}
