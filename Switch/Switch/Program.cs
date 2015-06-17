using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //			int number = 0;
            //			switch(number)
            //			{
            //			case 0:
            //				Console.WriteLine("The number is zero!");
            //				break;
            //			case 1:
            //				Console.WriteLine("The number is one!");
            //				break;
            //			}

            Console.WriteLine("Do you enjoy Watching Movies ? (yes/no/maybe)");
            string input = Console.ReadLine();
            switch (input.ToLower())
            {
                case "yes":
                    Console.WriteLine("Great! You are a movie Buff !!!");
                    break;
                case "maybe":
                    Console.WriteLine("Well! Make up your mind !!!");
                    break;
                case "no":
                    Console.WriteLine("Too bad! You are missing out on so much fun !!");
                    break;
                default:
                    Console.WriteLine("I'm sorry, I don't understand that!");
                    break;

            }


        }
    }
}
