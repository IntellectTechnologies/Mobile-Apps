using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables for holding different expenses
            int food;
            int transport;
            int miscellaneous;
            int totalExpense = 0;
            string message = "Your total expense for today is : ";

            //Accept expense values from the user console
            Console.WriteLine("Enter expense for food:");
            food = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter expense for transport:");
            transport = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter miscellaneous expense:");
            miscellaneous = int.Parse(Console.ReadLine());

            totalExpense = food + transport + miscellaneous;
            Console.WriteLine(message + totalExpense);
            //A more elegant way of writing the above line

            //Console.WriteLine ("Your total expense for today is :{0} ", totalExpense);
        }
    }
}
