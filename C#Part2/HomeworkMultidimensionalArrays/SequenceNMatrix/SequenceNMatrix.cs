using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SequenceNMatrix
{
    static void Main()
    {
        Console.Write("Enter the width of the matrix N: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter the height of the matrix M: ");
        int m = int.Parse(Console.ReadLine());

        string[,] matrix = new string[m, n];
        
        //{ { "ha", "fifi", "ho", "hi" }, { "fo", "ha", "hi", "xx" }, { "xxx", "ho", "ha", "xx" } };

        //int n = 4;
        //int m = 3;

        for (int row = 0; row < m; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("Enter element [{0}, {1}] = ", row, col);
                matrix[row, col] = Console.ReadLine();
            }
        }
        int currentSeq = 1;
        int maxSeq = 1;
        string maxElement = "element";
        int direction = 0;

        //check horizontal seqences
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1) - 1; cols++)
            {
                if (matrix[rows, cols] == matrix[rows, cols + 1])
                {
                    currentSeq++;
                }
                else
                {
                    currentSeq = 1;
                }

                if (maxSeq < currentSeq)
                {
                    maxSeq = currentSeq;
                    maxElement = matrix[rows, cols];
                    direction = 1;
                }
            }
            currentSeq = 1;
        }

        //check vertical sequenes
        for (int cols = 0; cols < matrix.GetLength(1); cols++)
        {
            for (int rows = 0; rows < matrix.GetLength(0) - 1; rows++)
            {
                if (matrix[rows, cols] == matrix[rows + 1, cols])
                {
                    currentSeq++;
                }
                else
                {
                    currentSeq = 1;
                }

                if (maxSeq < currentSeq)
                {
                    maxSeq = currentSeq;
                    maxElement = matrix[rows, cols];
                    direction = 2;
                }
            }
            currentSeq = 1;
        }

        //check diagonals from top left to down right
        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                for (int rows = i, cols = j; rows < matrix.GetLength(0) - 1 && cols < matrix.GetLength(1) - 1; rows++, cols++)
                {
                    if (matrix[rows, cols] == matrix[rows + 1, cols + 1])
                    {
                        currentSeq++;
                    }
                    else
                    {
                        currentSeq = 1;
                    }

                    if (maxSeq < currentSeq)
                    {
                        maxSeq = currentSeq;
                        maxElement = matrix[rows, cols];
                        direction = 3;
                    }
                }
                currentSeq = 1;
            }
        }

        //check diagonals from top right to down left
        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = 1; j < matrix.GetLength(1); j++)
            {
                for (int rows = i, cols = j; rows < matrix.GetLength(0) - 1 && cols > 0; rows++, cols--)
                {
                    if (matrix[rows, cols] == matrix[rows + 1, cols - 1])
                    {
                        currentSeq++;
                    }
                    else
                    {
                        currentSeq = 1;
                    }

                    if (maxSeq < currentSeq)
                    {
                        maxSeq = currentSeq;
                        maxElement = matrix[rows, cols];
                        direction = 4;
                    }
                }
                currentSeq = 1;
            }
        }

        switch (direction)
        {
            case 1:
                Console.WriteLine("Element \"{0}\" repeats {1} times horizontally.", maxElement, maxSeq);
                break;
            case 2:
                Console.WriteLine("Element \"{0}\" repeats {1} times vertically.", maxElement, maxSeq);
                break;
            case 3:
                Console.WriteLine("Element \"{0}\" repeats {1} times diagonally from top left to bottom right.", maxElement, maxSeq);
                break;
            case 4:
                Console.WriteLine("Element \"{0}\" repeats {1} times diagonally from top right to bottom left.", maxElement, maxSeq);
                break;
            default:
                Console.WriteLine("No repetitions of elements.");
                break;
        }
    }
}
