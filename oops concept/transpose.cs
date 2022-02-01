using System;
using System.Collections.Generic;
using System.Text;

namespace oops_concept
{
    class transpose
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;

            int row = 2;
            int col = 2;

            int[,] Matrix = new int[row, col];

            Console.Write("Enter the elements of matrix: ");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nMatrix: ");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.Write(Matrix[i, j] + "\t");

                }
                Console.WriteLine();
            }

            Console.WriteLine("Transpose of matrix : ");
            for (i = 0; i < col; i++)
            {
                for (j = 0; j < row; j++)
                {
                    Console.Write(Matrix[j, i] + "\t");

                }
                Console.WriteLine();
            }
        }
    }
}

