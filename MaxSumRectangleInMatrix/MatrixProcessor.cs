using System;
using System.Collections.Generic;
using System.Text;

namespace MaxSumRectangleInMatrix
{
    class MatrixProcessor
    {
        private int[,] matrix { get; set; }

        public MatrixProcessor() { }

        public MatrixProcessor(int[,] matrix) {
            this.matrix = matrix;
        }

        public void GetMaximumSumRectangleIn2DMatrix() {

            int[] result = _GetMaximumSumRectangleIn2DMatrix();

            Console.WriteLine("-------------------------------------------------------");

            Console.WriteLine("The maximum rectangle lies between (" + result[1] + "," + result[2] + ")" +
                "and ("+result[3] + "," + result[4]+")");

            Console.WriteLine("The maximum sum yielded by this rectangle is "+ result[0]);

        }


        private int[] _GetMaximumSumRectangleIn2DMatrix() {
            int[] result = new int[3];
            int maxSum = int.MinValue;

            int leftBoundary = 0;
            int rightBoundary = 0;
            int top = 0;
            int bottom = 0;

            for (int i = 0; i < this.matrix.GetLength(0); i++) {
                //Temporary array to hold up sum of entries from left and right boundary entries under consideration
                int[] temporaryArray = new int[this.matrix.GetLength(0)];
                for (int j = i; j < this.matrix.GetLength(1); j++) {                    
                    for (int k = 0; k < this.matrix.GetLength(0); k++) {
                        temporaryArray[k] += this.matrix[k,j];
                    }
                    
                    //Kadane's algorithm to get the largest sum contiguous array
                    result = KadaneAlgorithm.GetLargestContiguousArray(temporaryArray);

                    if (result[0] > maxSum) {
                        maxSum = result[0];
                        leftBoundary = i;
                        rightBoundary = j;
                        top = result[1];
                        bottom = result[2];
                    }
                }
            }

            return new int[] { maxSum, leftBoundary, top, rightBoundary, bottom};
        }
    }
}
