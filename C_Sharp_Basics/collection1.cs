using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class myReverserClass : IComparer
    {
        // Calls CaseInsensitiveComparer.Compare with the parameters reversed.
        int IComparer.Compare(Object x, Object y)
        {
            return ((new CaseInsensitiveComparer()).Compare(y, x));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            int count;
            Console.Write("Enter count: "); count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter a string: ");
                arr.Add(Console.ReadLine());
            }
            for (int i = 0; i != arr.Count; i++)
            {
                Console.WriteLine(i + "\t" + arr[i]);
            }
            Console.WriteLine("---------------------------------");
            IComparer myComparer = new myReverserClass();
            arr.Sort(myComparer);
            for (int i = 0; i != arr.Count; i++)
            {
                Console.WriteLine(i + "\t" + arr[i]);
            }
           
        }
    }
}
