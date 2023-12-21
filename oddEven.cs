using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Enter A: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter B: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Enter C: ");
            c = int.Parse(Console.ReadLine());
            if (a %2 == 0 && b % 2 == 0 && c % 2 == 0)
            {
                Console.WriteLine("NO, EVEN");

            }
            else
            {
                if (a % 2 == 1 && b % 2 == 1 && c % 2 == 1)
                {
                    Console.WriteLine("NO, ODD");
                }
                else
                {
                    Console.WriteLine("YES");
                }
                   
            }
        }
    }
}
