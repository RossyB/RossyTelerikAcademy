//Write a program that fills and prints a matrix of size (n, n) as shown below:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class FillTheMatrix
{
    static void Main()
    {
        Console.Write("Enter size of the matrix n: ");
        int n = int.Parse(Console.ReadLine());

        //Variant A
        Console.WriteLine("Variant A:");
        int[,] matrixA = new int[n, n];
        int index = 1;

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                matrixA[col, row] = index;
                index++;
            }
        }

        PrintMatrix(matrixA);

        //Variant B
        Console.WriteLine("Variant B:");
        int[,] matrixB = new int[n, n];
        index = 1;

        for (int row = 0; row < n; row++)
        {
            if (row % 2 == 0)
            {
                for (int col = 0; col < n; col++)
                {
                    matrixB[col, row] = index;
                    index++;
                }
            }
            else
            {
                for (int col = n-1; col >= 0; col--)
                {
                    matrixB[col, row] = index;
                    index++;
                }
            }
        }

        PrintMatrix(matrixB);

        //Variant C
        Console.WriteLine("Variant C:");
        int[,] matrixC = new int[n, n];
        index = 1;

        for (int diag = 0; diag < (n * 2) - 1; diag++)
        {
            int row = n - 1 - diag;
            if (row < 0)
            {
                row = 0; 
            }
            int col = 0;
            if (diag >= n)
            {
                col = diag - n + 1;
            }

            while ((row < n) && (col < n))
            {
                matrixC[row, col] = index;
                index++;
                row++;
                col++;
            }
        }
        PrintMatrix(matrixC);
        Console.WriteLine("Variant D:");
        //Variant D

        int[,] matrixD = new int[n, n];
        index = 1;

        string direction = "down";

        int currentRow = 0;
        int currentCol = 0;

        for (int i = 1; i <= n * n; i++)
        {
           
           if (direction == "down" && (currentRow >= n || matrixD[currentRow, currentCol] != 0))
            {
                currentCol++;
                currentRow--;
                direction = "right";
            }
           else if (direction == "right" && (currentCol >= n || matrixD[currentRow, currentCol]!= 0))
           {
               currentCol--;
               currentRow--;
               direction = "up";
           }

           else if (direction == "up" && (currentRow < 0 || matrixD[currentRow, currentCol] != 0))
           {
               currentCol--;
               currentRow++;
               direction = "left";
           }
           else if (direction == "left" && (currentCol < 0 || matrixD[currentRow, currentCol] != 0))
           {
               currentCol++;
               currentRow++;
               direction = "down";
           }
            
            matrixD[currentRow, currentCol] = i;

           
            if (direction == "down")
            {
                currentRow++;
            }
            else if (direction == "right")
	        {
		        currentCol++;
	        }
            else if (direction == "up")
            {
                currentRow--;
            }
            else if (direction == "left")
            {
                currentCol--;
            }
            
        }

        PrintMatrix(matrixD);
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, 3}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
