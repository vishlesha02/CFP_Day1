using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    class HarmonicNumber
    {
        public void harmonic()
        {
          
            double result = 0.0;

            Console.WriteLine("Enter the Number");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Harmonic of given Number is : ");
            for (int i = n; i > 0; i--)
            {
                result = ((result + (double)1) / i);
                Console.Write(result + " , ");
            }
        }
    }
}
