using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] nArr = { { 1, 2, 3, 4 }, { 11, 22, 0, 5 }, { 10, 20, 4, 3 } };

            Console.WriteLine("row= " + nArr.GetLength(0) + "\tcol= " + nArr.GetLength(1));
            int sum = 0;

            for (int i = 0; i != nArr.GetLength(0); i++)
            {
                for (int j = 0; j != nArr.GetLength(1); j++)
                {
                    Console.Write(nArr[i, j] + "\t");
                    sum += nArr[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine("Sum = " + sum);

        }
    }
}
