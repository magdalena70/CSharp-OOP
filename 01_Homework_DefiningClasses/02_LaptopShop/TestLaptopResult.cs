using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_LaptopShop
{
    class TestLaptopResult
    {
        static void Main()
        {
            Laptop mandatoryDescription = new Laptop("HP 250 G2", 699);
            Console.WriteLine(mandatoryDescription);

            Battery laptopBattery = new Battery("Li-Ion, 4-cells, 2550 mAh", 4.5);
            Laptop fullDescription = new Laptop(
                    "Lenovo Yoga 2 Pro", 2259, laptopBattery, "Lenovo", 
                    "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)",
                    "8 GB", "Intel HD Graphics 4400", "128GB SSD", 
                    "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display");
            Console.WriteLine(fullDescription);

            /*Laptop emptyModelValue = new Laptop("", 699.00m);
            Console.WriteLine(emptyModelValue);*/

            /*Laptop negativeValue = new Laptop("HP 250 G2", -1);
            Console.WriteLine(negativeValue);*/
        }
    }
}
