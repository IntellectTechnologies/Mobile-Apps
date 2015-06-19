using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //			
            //			try
            //			{
            //				int divByZero = 42 / int.Parse("0");
            //			}
            //			catch (DivideByZeroException ex)
            //			{
            //				
            //				Console.WriteLine (ex.Message.ToString ());
            //			}



            try
            {
                using (var text = File.OpenText("saved_game001.txt"))
                {
                    Console.WriteLine("{0}", text.ReadLine());

                }
            }
            catch (FileNotFoundException ex)
            {
                Insights.Report(ex, new Dictionary<string, string>
					{
						{ "Filename", "saved_game001.txt" },
						{ "Where", "Reload game" },
						{ "Issue", "Index of available games is corrupted" }
					});
            }



        }
    }
}
