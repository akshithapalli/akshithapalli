using System;
using System.Collections.Generic;
using System.Text;

namespace oops_concept
{
    class secondlargest1
    {
        static void Main (string [] args)
        {
            int num, i, j = 0, lrg, lrg2nd;

            int[] arr1 = new int[50];

            Console.Write("Input the size of array : ");

            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input {0} elements in the array :\n", num);

            for (i = 0; i < num; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            lrg = 0;
            for (i = 0; i < num; i++)
            {
                if (lrg < arr1[i])
                {
                    lrg = arr1[i];
                    j = i;
                }
            }
            lrg2nd = 0;
            for (i = 0; i < num; i++)
            {
                if (i == j)
                {
                    i++;
                    i--;
                }
                else
                {
                    if (lrg2nd < arr1[i])
                    {
                        lrg2nd = arr1[i];
                    }
                }
            }
            Console.Write("The Second largest element is : {0} \n\n", lrg2nd);
Console.ReadLine();

        }

    }
}
