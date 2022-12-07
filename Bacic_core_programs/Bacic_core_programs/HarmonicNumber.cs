using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacic_core_programs
{
   
        public class HarmonicNumber
        {
            public double Harmonic()
            {
                double num = 0;
                Console.WriteLine("Enter the number");
                double value = Convert.ToInt32(Console.ReadLine());
                for (double i = 1; i <= value; i++)
                {
                    num += (double)(1 / i);
                    Console.WriteLine(" Series is "  + num);
                }

                return num;
            }
        }
}