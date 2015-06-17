using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car firstCar = new Car("Pearl Black", "Mercedes S5", 2012);


            //			firstCar.Colour="Pearl Black";
            //			firstCar.Make="Mercedes S5";
            //			firstCar.Year = 2012;

            Console.WriteLine("First Car:");
            Console.WriteLine("\n");
            Console.WriteLine("Colour:{0}", firstCar.Colour);
            Console.WriteLine("Make:{0}", firstCar.Make);
            Console.WriteLine("Year:{0}", firstCar.Year);

            Console.WriteLine("-------------------------------------------------------------");

            Car secondCar = new Car("Azure", "Pontiac", 1990);

            //			secondCar.Colour="Azure";
            //			secondCar.Make="Pontiac";
            //			secondCar.Year = 1990;

            Console.WriteLine("Second Car:");
            Console.WriteLine("\n");
            Console.WriteLine("Colour:{0}", secondCar.Colour);
            Console.WriteLine("Make:{0}", secondCar.Make);
            Console.WriteLine("Year:{0}", secondCar.Year);



        }
    }
}
