using System;
using System.Collections.Generic;
using System.Text;

namespace equal_and___
{
    class Class2
    {
        static void Main(string[]args)
        {
            sample(6);
            sample(6, 7);
            sample(6, 7, 8);

        }
        public static void sample(int x, int y=10, int z=20)
        {
            Console.WriteLine("{0},{1},{2}", x, y, z);
        }
    }
}
