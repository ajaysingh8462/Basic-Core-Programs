using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacic_core_programs

{
    internal class filpcoin
    {
        double HeadCount = 0, TailCount = 0, PersentageOfHead = 0, PersentageOfTail = 0;
        public void CheckHeadTail()
        {
            Console.WriteLine("Enter no. of times you want to flip the coin");
            int numOfCount = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= numOfCount; i++)
            {
                Random ranobj = new Random();
                double randomNumber = ranobj.NextDouble();
                if (randomNumber < 0.5)
                {
                    Console.WriteLine("Its Tail");
                    TailCount++;
                    
                }
                else
                {
                    Console.WriteLine("Its Head");
                    HeadCount++;
                    
                }

            }
            Console.WriteLine("Head count : " + HeadCount);
            Console.WriteLine("Tail Count: " + TailCount);
            Console.WriteLine("*****parcentage of Head and Tail*****");
            PersentageOfHead = HeadCount / numOfCount * 100;
            PersentageOfTail = TailCount / numOfCount * 100;
            Console.WriteLine("Persentage of head :" + PersentageOfHead);
            Console.WriteLine("Persentage of Tail :" + PersentageOfTail);

        }    

    }
}
