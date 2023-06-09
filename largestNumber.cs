using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class largestNumber
    {
        public void largenum()
        {
            int num1, num2, num3;

            Console.WriteLine("Enter first Number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second Number");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter third Number");
            num3 = int.Parse(Console.ReadLine());

            int largest = num1;

            if (num2 > largest)
            {
                largest = num2;
            }

            if (num3 > largest)
            {
                largest = num3;
            }

            Console.WriteLine($"The largest number is : {largest}");

        }
    }
}
