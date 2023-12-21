using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class MyClass
    {
        private string city = "Gyumri", name = "Daniel", phone = "123456";

        public MyClass(string city, string name, string phone)
        {
            this.city = city;
            this.name = name;
            this.phone = phone;
        }
        public MyClass(MyClass ob)
        {
            this.city = ob.city;
            this.name = ob.name;
            this.phone = ob.phone;
        }

        public MyClass()
        {

        }
        public void Show()
        {
            Console.WriteLine("City: " + city + "\t" + "Name: " + name + "\t" + "Phone: " + phone);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string city, name, phone;
            Console.Write("Enter City: "); city = Console.ReadLine();
            Console.Write("Enter Name: "); name = Console.ReadLine();
            Console.Write("Enter Phone: "); phone = Console.ReadLine();
            MyClass ob = new MyClass(city, name, phone);
            ob.Show();

            MyClass ob1 = new MyClass();
            ob1.Show();
            MyClass ob2 = new MyClass(ob);
            ob2.Show();
           
        }
    }
}
