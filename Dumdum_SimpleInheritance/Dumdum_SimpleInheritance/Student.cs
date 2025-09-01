using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dumdum_SimpleInheritance
{
    //Name: Christian Benedict P. Dumdum
    //Section: IT301
    //EXER_06: Simple Inheritance


    class Student  // Base Class
    {

        // Base Class Properties
       public string Name { get; set; }
       
        public string Program { get; set; }

        // Base Class Method
        public void BasicInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Program: " + Program);
        }
    }
    class RegularStudent : Student  // Derived Class
    {
        // Property Specificically for RegularStudent
        public string Section { get; set; }

        // Method Specifically for Regular Student
        public void SectionEnrolled()
        {
            Console.WriteLine("Section Enrolled: " + Section);
        }
    }
    class IrregularStudent : Student  // Derived Class
    {
        // Property Specifically for Irregular Student
        public int UnitsEnrolled { get; set; }

        // Method Specifically for Irregular Student
        public void EnrolledSemUnits()
        {
            Console.WriteLine("Enrolled Sem Units: " + UnitsEnrolled);
        }
    }
}
