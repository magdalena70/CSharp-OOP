using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_PC_Catalog
{
    class Print_PC_Catalog
    {
        static void Main()
        {
            Computer firstComp = new Computer(
                computerName: "ASUS", 
                processor: new Component("Intel® Atom® 1.8GHz Quad-Core processor", 410),
                graphicsCard: new Component("Intel HD Graphics", 200),
                motherboard: new Component("ASUS RAMPAGE V EXTREME LGA 2011-v3 Intel X99", 930));

            Computer secondComp = new Computer(
                computerName: "MS-9A66",
                processor: new Component("4th Gen Intel® Core i7/i5/i3, Pentium, and Celeron® processor", 310),
                graphicsCard: new Component("Intel HD Graphics", 200),
                motherboard: new Component("MSI X99S SLI Plus LGA 2011-v3 Intel X99", 470));

            Computer thirdComp = new Computer(
                computerName: "Acer Aspire ES1-111M NX.MRSEX.004",
                processor: new Component("Intel Celeron N2840 2.16GHz/2.58GHz", 210),
                graphicsCard: new Component("Intel HD Graphics", 200),
                motherboard: new Component("ASRock 990FX Extreme3", 130));

            List<Computer> computers = new List<Computer>() 
            { 
                firstComp, 
                secondComp, 
                thirdComp 
            };

            var sortElements = from element in computers
                         orderby element.ComputerPrice ascending
                         select element;

            foreach (var computer in sortElements)
            {
                Console.WriteLine(computer);
            }
        }
    }
}
