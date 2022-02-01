using System;
using System.Collections.Generic;
using System.Text;

namespace oops_concept
{
    class functions
    {
        static void Main3(string[] args)
        {
            Console.Write("Enter a Number : ");
            int number = int.Parse(Console.ReadLine());
            long factorial = RecursiveFactorial(number);
            Console.Write($"Factorial of {number} is: {factorial}");

            Console.ReadLine();
        }
        static long RecursiveFactorial(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            else
            {
                return number * RecursiveFactorial(number - 1);
            }
        }

    }
}
