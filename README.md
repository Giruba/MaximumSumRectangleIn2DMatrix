# MaximumSumRectangleIn2DMatrix
C# program for finding the maximum sum rectangle in a 2D matrix

Consider the matrix (3*3) 

1 5 3
8 -1 5
6 5 -2

The maximum sum rectangle that can be obtained from this matrix is (0,0) (2,2) for a sum of 30 [1+5+3+8+-1+5+6+5+-2]

Solution
---------
Let us consider the first rectangle (0,0) to (2,0) 1,8,6 -> Max Sum is 15 (1+8+6)
If second rectangle is considered (0,0) to (2,1) we get [1+5, 8+-1, 6+5] -> Max Sum is 24 (6+7+11)
If thirs rectangle is considered (0,0) to (2,2) we get 30 and hence the maxximum sum rectangle lies from (0,0) to (2,2)

Kadane algorithm used for finding maximum sum contiguous array is used for finding the maximum sum among these rectangles.


Basic Steps of the Program
--------------------------
1. Fix left corner of the matrix [0 to no of Rows]
2. Fix right corner of the matrix [left Corner to no of Rows]
3. Get the rectangle sum between these two corners for entries in the column using Kadane's algorithm
4. Check if the sum of the rectangle is greater than the maximum sum rectangle obtained so far.
5. Terminate when we exhaust left and right corners


Illustration of Basic steps
---------------------------
1. Left Corner -> 0th Column, Right Corner -> 0th Column  Get the first rectangle between (0,0) and (2,0)  [Kadane algorithm]
                              Right Corner -> 1st Column  Get the sum of the first two rectangles between (0,0) and (2,1) [Kadane algorithm]
                              Right Corner -> 2nd Column  Get the sum of the first three rectangles between (0,0) and (2,2) [Kadane algo]
                              
                              Let the max of these be Max, Store left Boundary, Right Boundary, start of Max rectangle index, End of
                              max sum rectangle index
                              
2. Left Corner -> 1st Column, Right Corner -> 1st Column  Get Max Sum Rectangle using Kadane algo (0,1) to (2,1)
                              Right Corner -> 2nd Column  Get Max Sum Rectangle using Kadane algo (0,1) to (2,2)
                              
                              Compare and store the max with the required indices (left, right, top, bottom)
                              [Top and Bottom come from the start and end indices of Kadane algorithm]
                              
3. Left Corner -> 2nd Column, Right Column 2nd Colum - Get Max Sum Rectangle using Kadane (0,2) to (2,2)
                        
                               Compare and Get the max with indices                               
                                                             
                     
PRINT the MAX SUM RECTANGLE in the 2D matrix printing the Max sum and the indices of the rectangle.
          
  
