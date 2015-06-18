namespace MatrixProblem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class TestMatrix
    {
        public static void Main()
        {
            Matrix<int> matrixTesting = new Matrix<int>(10, 10);
            Matrix<int> matrixTestingTwo = new Matrix<int>(10, 10);
            Console.WriteLine(matrixTesting.Cols);

            matrixTesting[0, 0] = 200;
            matrixTestingTwo[0, 0] = 3;
            Console.WriteLine(matrixTesting + matrixTestingTwo);

            Console.WriteLine(matrixTesting - matrixTestingTwo);
        }
    }
}
