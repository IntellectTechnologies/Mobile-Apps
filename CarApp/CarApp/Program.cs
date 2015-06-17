using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car firstCar = new Car();

            firstCar.colour = "Pearl Black";
            firstCar.make = "Mercedes S5";
            firstCar.year = 2012;

            Console.WriteLine("First Car:");
            Console.WriteLine("\n");
            Console.WriteLine("Colour:{0}", firstCar.colour);
            Console.WriteLine("Make:{0}", firstCar.make);
            Console.WriteLine("Year:{0}", firstCar.year);

            Console.WriteLine("-------------------------------------------------------------");

            Car secondCar = new Car();

            secondCar.colour = "Azure";
            secondCar.make = "Pontiac";
            secondCar.year = 1990;

            Console.WriteLine("Second Car:");
            Console.WriteLine("\n");
            Console.WriteLine("Colour:{0}", secondCar.colour);
            Console.WriteLine("Make:{0}", secondCar.make);
            Console.WriteLine("Year:{0}", secondCar.year);

        }
    }
}
