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
            int[] arr1 = { 4, 17, 77, 23, 11 };
            int[] arr2 = { 6, 7, 8, 11, 20 };
            int[] arr3 = new int[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] > arr2[i])
                {
                    arr3[i] = arr1[i];
                }
                else
                {
                    arr3[i] = arr2[i];
                }
            }
            for (int i = 0; i < arr2.Length; i++)
            {

                Console.WriteLine(i + "\t" + arr1[i] + "\t" + arr2[i] + "\t" + arr3[i]);
            }
        }
    }
}
