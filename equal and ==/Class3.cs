using System;
using System.Collections.Generic;
using System.Text;

namespace equal_and___
{
    class Class3
    {
        static void main(string[] args)
        {
            string s = "some value";
            s = "akshitha";
            s = s.Replace("akshitha", "1,2,3");
            var valuearray = s.Split(',');
            Console.WriteLine("values after spliting");
            for(int i=0;i<valuearray.Length;i++)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine(s);
            StringBuilder sb = new StringBuilder("Hello World");
            sb.Append("hello");
            sb.Replace("hello", "hello 1");
            sb.Insert(0, "new value");
            Console.WriteLine(sb);
        }
    }
}
