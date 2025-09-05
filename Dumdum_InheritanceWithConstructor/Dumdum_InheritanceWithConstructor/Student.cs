using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Dumdum_InheritanceWithConstructor
{
    // Name: Christian Benedict P. Dumdum
    // Section: IT301
    // EXER_07: Simple Inheritance with Constructor
    class Student  // Base Class
    {
        //Fields of the Base Class
        public string name;
        public string program;

        //Constructor of the Base Class
        public Student(string aName, string aProgram)
        {
            name = aName;
            program = aProgram;
        }
        //Method of the Base Class
        public void BasicInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Program: " + program);
        }
    }

    class RegularStudent : Student // Derived Class
    {
        public string section; //Field of the Regular Student Derived Class

        // Constructor of the Regular Student Derived Class
        public RegularStudent(string aSection , string aName, string aProgram ) : base( aName, aProgram )
        {
            section = aSection;
        }
        
        // Method of the Regular Student Derived Class
        public void SectionEnrolled()
        {
            Console.WriteLine("Section: " + section);
        }
    }
    class IrregularStudent : Student // Derived Class
    {
        // Field of the Irregular Student Derived Class
        public string unitsenrolled;

        // Constructor of the Irregular Student Derived Class
        public IrregularStudent(string aUnitsEnrolled, string aName, string aProgram) : base( aName, aProgram)
        {
            unitsenrolled = aUnitsEnrolled;
        }
        //Method of the Irregular Student Derived Class
        public void EnrolledSemUnits()
        {
            Console.WriteLine("UnitsEnrolled: " + unitsenrolled);
        }
    }
}
