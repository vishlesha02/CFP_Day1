using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    class RandomNumber
    { 
        public void coinf()
        {
            Console.WriteLine("Enter the Number of times to flip the coin");
            int numberofFlips = int.Parse(Console.ReadLine());

            int headCount = 0;
            int tailCount = 0;

            Random random = new Random();


            for (int i = 0; i < numberofFlips; i++)
            {

                /* Random random = new Random();
                 int randomValue = random.Next(2);*/

                double randomValue = random.NextDouble();
               
                if (randomValue < 0.5)
                {
                    Console.WriteLine("Tails");

                    tailCount++;
                }
                else
                {
                    Console.WriteLine("Head");

                    headCount++;
                }

            }
            double t = (double)tailCount / numberofFlips * 100;
            double h = (double)headCount / numberofFlips * 100;

            Console.WriteLine($"Tails {t} " + double.Parse("0.00") + "%");
            Console.ReadLine();

            Console.WriteLine($"Heads {h} " +  double.Parse("0.00") + "%");
            Console.ReadLine();


        }
    }
}


