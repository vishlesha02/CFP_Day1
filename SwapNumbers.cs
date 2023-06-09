using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class SwapNumbers
    {
        public void swap()
        {
            Console.WriteLine("Enter Num 1");
            int num1=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Num 2");
            int num2 = int.Parse(Console.ReadLine());

            int temp;

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("After Swapping the Numbers : ");
            Console.WriteLine($"Number 1 = {num1}");
            Console.WriteLine($"Number 2 = {num2}");
        }
    }
}
