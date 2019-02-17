using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//G16B0398 - Sivesha
//Used https://www.w3resource.com/euler-project/euler-problem2.php as guide
//G17D1728 (Ammaarah) - Used https://www.geeksforgeeks.org/find-largest-prime-factor-number/ as a guide


namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Multiples of 3 & 5 problem - Minali
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("Multiples of 3 & 5 problem: The sum is " + sum);
        
            //Fibonacci Numbers Problem Sivesha - Sivesha
            int x1 = 0; //first number
            int x2 = 1;// second number
            int result = 0; // total of addition
            int Sum = 0; // sum of results

            while (result < 4000000)
            {
                result = x1 + x2; // addition of fibonacci numbers

                x1 = x2;          // move onto next number
                x2 = result;      // result is the next fibonacci number


                if (result % 2 == 0) // if result is even
                {
                    Sum += result; // add the result to the sum
                }


            }

            Console.WriteLine("Fibonacci Problem: The sum is " + Sum);
            System.Threading.Thread.Sleep(5000);

            //Largest Prime Factor Problem - Ammaarah 
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
            Console.WriteLine($"Largest Prime Factor Problem: The largest prime factor of the number 600851475143 is {largestfactor}");
            Console.ReadLine();
        }
        }
        }
    

