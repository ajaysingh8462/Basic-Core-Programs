// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.InteropServices;
using System.Threading;
using static Bacic_core_programs.PowerOfTow;

namespace Bacic_core_programs
{



    public class Program
    {
        public static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1. FlipCoin" +"\n" + "2.Leap yera" + "\n" + "3.PowerOfTow" + "\n" + "4.Harmonic Number" + "\n" + "5. Find Quoteint and Reminder" + "\n" + "6. Swapping Two Numbers" + "\n" + "7. Prime Fctor" + "\n" + "8. Find Even or Odd Number" + "\n" + "9. Find Alphabets - Vowel Consonant" + "\n" + "10 Find the Largest Among Three Numbers" + "\n" + "Exit");
                Console.WriteLine("Enter The Above Mention Option");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        filpcoin enter = new filpcoin();
                        enter.CheckHeadTail();
                        break;
                    case 2:
                        LeapYear leap = new LeapYear();
                        leap.Year();
                        break;
                    case 3:
                        PowerOfTwo power = new PowerOfTwo();
                        power.Table();
                        break;
                    case 4:
                        HarmonicNumber number = new HarmonicNumber();
                        number.Harmonic();
                        break;
                    case 5:
                        QuoteintAndReminder quo = new QuoteintAndReminder();
                        quo.Quotient();
                        break;
                    case 6:
                        SwapTowClass swa = new SwapTowClass();
                        swa.Swap();
                        break;
                    case 7:
                        factor prime = new factor();
                        prime.PrimeFac();
                        break;
                    case 8:
                        EvenOdd eve = new EvenOdd();
                        eve.Number();
                        break;
                    case 9:
                        VowelConsonant vow = new VowelConsonant();
                        vow.Vowels();
                        break;
                    case 10:

                        LargestAmong3Numbers checkLargest = new LargestAmong3Numbers();
                        checkLargest.Largest();
                        break;
                }
            }
        }
    }
}