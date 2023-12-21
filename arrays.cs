using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 20, 19, 88, 2, 5 , 66};
            
            for (int i = 0; i < arr.Length; i++)
            {

                Console.WriteLine(i + "\t" + arr[i]);
            }
            Console.WriteLine("---------------------------------------");
            int j = arr.Length - 1;
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int x = arr[j];
                arr[j] = arr[i];
                arr[i] = x; 
                j--;
                
            }
            for (int i = 0; i < arr.Length; i++)
            {

                Console.WriteLine(i + "\t" + arr[i]);
            }

        }
    }
}
