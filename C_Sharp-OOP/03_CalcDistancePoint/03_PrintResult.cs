using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintResult
{
    static void Main()
    {
        Console.Write("Enter coordinates point p1: x = ");
        int x_CoordP1 = Console.Read();
        Console.ReadLine();
        Console.Write("  y = ");
        int y_CoordP1 = Console.Read();
        Console.ReadLine();
        Point p1 = new Point(x_CoordP1, y_CoordP1);

        Console.Write("Enter coordinates point p2: x = ");
        int x_CoordP2 = Console.Read();
        Console.ReadLine();
        Console.Write("  y = ");
        int y_CoordP2 = Console.Read();
        Console.ReadLine();
        Point p2 = new Point(x_CoordP2, y_CoordP2);


        Console.WriteLine("Distance p1 -> p2 = {0:f3}", p1.CalcDistance(p2));
    }
}
