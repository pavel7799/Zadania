using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {
            int a;
            double b = 0, c; 
            for (a = 1; a <= 20; a++)
            {
                c = b;
                b = 1 / Math.Pow(2, a);
                b = Math.Round(c + b,7);
            }
            
            Console.WriteLine($"S="+ b.ToString());
            
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}
