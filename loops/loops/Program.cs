using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------While Loop-------------------
            //int number = 0;
            //
            //			while(number < 5)
            //			{
            //				Console.WriteLine(number);
            //				number = number + 1;
            //			}
            //
            //			Console.ReadLine();

            //-----------------For Loop-------------------
            //			int number = 5;
            //
            //			for(int i = 0; i < number; i++)
            //				Console.WriteLine(i);
            //
            //			Console.ReadLine();

            //-----------------Foreach Loop-------------------

            ArrayList list = new ArrayList();
            list.Add("John Doe");
            list.Add("Jane Doe");
            list.Add("Someone Else");

            foreach (string name in list)
                Console.WriteLine(name);

            Console.ReadLine();

        }
    }
}
