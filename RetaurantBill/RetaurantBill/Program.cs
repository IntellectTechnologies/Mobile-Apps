using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetaurantBill
{
    class Program
    {
        const double beverage = 1.50;
        const double Sandwich = 4.50;
        const double Chips = 1.25;
        const double TaxRate = 0.08;
        const double TipRate = 0.15;
        static void Main(string[] args)
        {
            double subTotal = 0;
            double taxAmount = 0;
            double tipAmount = 0;
            double total = 0;

            //collect user input

            Console.WriteLine("How many beverages ? : ");
            int bvgsNo = int.Parse(Console.ReadLine());

            Console.WriteLine("How many sandwiches ? : ");
            int swNo = int.Parse(Console.ReadLine());

            Console.WriteLine("How many packets of chips ? : ");
            int chipsNo = int.Parse(Console.ReadLine());

            //perform bill calculations

            subTotal = (bvgsNo * beverage) + (swNo * Sandwich) + (chipsNo * Chips);
            taxAmount = (TaxRate * subTotal);
            tipAmount = (TipRate * subTotal);
            total = subTotal + taxAmount + tipAmount;

            //print out the bill

            Console.WriteLine("SubTotal {0:C}", subTotal);
            Console.WriteLine("Tax \t{0:C}", taxAmount);
            Console.WriteLine("Tip \t{0:C}", tipAmount);
            Console.WriteLine("TOTAL \t{0:C}", total);

        }
    }
}
