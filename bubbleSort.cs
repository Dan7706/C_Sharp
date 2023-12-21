using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int[] arr = { 4, 56, 97, 45, 0, 8, 23, 17, 97, 55 };
            // вывести на экран содержимое массива array
            for (i = 0; i != arr.Length; i++) Console.WriteLine(i + "\t" + arr[i]);
            //...........................
            for (;; )            // осуществить 9 проходов
            {
                bool b = true;
                for (i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] < arr[i + 1])
                    {
                        int N = arr[i];     //поменять местами содержимое элементов массива
                        arr[i] = arr[i + 1];
                        arr[i + 1] = N;
                        b = false;
                    }
                }
                if (b) break;
               
            }
            Console.WriteLine("----------------");
            // вывести на экран результат сортировки
            for (i = 0; i != arr.Length; i++)
            {
                Console.WriteLine(i + "\t" + arr[i]);
            }
            Console.WriteLine("----------------");
        }
    }
}
