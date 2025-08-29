using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Input Car Brand: ");
            string brand = Console.ReadLine();

            Car car1 = new Car { Brand = brand };
            car1.Car1();


            Console.Write("Input Bicycle Brand: ");
            string brand1 = Console.ReadLine();

            Bicycle bicyle1 = new Bicycle { Brand1 = brand1 };
            bicyle1.Bicycle1();


            Console.Write("Input Boat Brand: ");
            string brand2 = Console.ReadLine();

            Boat boat1 = new Boat { Brand2 = brand2 };
            boat1.Boat1();

            Console.WriteLine("YOUR CHOSEN BRAND ARE: " + brand + " " + brand1 + " " + brand2);


            Console.ReadKey();
        }
    }
}
