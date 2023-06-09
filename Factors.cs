using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    class Factors
    {
        public void primeFactorization()
        {

            Console.Write("Enter the Number : ");
            int n = int.Parse(Console.ReadLine());

            int count = 0;

            Console.WriteLine($"The prime Factors of {n} are : ");

            for (int i = 2; i < n + 1; i++)
            {
               
                while (n % i == 0)
                { 
                    n = n / i;
                   
                    count++;
                    Console.WriteLine(i);
                    break;
                }
                if (n == 1 || n == 2)
                    break;
            }
        }
    }
}
