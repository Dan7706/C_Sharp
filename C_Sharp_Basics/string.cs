using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime t = DateTime.Now;
            Console.WriteLine(t);
            Console.WriteLine("Year= " + t.Year);
            //************ 
            Console.WriteLine("Month = " + t.Month);
            Console.WriteLine("Day = " + t.Day);
            Console.WriteLine("Hour = " + t.Hour);
            Console.WriteLine("Minute = " + t.Minute);
            Console.WriteLine("Second = " + t.Second);
            Console.WriteLine("Milliseconds = " + t.Millisecond);
            Console.WriteLine("Ticks = " + t.Ticks);

            
            DateTime t = DateTime.Now;
            Console.WriteLine(t);
            string s = t.Day.ToString("d2") + '/' + t.Month.ToString("d2") + '/' + t.Year.ToString("d4");
            string s1 = t.Hour.ToString("d2") + ':' + t.Minute.ToString("d2") + ':' + t.Second.ToString("d2");
            Console.WriteLine(s);
            Console.WriteLine(s1);


            string s = "abcdefcd";
            Console.WriteLine(s);
            s = s.Replace("cd", "ZZZ");
            Console.WriteLine(s);


        }
    }
}
