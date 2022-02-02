using System;
using System.Collections.Generic;
using System.Text;

namespace oopconcept
{
    class stringsubtraction
    {
        static void Main2(string[]args)
        {
            string a; 
            char[] b;
            int L, i, count = 0, position, SubStringlen; 
            Console.WriteLine("Enter the string"); 
            a = Console.ReadLine(); 
            L = a.Length;
            Console.WriteLine("The Length of the Entered String is={0}", L);
            b = a.ToCharArray(0, L); 
            Console.WriteLine("\n"); 
            Console.WriteLine("Enter the Position of SubString Starts:");
            position = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("\n");
            Console.WriteLine("Enter Length of SubString:"); 
            SubStringlen = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("\n");
            Console.WriteLine("The Extracted SubString is:"); 
            for (i = position; i < L; i++) 
            {
                count++; 
                Console.Write("{0}", a[i]);
                if (count == SubStringlen)
                {
                    break; 
                } 
            }
            Console.ReadLine();
        }
    }
}
