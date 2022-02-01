using System;

namespace boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //STRING
            /*int i = 123;
            object o = i;
            //boxing
            Console.WriteLine(o);
            o = 123;
            i = (int)o;
            */

            /* String[] cars = { "volvo", "BMW", "EV", "TATA NEXON" };
             for (int i = 0; i < cars.Length; i++)
             {
                 Console.WriteLine(cars[i]);
             }
            */
            //****
            //***
            //**
            //*

            /*for (int row = 4; row>=1; -- row)
             {
               for (int col= 1; col<= row; ++col)
                 {
                     Console.Write("*");
                 }
                 Console.WriteLine();
             }*/
            //*
            //**
            //***
            //****

            /*
            }*/
            //PALINDROM
            /* int r, sum=0,temp;
             Console.WriteLine("ENTER THE NUMBER");
             int n = Convert.ToInt32(Console.ReadLine());
             temp = n;
             while(n>0)
             {
                 r = n % 10;
                 sum = (sum * 10) + r;
                 n = n / 10;
             }
             if (temp == sum)
                 Console.WriteLine("NUMBER IS PALINDROME" + n);
             else
                 Console.WriteLine("NUMBER IS NOT PALINDROME" + n);
            */
            //*****
            //*****
            //*****
            //****
            /* for (int row = 1; row <= 4; row++)
             {
                 for (int col = 1; col <= 4; col++)
                 {
                     Console.Write("*");
                 }
                 Console.WriteLine();
             }*/
            //
            // *****
            //** **
            //*** ***
            /* for (int row = 0; row <= 4; ++row)
             {
                 for (int col = 1; col <= row; ++col)
                 {
                     Console.Write("*");
                 }
                 if (row!=4-1)
                     {
                         Console.Write(" ");
                     }
                 else
                 {
                     Console.Write(" * ");
                 }
                 for (int col=0;col<=row;++col)
                 {
                     Console.Write(" * ");
                 }
                 Console.WriteLine();
             }*/
            /*
            int i, j, n;
            int[,] arr1 = new int[20, 20];
            int[,] arr2 = new int[20, 20];
            int[,] arr3 = new int[20, 20];
            // setting matrix row and columns size
            n = 3;
            Console.Write("Enter elements in the first matrix:\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("Enter elements in the second matrix:\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("\nFirst matrix is:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", arr1[i, j]);
            }
            Console.Write("\nSecond matrix is:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", arr2[i, j]);
            }
            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                    arr3[i, j] = arr1[i, j] + arr2[i, j];
            Console.Write("\nAdding two matrices: \n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", arr3[i, j]);
            }
            Console.Write("\n\n");*/

            //FUNCTIONS
            /*int c;
            Console.WriteLine("ENTER TWO NUMBERS: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine("Sum= " + c);


            static void Main(string[] args)


            Program p1 = new Program();
            p1.sum();
            Console.ReadLine();
            */







            int[,] samplearray1 = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            int[,] samplearray2 = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            int[,] samplearray3 = new int[2, 2] { { 1, 2 }, { 3, 4 } };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    samplearray3[i, j] = samplearray1[i, j] + samplearray2[i, j];

                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    samplearray3[i, j] = samplearray1[i, j] * samplearray2[i, j];

                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(samplearray3[i, j] + "\t");

                }
                Console.WriteLine();
            }
        } 
    }
}

