using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            short x1, x2, x3, x4, x5, x6;
            x1 = x2 = x3 = x4 = x5 = x6 = 0;
            for(int i = 1; i <= 100000; i++)
            {
                int x = rnd.Next(0, 6);
                switch (x)
                {
                    case 0: x1++; break;
                    case 1: x2++; break;
                    case 2: x3++; break;
                    case 3: x4++; break;
                    case 4: x5++; break;
                    case 5: x6++; break;
      
                }
                
            }
            Console.WriteLine("1 = " + x1);
            Console.WriteLine("2 = " + x2);
            Console.WriteLine("3 = " + x3);
            Console.WriteLine("4 = " + x4);
            Console.WriteLine("5 = " + x5);
            Console.WriteLine("6 = " + x6);
        }
    }
}
