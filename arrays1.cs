using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count;
            Console.Write("Enter count Array:"); count = int.Parse(Console.ReadLine());

            int[] arr = new int[count];
            for (int i = 0; i != arr.Length; i++)
            {
                Console.Write("Enter Number:"); arr[i] = int.Parse(Console.ReadLine());
            }
            bool b = false;
            for (int i = 0; i != arr.Length - 1; i++)
            {
                if (arr[i] < 0 && arr[i + 1] < 0)
                {
                    b = true; break;
                }
                if (arr[i] > 0 && arr[i + 1] > 0)
                {
                    b = true; break;
                }
            }
            if (b) Console.WriteLine("Two next elements are greater or smaller 0!"); else Console.WriteLine("Normal!");

        }
    }
}
