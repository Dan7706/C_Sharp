using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("n="); n = int.Parse(Console.ReadLine());

            int i = 2;
            do
            {
                if (n % i == 0) break;
                i++;
            }
            while (i <= n);
            Console.WriteLine("result=" + i);

        }
    }
}
