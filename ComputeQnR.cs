using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class ComputeQnR
    {
        public void compute()
        {
            Console.WriteLine("Enter the Divident");
            int divident = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Divisor");
            int divisor = int.Parse(Console.ReadLine());

            int q = divident / divisor;
            int r = divident % divisor;

            Console.WriteLine($"The Quotient is {q}");
            Console.WriteLine($"The Reminder is {r}");

        }
    }
}
