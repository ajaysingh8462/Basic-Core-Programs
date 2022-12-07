using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Bacic_core_programs
{
    internal class LargestAmong3Numbers
    {
        public void Largest()
        {
            
            Console.WriteLine("Enter number1");
            int number1= Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter number2");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number3");
            int number3 = Convert.ToInt32(Console.ReadLine());


            if ((number1 == number2) && number2 == number3)
                Console.WriteLine("All inputs are equal");
            if (number1 > number2 && number1 > number3)
                Console.WriteLine($"{number1} is greater");
            if (number2 > number1 && number2 > number3)
                Console.WriteLine($"{number2} is greater");
            if (number3 > number1 && number3 > number2)
                Console.WriteLine($"{number3} is greater");
        }
    }
}
