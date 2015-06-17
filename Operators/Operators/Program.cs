using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------Arithmetic Operators------------------
            //			int x = 20, y = 10; 
            //				 
            //			Double z = 20.50; 
            //			 
            //			Console.WriteLine("x+y=" + (x + y)); 			 
            //			Console.WriteLine("x-y=" + (x - y)); 			 
            //			Console.WriteLine("x*y=" + (x * y)); 			 
            //			Console.WriteLine("x/y=" + (x / y));			 
            //			Console.WriteLine("x%y=" + (x % y));			 
            //			Console.WriteLine("x+z=" + (x + z)); 		
            //			Console.WriteLine("x*z=" + (x * z)); 		
            //			Console.WriteLine("z/x=" + (z / x)); 		
            //			Console.WriteLine("z/y=" + (z / y)); 
            //			Console.ReadLine();

            //-------------Logical Operators------------------

            //				int x = 60, y = 500;
            //				int z = 1000; 
            //				if (x > 30 && y < 1000 || z >= 1000) 
            //				{   x++; 
            //					y--; 
            //					z--; 
            //					x = x-- + ++z;
            //					Console.WriteLine("value of x is :"+x); 
            //					Console.WriteLine("value of y is :" + y); 
            //					Console.WriteLine("value of z is :" + z); 
            //					Console.ReadLine(); 
            //
            //				}

            //-------------Relational Operators------------------

            int x = 40, y = 80;
            float z = 15.0F;

            Console.WriteLine("x<y is" + (x < y));
            Console.WriteLine("x>y is" + (x > y));
            Console.WriteLine("x<=y is" + (x <= y));
            Console.WriteLine("x!=y is" + (x != y));
            Console.WriteLine("x>=y is" + (x >= y));
            Console.WriteLine("x==y is" + (x == y));
            Console.WriteLine("z is" + z);
            Console.ReadLine();



        }
    }
}
