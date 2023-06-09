using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class powerOfTwo
    {
        /*n=input
        If(n<32)
        {
        For(i=1;i<n;i++)
        }
        Else
        {
        Print(enter valid number)
        }*/

        public void power()
        {
            Console.WriteLine("Enter the Number");
            int n = int.Parse(Console.ReadLine());

            if (n < 32)
            {
                for (int i = 1; i < n; i++)
                {
                    Console.WriteLine(i*2);
                }

            }
            else {

                Console.WriteLine("Enter valid Number");
                    }
        }
    }
}
