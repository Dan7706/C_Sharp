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
            Stack<int> numbers = new Stack<int>();
            numbers.Push(3);
            numbers.Push(5);
            numbers.Push(8);
            Console.WriteLine("Count=" + numbers.Count);
            Console.WriteLine("Peek=" + numbers.Peek());

            while (numbers.Count != 0)
            {
                int num = numbers.Pop();
                Console.WriteLine(num);
            }
            Console.WriteLine("Count=" + numbers.Count);
           
            Queue<int> numbers = new Queue<int>();
            numbers.Enqueue(3);
            numbers.Enqueue(5);
            numbers.Enqueue(8);
            
            Console.WriteLine("Count=" + numbers.Count);
            Console.WriteLine("Peek=" + numbers.Peek());

            while (numbers.Count != 0)
            {
                int num = numbers.Dequeue();
                Console.WriteLine(num);
            }
            Console.WriteLine("Count=" + numbers.Count);

        }
    }
}
