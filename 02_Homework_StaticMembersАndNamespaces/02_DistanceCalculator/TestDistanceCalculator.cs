using _01_Point3D;
using System;

namespace _02_DistanceCalculator
{
    public class TestDistanceCalculator
    {
        public static void Main()
        {
            Point3D p1 = new Point3D(1.0, 3.5, 8.2);
            Point3D p2 = new Point3D(2.2, -7.0, -1.8);
            Console.WriteLine("Distance between P1 and P2 in the 3D Euclidian space = {0:f3}.",
                DistanceCalculator.CalcDistance(p1, p2));
        }
    }
}
