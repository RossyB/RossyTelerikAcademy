//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MaximalSum
{
    static void Main()
    {
       
        Console.WriteLine("Enter the size of matrix:");
        Console.Write("Enter size n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter size m: ");
        int m = int.Parse(Console.ReadLine());
        /*
        int[,] matrix = {
                    {7, 1, 3, 3, 2, 1},
                    {1, 3, 9, 8, 5, 6},
                    {4, 6, 7, 9, 1, 0},
                    {1, 3, 9, 8, 5, 6},
                    {7, 1, 3, 3, 2, 1}
                        };
        */
        int[,] matrix = new int[n, m];

        //reading matrix
        
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write("Enter element [{0}, {1}] = ", row, col);
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }

        //finding max platform

        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;

        for (int row = 0; row < n - 2; row++)
        {
            for (int col = 0; col < m - 2; col++)
            {
                int currentSum = 0;
                for (int i = row; i < row + 3; i++)
                {
                    for (int j = col; j < col + 3; j++)
                    {
                        currentSum += matrix[i, j];
                    }
                }

                if (currentSum > bestSum)
                {
                    bestSum = currentSum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }


        Console.WriteLine("The best sum is: {0}", bestSum);

        //ptint the best platform
        Console.WriteLine("The best platform is:");
        for (int row = bestRow; row < bestRow + 3; row++)

        {
            for (int col = bestCol; col < bestCol + 3; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}
