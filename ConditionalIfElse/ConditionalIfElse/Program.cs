using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("Please enter a number between 0 and 10:");
            number = int.Parse(Console.ReadLine());

            if (number > 10)
                Console.WriteLine("Hey! The number should be 10 or less!");
            else
                if (number < 0)
                    Console.WriteLine("Hey! The number should be 0 or more!");
                else
                    Console.WriteLine("Good job!");

            //			if((number > 10) || (number < 0))
            //				Console.WriteLine("Hey! The number should be 0 or more and 10 or less!");
            //			else
            //				Console.WriteLine("Good job!");
            //
            //			if((number <= 10) && (number >= 0))
            //				Console.WriteLine("Good job!");
            //			else
            //				Console.WriteLine("Hey! The number should be 0 or more and 10 or less!");
        }
    }
}
