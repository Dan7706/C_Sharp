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
            for (int k = 1; k <= 9; k++)
            {
                Console.Write(k + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------");
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write(i * j + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
