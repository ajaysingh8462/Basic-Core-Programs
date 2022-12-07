using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacic_core_programs
{
    internal class factor
    {
        public void PrimeFac()
        {
           
            Console.WriteLine("Compute the prime factorization");
            int num, x;
            Console.WriteLine("Enter a value ");
             num = int.Parse(Console.ReadLine());

            Console.Write("Factors=");
            for (x=1; x <= num; x++)
            {
               if(num % x == 0)
                {
                    Console.WriteLine(x);
                }


            }
           

        }

    }
}
