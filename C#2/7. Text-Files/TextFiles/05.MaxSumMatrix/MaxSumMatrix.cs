/* Write a program that reads a text file containing a square matrix of numbers and finds in the 
 * matrix an area of size 2 x 2 with a maximal sum of its elements. The first line in the 
 * input file contains the size of matrix N. Each of the next N lines contain N numbers 
 * separated by space. The output should be a single number in a separate text file. Example:
4
2 3 3 4
0 2 3 4			17
3 7 1 2
4 3 3 2
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class MaxSumMatrix
{
    static int[,] myArray;
    static void Main(string[] args)
    {
        string firstFileName = "../../mytemp01.txt";//the dir of the .cs file
        string newFileName = "../../ConcatenatedFile.txt"; //the dir of the .cs file

        Archive(newFileName);

        ReadFile(firstFileName);

        Print(myArray);

        int totalSum = CheckMaxSum(myArray, myArray.GetLength(0), myArray.GetLength(1));
        WriteToFile(totalSum, newFileName);

        PrintFile(newFileName);


    }

    private static void WriteToFile(int totalSum, string newFileName)
    {
        using (StreamWriter destinationFile = new StreamWriter(newFileName))
        {
            destinationFile.WriteLine(totalSum);
        }
    }



    private static void ReadFile(string firstFileName)
    {
        using (StreamReader sourceFile = new StreamReader(firstFileName))
        {
            string line = sourceFile.ReadLine();
            int size = int.Parse(line);
            myArray = new int[size, size];
            int row = 0;
            line = sourceFile.ReadLine();
            while (line != null)
            {
                FillRow(line, row);
                row++;
                line = sourceFile.ReadLine();
            }
        }
    }

    private static void FillRow(string line, int row)
    {
        char[] charSeparators = { ' ' };
        string[] sequence = line.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
        int length = sequence.Length;

        for (int i = 0; i < length; i++)
        {
            myArray[row, i] = int.Parse(sequence[i]);
        }
    }

    private static int CheckMaxSum(int[,] matrix, int rowsNumberN, int colsNumberK)
    {
        int bestSum = int.MinValue;
        int totalSum;
        int bestCellRow = 0;
        int bestCellCol = 0;

        for (int rows = 0; rows < rowsNumberN - 1; rows++)
        {
            for (int cols = 0; cols < colsNumberK - 1; cols++)
            {
                totalSum = SumMatrix(matrix, rows, cols);

                if (totalSum >= bestSum)
                {
                    bestSum = totalSum;
                    bestCellRow = rows;
                    bestCellCol = cols;
                }
            }
        }

        Console.WriteLine("The maximum sum is: {0}", bestSum);
        PrintSmallMatrix(matrix, bestCellRow, bestCellCol);

        return bestSum;
    }

    private static void PrintSmallMatrix(int[,] matrix, int rows, int cols)
    {
        Console.WriteLine("The coordinate of the first cell is ({0},{1})", rows + 1, cols + 1);
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write("{0,3}", matrix[rows + i, cols + j]);
            }
            Console.WriteLine();
        }
    }

    private static int SumMatrix(int[,] matrix, int rows, int cols)
    {
        int totalSum = 0;
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                totalSum += matrix[rows + i, cols + j];
            }
        }

        return totalSum;
    }

    private static void Print(int[,] matrix)
    {
        int lengthRows = matrix.GetLength(0);
        int lengthCols = matrix.GetLength(1);

        for (int i = 0; i < lengthRows; i++)
        {
            for (int j = 0; j < lengthCols; j++)
            {
                Console.Write("{0,3} ", matrix[i, j]);
            }
            Console.WriteLine();
        }

    }

    private static void PrintFile(string newFileName)
    {
        Console.Write("Do You want to read the concatenated file <y/n>: ");
        char answer = (char)Console.Read();

        if (answer == 'y')
        {
            using (StreamReader concatenated = new StreamReader(newFileName))
            {
                string line = concatenated.ReadLine();

                while (line != null)
                {
                    Console.WriteLine(line);
                    line = concatenated.ReadLine();
                }
            }
        }
        else
        {
            Console.WriteLine("GoodBye");
        }
    }

    private static void Archive(string newFileName)
    {
        if (File.Exists(newFileName)) //if the file already exists we make an archive
        {
            string archiveName = newFileName.Remove(0, 6);
            string archive = "../../archive" + "-" + DateTime.Now.Hour + "-" + DateTime.Now.Day + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second + archiveName;
            File.Copy(newFileName, archive);
            File.Delete(newFileName);
        }

        File.Create(newFileName).Close();
    }

}