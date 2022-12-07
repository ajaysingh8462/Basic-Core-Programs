using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacic_core_programs
{
    internal class LeapYear
    {
        public void Year()
        {
            Console.WriteLine("Enter the Year");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0 || year % 400 == 0) && year % 100 != 0)
                Console.WriteLine("Year " + year + " is Leap Year");
            else
                Console.WriteLine("Year is not a Leap Year");
        }
    }
}
