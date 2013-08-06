/*We are given a matrix of strings of size N x M. 
 * Sequences in the matrix we define as sets of several neighbor elements 
 * located on the same line, column or diagonal. Write a program that
 * finds the longest sequence of equal strings in the matrix. 
*/

using System;

class LongestSequenceOfEqualStrings
{
    static void Main()
    {
        Console.WriteLine("Insert number of rows of array N");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Insert number of columns of array M");
        int m = int.Parse(Console.ReadLine());
        string[,] DoubleArray = new string[n, m];
        Console.WriteLine("Insert first row elements");
        for (int i = 0; i < n; i++)
        {
            if (i != 0)
            {
                Console.WriteLine("Insert next row elements");
            }
            for (int j = 0; j < m; j++)
            {
                DoubleArray[i, j] = Console.ReadLine();
            }
        }
        /*string[,] DoubleArray = {
                              {"ha", "fifi", "ho", "Sa"},
                              {"fo", "fha", "hi", "Sa"},
                              {"ha", "ha", "ha", "ha"} };*/

        int maxcount = 0;
        string maxstring = "";
        for (int i = 0; i < DoubleArray.GetLength(0); i++)
        {
            for (int j = 0; j < DoubleArray.GetLength(1); j++)
            {
                int countx = 0;
                int county = 0;

                while (i + countx < DoubleArray.GetLength(0))
                {
                    if (DoubleArray[i, j] == DoubleArray[i + countx, j])
                    {
                        countx++;
                    }
                    else
                        break;
                }
                if (countx + 1 > maxcount)
                {
                    maxcount = countx;
                    maxstring = DoubleArray[i, j];
                }
                while (j + county < DoubleArray.GetLength(1))
                {
                    if (DoubleArray[i, j] == DoubleArray[i, j + county])
                    {
                        county++;
                    }
                    else
                        break;
                }
                if (county + 1 > maxcount)
                {
                    maxcount = county;
                    maxstring = DoubleArray[i, j];
                }
                countx = 0;
                while (i + countx < DoubleArray.GetLength(0) && j + countx < DoubleArray.GetLength(1))
                {
                    if (DoubleArray[i, j] == DoubleArray[i + countx, j + countx])
                    {
                        countx++;
                    }
                    else
                        break;
                }
                if (countx + 1 > maxcount)
                {
                    maxcount = countx;
                    maxstring = DoubleArray[i, j];
                }
            }
        }
        Console.Write("-> {0}", maxstring);
        for (int i = 1; i < maxcount; i++)
        {
            Console.Write(",{0}", maxstring);
        }
        Console.WriteLine();

    }
}