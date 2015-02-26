

namespace EnvironmentSystem.Models.Objects
{
    
    public class Explosion : Tail
    {
        /// <summary>
        /// The explosion should persist for 2 frames (have a lifetime of 2).
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="lifeTime"></param>
        public Explosion(int x, int y, int lifeTime = 2)
            : base(x, y, lifeTime)
        {
        }
    }
}
