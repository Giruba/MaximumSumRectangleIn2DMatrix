using System;
using System.Collections.Generic;
using System.Text;

namespace MaxSumRectangleInMatrix
{
    sealed class KadaneAlgorithm
    {
        public static int[] GetLargestContiguousArray(int[] array) {
            int currentSum = 0;
            int maxSum = int.MinValue;
            int start = 0;
            int end = -1;

            for (int i = 0; i < array.GetLength(0); i++) {
                currentSum += array[i];
                if (currentSum < 0) {
                    currentSum = 0;
                    start = i + 1;
                }
                if (currentSum > maxSum) {
                    maxSum = currentSum;
                    end = i;
                }
            }
            return new int[] { maxSum, start, end};
        }
    }
}
