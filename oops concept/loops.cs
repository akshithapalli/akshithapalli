using System;
using System.Collections.Generic;
using System.Text;

namespace oops_concept
{
    class loops
    {
        static void Main(string[]args)
        {
            int i, j, rows, k = 1;
            Console.Write("Enter a rows: "); 
            rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(); 
            for ( i = 1; i <= rows; i++)
            { 
                for ( j = 1; j <= i; j++) 
                    Console.Write("{0}",k++);
                Console.WriteLine("\n");
            }

        }
    }
}
