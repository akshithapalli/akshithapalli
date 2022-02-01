using System;
using System.Collections.Generic;
using System.Text;

namespace oops_concept
{
    class duplicate
    {
       static void Main5 (string[]args)
        {
            int[] a = new int[10];
            int i, j, count = 0;
            Console.WriteLine("enter array values");
            for(i=0;i<10;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("\n");
            for(i=0;i<10;i++)
            {
                for(j=i+1;j<10;j++)
                {
                    if(a[i]==a[j])
                    {
                        count++;
                        break;
                    }
                }
            }
            Console.WriteLine("duplicate elementsin array is={0}", count);
            Console.ReadLine();
        }

    }
}
