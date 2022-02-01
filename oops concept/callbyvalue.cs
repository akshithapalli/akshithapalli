using System;
using System.Collections.Generic;
using System.Text;

namespace oops_concept
{
    class callbyvalue
    {
        static void Main4(string[]args)
        {
            int a = 6;
            int b = 5;
            Console.WriteLine("Value of a= {0} and b = {1}  before swap", a, b);
            swap(ref a, ref b);
            Console.WriteLine("Value of a= {0} and b = {1} after swap", a, b);
        }
        static void swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("Value of a= {0} and b = {1} after swap into Swap function", a, b);
        }

    }
}
