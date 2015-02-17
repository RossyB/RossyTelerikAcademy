using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MatrixClass
{
    static void Main()
    {
        Matrix matrix1 = new Matrix(2, 2);
        matrix1[0, 0] = 1;
        matrix1[0, 1] = 1;
        matrix1[1, 0] = 1;
        matrix1[1, 1] = 1;

        Matrix matrix2 = new Matrix(2, 2);
        matrix1[0, 0] = 2;
        matrix1[0, 1] = 5;
        matrix1[1, 0] = 1;
        matrix1[1, 1] = 9;

        Matrix sum = matrix1 + matrix2;
        PrintMatrix(sum);

    }

    static void PrintMatrix(Matrix matrix)
    {
        for (int row = 0; row < matrix.Rows; row++)
        {
            for (int col = 0; col < matrix.Columns; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}

class Matrix
{
    private int[,] matrix;

    public Matrix(int rows, int cols)
    {
        this.matrix = new int[rows, cols];
    }

    public int Rows
    {
        get
        {
            return this.matrix.GetLength(0);
        }
    }

    public int Columns
    {
        get
        {
            return this.matrix.GetLength(1);
        }
    }

    public static Matrix operator +(Matrix first, Matrix second)
    {
        Matrix result = new Matrix(first.Rows, first.Columns);
        for (int row = 0; row < first.Rows; row++)
        {
            for (int col = 0; col < first.Columns; col++)
            {
                result[row, col] = first[row, col] + second[row, col];
            }
        }
        return result;
    }

    public int this[int row, int col]
    {
        get
        {
            return this.matrix[row, col];
        }

        set
        {
            this.matrix[row, col] = value;
        }
    }
}