using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            double _principal;
            double _rate;
            double _time;
            double _amount = 0;

            Console.WriteLine("Enter Principal:");
            _principal = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter rate:");
            _rate = double.Parse(Console.ReadLine()) / 100;

            Console.WriteLine("Enter time:");
            _time = double.Parse(Console.ReadLine());

            intCalculator intcal = new intCalculator();
            _amount = intcal.calculate(_rate, _principal, _time);

            Console.WriteLine("The amount calculated with interest is  :" + _amount);
            Console.ReadLine();

        }
    }
}
