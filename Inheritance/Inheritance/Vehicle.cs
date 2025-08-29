using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Vehicle
    {
        public string Brand ;

    }
    class Car : Vehicle
    {
        public string Brand {  get; set; }
        
        public void Car1()
        {
            Console.WriteLine("Brand: " + Brand);
        }
    }
    class Bicycle : Vehicle
    {
        public string Brand1 { get; set; }

        public void Bicycle1()
        {
            Console.WriteLine("Brand: " + Brand1);
        }
    }
    class Boat : Vehicle
    {
        public string Brand2 { get; set; }

        public void Boat1()
        {
            Console.WriteLine("Brand: " + Brand2);
        }
    }
}
