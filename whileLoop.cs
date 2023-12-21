using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("n="); n = int.Parse(Console.ReadLine());
            int x = n;
            int sum = 0;
            do
            {
                sum = sum * 10 + n % 10;
                n = n / 10;


            } while (n != 0);
            Console.WriteLine("Reverse = " + sum);
            if (x == sum)
            {
                Console.WriteLine("Simmetric!");
            }
            else
            {
                Console.WriteLine("Not Simmetric!");
            }
        }
    }
}
