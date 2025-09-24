using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encap_Compute
{
    internal class Student
    {
        private double miscellaneousfee {  get; set; }

        public double Miscellaneousfee = 40000;


        public void DisplayM()
        {
            Console.WriteLine("Miscellaneousfee =" + Miscellaneousfee);
        }
        
    }
    class IrregularClass : Student
    {
        private int noofunits;
        private double rateperunit;

        public int Noofunits
        {
            get { return noofunits; }
            set { noofunits = value; }
        }
        public double Rateperunit
        {
            get { return rateperunit; }
            set { rateperunit = value; }
        }
        public void DisplayI()
        {
            Console.WriteLine("----Irregular Student Tuition Fee----");
            Console.WriteLine("No. of Unit: " +  Noofunits);
            Console.WriteLine("Rate Per Unit: " + rateperunit);
            Console.WriteLine("Total: " + (Noofunits * Rateperunit));
        }
    }
    class Working : Student
    {
        private double tuitionfeediscount;
        private int noofunits;
        private double rateperunit;

        public double Tuitionfeediscount
        {
            get { return tuitionfeediscount; }
            set { tuitionfeediscount = value; }
        }
        public int Noofunits
        {
            get { return noofunits; }
            set { noofunits = value; }
        }
        public double Rateperunit
        {
            get { return rateperunit; }
            set { rateperunit = value; }
        }

        public void DisplayT()
        {
            Console.WriteLine("----Working Student----");
            Console.WriteLine("No. of Unit: " + Noofunits);
            Console.WriteLine("Rate Per Unit: " + rateperunit);
            Console.WriteLine("TuitionDiscount: " + Tuitionfeediscount);
            Console.WriteLine("Total Discount: " + (Tuitionfeediscount - (Noofunits * Rateperunit)));
        }
    }
}
