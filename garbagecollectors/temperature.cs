using System;
using System.Collections.Generic;
using System.Text;

namespace garbagecollectors
{
    class temperature
    {
        public static void Main3(string[] args)
        {
            int celsius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("kelvin= {0}", celsius + 273);
            Console.WriteLine("fahrenheit= {0}", celsius * 18 / 10 + 32);
        }
    }
}
