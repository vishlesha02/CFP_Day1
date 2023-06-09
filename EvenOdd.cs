using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class EvenOdd
    {
        public void evodd()
        {
            Console.Write("Enter the Number : ");
            int i = int.Parse(Console.ReadLine());

            if ( i % 2 == 0)
            {
                Console.WriteLine($"{i} is an Even Number");
            }
            else {

                Console.WriteLine($"{i} is an ODD Number");
            }
        }
    }
}
