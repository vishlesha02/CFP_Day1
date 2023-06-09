using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    class LeapYear
    {
        public void leapy()
        {
            Console.WriteLine("Enter the Leap Year");
            int year = int.Parse(Console.ReadLine());

            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            { 
                Console.WriteLine($"{year} is a Leap Year ");
            }

            else
            {
                Console.WriteLine($"{year} is not a Leap Year");
                Console.ReadLine();
            }
        }
    }
}
