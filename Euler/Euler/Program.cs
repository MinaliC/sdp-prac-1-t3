using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = 600851475143;
            long largestfactor = 0; // stores largest prime factor
            while (number % 2 == 0) //if number is divided by 2 and mod is 0 - not prime
            {
                largestfactor = 2;
                number = number / 2; //keep on dividing by 2 to get rid of even factors
            }
            for (int i = 3; i <= Math.Sqrt(number); i = i + 2)
            {
                while (number % i == 0) //go through all numbers that are odd and mod, if equal 0 - prime factor
                {
                    largestfactor = i; //store largest factor
                    number = number / i; //continue with process
                }
            }
            if (number > 2) //making sure that 0 and 1 are not considered as prime factors
            {
                largestfactor = number;
            }
            Console.WriteLine($"Problem 3: The largest prime factor of the number 600851475143 is {largestfactor}");
            Console.ReadLine();
        }
        }
        }
    

