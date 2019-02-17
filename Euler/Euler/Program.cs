using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//G16B0398
//Used https://www.w3resource.com/euler-project/euler-problem2.php as guide


namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {

            
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
            //System.Threading.Thread.Sleep(5000);


                 int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("Multiples of 3 & 5 problem: The sum is " + sum);
            Console.ReadLine();
        }
    }
}
