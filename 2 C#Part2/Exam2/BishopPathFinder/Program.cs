using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        string[] dimensionsOfMatrix = Console.ReadLine().Split(' ');
        int rowMatrix = int.Parse(dimensionsOfMatrix[0]);
        int colMatrix = int.Parse(dimensionsOfMatrix[1]);

        int[,] matrix = new int[rowMatrix, colMatrix];

        int index = 0;
        for (int diag = 0; diag < (rowMatrix * 2); diag++)
        {
            
            int row = rowMatrix - 1 - diag;
            if (row < 0)
            {
                row = 0;
            }
            int col = 0;

            if (diag >= rowMatrix)
            {
                col = diag - rowMatrix + 1;
            }

            while ((row < rowMatrix) && (col < colMatrix))
            {
                matrix[row, col] = index;
                row++;
                col++;
            }
            index += 3;
        }

        int numberOfMoves = int.Parse(Console.ReadLine());
        string[] moves = new string[numberOfMoves];

        for (int i = 0; i < moves.Length; i++)
        {
            moves[i] = Console.ReadLine();
        }

        int sumMoves = 0;
        int indexMoves = 0;

        int moveRow = rowMatrix - 1;
        int moveCol = 0;
      
        for (int i = 0; i < moves.Length; i++)
        {
            string[] currentMove = moves[i].Split(' ');

            if (currentMove[0] == "UR" || currentMove[0] == "RU")
            {
                int number = int.Parse(currentMove[1]);

                while (true)
                {
                    if (number > 0 && moveRow >= 0 && moveCol < colMatrix)
                    {
                        sumMoves += matrix[moveRow, moveCol];
                        matrix[moveRow, moveCol] = 0;
                    }
                    else
                    {
                        moveRow++;
                        moveCol--;
                        break;
                    }
                    moveRow--;
                    moveCol++;
                    number--;
                }
            }

            if (currentMove[0] == "LU" || currentMove[0] == "UL")
            {
                int number = int.Parse(currentMove[1]);

                while (true)
                {
                    if (number > 0 && moveRow >= 0 && moveCol >= 0)
                    {
                        sumMoves += matrix[moveRow, moveCol];
                        matrix[moveRow, moveCol] = 0;
                        
                    }
                    else
                    {
                        moveRow++;
                        moveCol++;
                        break;
                    }
                    moveRow--;
                    moveCol--;
                    number--;

                }
            }
            if (currentMove[0] == "DL" || currentMove[0] == "LD")
            {
                int number = int.Parse(currentMove[1]);

                while (true)
                {
                    if (number > 0 && moveRow < rowMatrix && moveCol >= 0)
                    {
                        sumMoves += matrix[moveRow, moveCol];
                        matrix[moveRow, moveCol] = 0; 
                    }
                    else
                    {
                        moveRow--;
                        moveCol++;
                        break;
                    }
                    moveRow++;
                    moveCol--;
                    number--;

                }
            }
            if (currentMove[0] == "DR" || currentMove[0] == "RD")
            {
                int number = int.Parse(currentMove[1]);

                while (true)
                {
                    if (number > 0 && moveRow < rowMatrix && moveCol < colMatrix)
                    {
                        sumMoves += matrix[moveRow, moveCol];
                        matrix[moveRow, moveCol] = 0;
                        
                    }
                    else
                    {
                        moveRow--;
                        moveCol--;
                        break;
                    }
                    moveRow++;
                    moveCol++;
                    number--;

                }
            }
        }

        Console.WriteLine(sumMoves);
        
    }
}
