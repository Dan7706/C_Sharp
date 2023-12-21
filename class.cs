using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class myClass1 //ключевое слово class и тег MyClass(имя выбирает пользователь)
    {
        public  int N = 10;
        public void Print()
        {
            Console.WriteLine("N=" + N);
        }
    }
    
      class myClass
    {
        private int N;
        public void SetNumber(int num)
        {
            N = num;
        }
        public int GetNumber()
        {
            return N;
        }
        public string str = "Hello";
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            myClass1 ob = new myClass1();
            ob.N = 15; ob.Print();
            

            myClass ob1, ob2;
            ob1 = new myClass();
            ob1.SetNumber(10);
            Console.WriteLine("ob1=" + ob1.GetNumber());

            ob2 = ob1;
            Console.WriteLine("ob2=" + ob2.GetNumber());

            Console.WriteLine("Inicializator=" + ob2.str);


        }
    }
}
