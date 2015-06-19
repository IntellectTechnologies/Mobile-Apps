using System;

namespace Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            Color mycolor =  new Color();
            String color = mycolor.DarkGreen;
            Console.WriteLine("The colour is :{0}", color);

            Console.ReadLine();

        }
    }
}
