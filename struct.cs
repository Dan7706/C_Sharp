using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        struct Time
        {
            public int hour;
            public int minute;
        }

        struct MyStruct
        {
            public double d;
            public int n;
        }

        struct StrBuffer
        {
           public string s;
        }

        struct MyMath
        {
            public double sin, cos, tan;
        }

        static void Main(string[] args)
        {
            
            
            double degree;
            Console.Write("Enter Degree: "); degree = double.Parse(Console.ReadLine());
            MyMath ob;
            ob.sin = Math.Sin(degree * Math.PI / 180);
            ob.cos = Math.Cos(degree * Math.PI / 180);
            ob.tan = Math.Tan(degree * Math.PI / 180);
            Console.WriteLine("Sin = " + ob.sin.ToString("f2"));
            Console.WriteLine("Cos = " + ob.cos.ToString("f2"));
            Console.WriteLine("Tan = " + ob.tan.ToString("f2"));

            
            Console.Write("Enter text: "); string text = Console.ReadLine();
            StrBuffer ob;
            ob.s = text;
            Console.WriteLine(ob.s.ToLower());
            Console.WriteLine(ob.s.ToUpper());
            Console.WriteLine("Len = " + ob.s.Length);
            ob.s = ob.s.Insert(1, "WWW");
            Console.WriteLine(ob.s);
            Console.WriteLine(ob.s.Substring(2, 3));
            
            MyStruct ob;
            ob.d = 2.45; Console.WriteLine("Struct Double = " + ob.d);
            ob.n = 35; Console.WriteLine("Struct Int = " + ob.n);
            MyStruct ob1;
            ob1 = ob;
            Console.WriteLine("Struct Double = " + ob1.d);
            Console.WriteLine("Struct Int = " + ob1.n);
            
            
            Time ob;
            Console.Write("Enter hour: "); ob.hour = int.Parse(Console.ReadLine());
            Console.Write("Enter Minutes: "); ob.minute = int.Parse(Console.ReadLine());
            Console.WriteLine(ob.hour.ToString("d2") + ":" + ob.minute.ToString("d2"));
            Time ob1;
            DateTime t = DateTime.Now;
            ob1.hour = t.Hour;
            ob1.minute = t.Minute;
            Console.WriteLine(ob1.hour.ToString("d2") + ":" + ob1.minute.ToString("d2"));


        }
    }
}
