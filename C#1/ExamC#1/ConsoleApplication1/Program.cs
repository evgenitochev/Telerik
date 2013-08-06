using System;

class SimpleSudokuLikeMatrix
{
    static void Main()
    {
        Console.Write("A(0, 20) = ");
        int n = int.Parse(Console.ReadLine());


        for (int rows = 1; rows <= n; rows++)
        {
            for (int cols = rows; cols <= n + rows - 1; cols++)
            {

                Console.Write(cols + " ");
            }
            Console.WriteLine();
        }

    }
}



