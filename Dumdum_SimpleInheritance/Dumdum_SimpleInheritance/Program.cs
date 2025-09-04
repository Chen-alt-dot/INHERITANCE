using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dumdum_SimpleInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Regular Student----");
            // Create instances of Basic Info and Regular Student
            Student student1 = new Student();
            student1.Name = "Christian Benedict P. Dumdum";
            student1.Program = "BSIT";
            RegularStudent regularStudent1 = new RegularStudent();
            regularStudent1.Section = "IT301";
            student1.BasicInfo(); // Inherited Method
            regularStudent1.SectionEnrolled(); // Regular Student Specific Method

            Console.WriteLine("");

            Console.WriteLine("----Irregular Student----");
            //Create instances of Basic Info and Irregular Student
            IrregularStudent irregularstudent1 = new IrregularStudent();
            irregularstudent1.Name = "Gian Marty Pepito";
            irregularstudent1.Program = "BSIT";
            irregularstudent1.UnitsEnrolled = 18;
            irregularstudent1.BasicInfo(); // Inherited Method
            irregularstudent1.EnrolledSemUnits(); // Irregular Student Specific Method

            Console.ReadKey();
        }
    }
}
