using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradePoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool n = true;

            while(n == true)
            {
                Console.Write("Enter Your Number : ");
                double Number = Convert.ToDouble(Console.ReadLine());

                Console.Write("Your Grade Is : ");

                if (Number > 100 || Number < 0)
                {
                    Console.Write("Please, Enter A Number Between 0 to 100\n");
                }
                else if (Number >= 80)
                {
                    Console.Write("A+\n");
                }
                else if (Number >= 70 && Number <= 79)
                {
                    Console.Write("A\n");
                }
                else if (Number >= 60 && Number <= 69)
                {
                    Console.Write("A-\n");
                }
                else if (Number >= 50 && Number <= 59)
                {
                    Console.Write("B\n");
                }
                else if (Number >= 40 && Number <= 49)
                {
                    Console.Write("C\n");
                }
                else if (Number >= 33 && Number <= 39)
                {
                    Console.Write("D\n");
                }
                else
                {
                    Console.Write("F\n");
                }
                Console.Write("Want's to do again?\n: ");

                n = Convert.ToBoolean(Console.ReadLine());
            }
        }
    }
}
