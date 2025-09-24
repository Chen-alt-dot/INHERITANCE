using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encap_Compute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TuitionFee");
            Student student = new Student();
            student.DisplayM();

            IrregularClass I1 = new IrregularClass();
            I1.Noofunits = 18;
            I1.Rateperunit = 2000;
            I1.DisplayI();

            Working working = new Working();
            working.Tuitionfeediscount = 1;
            working.Noofunits = 18;
            working.Rateperunit = 2000;
            working.DisplayT();
            
        }
    }
}
