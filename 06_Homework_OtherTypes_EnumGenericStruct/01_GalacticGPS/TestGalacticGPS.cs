using System;

namespace _01_GalacticGPS
{
     public class TestGalacticGPS
    {
        public static void Main()
        {
            Location home = new Location(18.037986, 28.870097, Planet.Earth);
            Console.WriteLine(home);
        }
    }
}
