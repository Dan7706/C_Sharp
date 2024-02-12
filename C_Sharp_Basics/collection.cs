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
            string[] str = new string[4];
            for(int i = 0; i < str.Length; i++)
            {
                Console.Write("Enter a text: "); str[i] = Console.ReadLine();
            }
            Array.Sort(str);
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(i + "\t" + str[i]);
            }
            Console.Write("Enter a text: ");
            string s = Console.ReadLine();
            int num = Array.BinarySearch(str, s);
            Console.WriteLine("Result = " + num);
            Array.Reverse(str);
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(i + "\t" + str[i]);
            }
        }
    }
}
