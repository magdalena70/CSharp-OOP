using System;

namespace _09_Structures_Example
{
    public class TestSquare
    {
        public static void Main()
        {
            Point location = new Point();
            location.X = 2;
            location.Y = 3;
            Color surfaceColor = new Color();
            surfaceColor.Red = 20;
            surfaceColor.Green = 8;
            surfaceColor.Blue = 7;
            Color borderColor = new Color();
            borderColor.Red = 222;
            borderColor.Green = 100;
            borderColor.Blue = 7;

            Square square = new Square(location, 5, surfaceColor, borderColor, Edges.Rounded);

            Console.WriteLine(square);
        }
    }
}
