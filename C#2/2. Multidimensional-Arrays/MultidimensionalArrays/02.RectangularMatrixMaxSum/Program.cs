//Write a program that reads a rectangular matrix of size N x M 
//and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;

class RectangularMatrixMaxSum
{
    static void Main()
    {
        //Console.Write("Please enter the number of rows of the matrix bigger than 3: N=");
        //int N = int.Parse(Console.ReadLine());
        //Console.Write("Please enter the number of columns of the matrix bigger than 3: M=");
        //int M = int.Parse(Console.ReadLine());

        //int[,] matrixNM = new int[N, M];
        int[,] matrixNM =
                {
                        {0, 9, 4, 0, 9, 0},
                        {0, 1, 3, 3, 2, 1},
                        {1, 3, 0, 8, 5, 6},
                        {9, 6, 7, 0, 1, 99},
                };
        int currentSum = int.MinValue;
        int maxSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;

        //fills the matrix

        //for (int rows = 0; rows < matrixNM.GetLength(0); rows++)
        //{
        //    for (int cols = 0; cols < matrixNM.GetLength(1); cols++)
        //    {
        //        Console.Write("Please enter cell [{0}], [{1}]=", rows,cols);
        //        matrixNM[rows, cols] = int.Parse(Console.ReadLine());              
        //    }
        //}

        //prints the matrix

        for (int rows = 0; rows < matrixNM.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrixNM.GetLength(1); cols++)
            {
                if (cols == matrixNM.GetLength(1) - 1) //if we have reached the end of the row, to go to the next line
                {
                    Console.WriteLine("{0,3} ", matrixNM[rows, cols]);
                }
                else
                {
                    Console.Write("{0,3} ", matrixNM[rows, cols]);
                }
            }
        }

        //checks the bestSum

        for (int rows = 0; rows <= matrixNM.GetLength(0) - 3; rows++)
        {
            for (int cols = 0; cols <= matrixNM.GetLength(1) - 3; cols++)
            {

                currentSum = matrixNM[rows, cols] + matrixNM[rows, cols + 1] + matrixNM[rows, cols + 2] +
                           matrixNM[rows + 1, cols] + matrixNM[rows + 1, cols + 1] + matrixNM[rows + 1, cols + 2] +
                           matrixNM[rows + 2, cols] + matrixNM[rows + 2, cols + 1] + matrixNM[rows + 2, cols + 2];

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    bestCol = cols;
                    bestRow = rows;
                }
                currentSum = int.MinValue;
            }

        }

        Console.WriteLine("The maximal sum of the elements {0}", maxSum);
        Console.WriteLine("The elements are:");
        Console.WriteLine("{0,4}, {1,4}, {2,4}", matrixNM[bestRow, bestCol], matrixNM[bestRow, bestCol + 1], matrixNM[bestRow, bestCol + 2]);
        Console.WriteLine("{0,4}, {1,4}, {2,4}", matrixNM[bestRow + 1, bestCol], matrixNM[bestRow + 1, bestCol + 1], matrixNM[bestRow + 1, bestCol + 2]);
        Console.WriteLine("{0,4}, {1,4}, {2,4}", matrixNM[bestRow + 2, bestCol], matrixNM[bestRow + 2, bestCol + 1], matrixNM[bestRow + 2, bestCol + 2]);
    }
}

