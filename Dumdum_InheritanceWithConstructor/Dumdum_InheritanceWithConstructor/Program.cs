using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dumdum_InheritanceWithConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Regular Student Sign
            Console.WriteLine("-----Regular Student-----");
            //Instantiate an Object for Regular Student Derived Class
            RegularStudent student1 = new RegularStudent("IT301" , "Christian Benedict P. Dumdum", "BSIT");

            //Methods for Regular Student Derived Class
            student1.BasicInfo();
            student1.SectionEnrolled();

            Console.WriteLine(" ");

            //Irregular Student Derived Class
            Console.WriteLine("-----Regular Student-----");

            //Instantiate and object for Irregular Student Derived Class
            IrregularStudent student2 = new IrregularStudent("18", "Gian Marty Pepito", "BSIT");

            //Methods for Irregular Student Derived Class
            student2.BasicInfo();
            student2.EnrolledSemUnits();

            Console.ReadKey();
        }
    }
}
