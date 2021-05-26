using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Random r = new Random();
            for (int j = 0; j < n; j++)
            {
                arr[j] = r.Next(1, 50);
                Console.Write(arr[j] + " ");
            }
            Console.WriteLine();
            int x = Convert.ToInt32(Console.ReadLine());
            int[] arr2 = new int[n];
            Random r2 = new Random();
            for (int i = 0; i < n; i++)
            {
                arr2[i] = r2.Next(-x, x) * x;
                Console.Write(arr2[i] + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
