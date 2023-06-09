using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class vowelCase
    {
        public void vc()
        {
            Console.WriteLine("Enter the Alphabet");
            char letter = char.Parse(Console.ReadLine());
            

            switch (letter)
            {
                case 'a':
                   
                case 'e':
                
                case 'i':
                   
                case 'o':
                 
                case 'u':
                    Console.WriteLine($"{letter} is a Vowel");
                    break;

                default:
                    Console.WriteLine($"{letter} is a Consonant");
                    break;


            }
           

        }
       
    }
}
