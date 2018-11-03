using System;

namespace MaxSumRectangleInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum sum rectangle in a 2D Matrix!");
            Console.WriteLine("-------------------------------------");
            try
            {
                Console.WriteLine("Enter the number of rows of the matrix");
                int rows = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number of columns in the matrix");
                int columns = int.Parse(Console.ReadLine());
                int[,] inputMatrix = new int[rows, columns];
                inputMatrix = GetInput(rows, columns);
                MatrixProcessor matrixProcessor = new MatrixProcessor(inputMatrix);
                matrixProcessor.GetMaximumSumRectangleIn2DMatrix();
                Console.ReadKey();
            }
            catch (Exception exception) {
                Console.WriteLine("The thrown exception is"+exception.Message);
            }
        }

        private static int[,] GetInput(int noOfRows, int noOfColumns) {
            int[,] matrix = new int[noOfRows, noOfColumns];
            for (int i = 0; i < noOfRows; i++)
            {
                Console.WriteLine("Enter the elements of the row" + i);
                for (int j = 0; j < noOfColumns; j++)
                {
                    Console.WriteLine("Enter the element:");
                    try
                    {
                        matrix[i, j] = int.Parse(Console.ReadLine());
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine("The thrown exception is" + exception.Message);
                    }
                }
            }
            return matrix;
        }
    }
}
