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
            string[] str = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            float[] f = new float[str.Length];
            int i = 0;
            while (i != str.Length)
            {
                
                Console.Write(str[i] + "\t");
                f[i] = float.Parse(Console.ReadLine());
                
                i++;
            }
            float sum = 0;
            i = 0;
            while (i != f.Length)
            {

                
                sum += f[i];

                i++;
            }
            Console.WriteLine("Mijin temp = " + sum / str.Length);

        }
    }
}
