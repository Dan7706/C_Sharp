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
            int n;
            Console.Write("Enter a numnber: "); n = int.Parse(Console.ReadLine());
            int sum = 0;   // n=234 s=4; n=23 s=7; n=2; s=9
            while (n != 0)
            {
                int x = n % 10;
                if(x % 2 == 0)
                {
                    sum += n % 10;
                }
                
                n = n / 10;

            }
            Console.WriteLine("Number Count = " + sum);
        }
    }
}
