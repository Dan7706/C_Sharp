using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day;
            Console.Write("Enter a day from 1 - 7: ");
            day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1: Console.WriteLine("It's Monday!");break;
                case 2: Console.WriteLine("It's Tuesday!");break;
                case 3: Console.WriteLine("It's Wednesday!"); break;
                case 4: Console.WriteLine("It's Thursday!"); break;
                case 5: Console.WriteLine("It's Friday!"); break;
                case 6: Console.WriteLine("It's Saturday!"); break;
                case 7: Console.WriteLine("It's Sunday!"); break;
                default: Console.WriteLine("Error!"); break;

            }
        }
    }
}
