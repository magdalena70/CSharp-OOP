using _01_Point3D;
using System;


namespace _02_DistanceCalculator
{
    public static class DistanceCalculator 
    {
        public static double CalcDistance(Point3D pointOne, Point3D pointTwo)
        {
            //P1 = (x1, y1, z1)
            //P2 = (x2, y2, z2)
            //distance is SQRT((x1-x2)^2 + (y1-y2)^2 + (z1-z2)^2)

            double deltaX = Math.Pow((pointOne.X - pointTwo.X), 2);//compute the squares of the first parameters to Math.Pow
            double deltaY = Math.Pow((pointOne.Y - pointTwo.Y), 2);
            double deltaZ = Math.Pow((pointOne.Z - pointTwo.Z), 2);

            return Math.Sqrt(deltaX + deltaY + deltaZ);
        }  
    }
}
