//Write a method that checks if the element at given position in given array of 
//integers is bigger than its two neighbors (when such exist).

using System;

class neighbours
{
    static bool BiggerNeighbours(int[] array, int pos)
    {
        if (pos == 1)
        {
            return false;
        }
        else if (pos>=  array.Length)
        {
            return false;
        }
        else
        {
            if (array[pos-2] < array[pos-1] && array[pos-1] > array[pos])
            {
                return true;
            }
            else
	          {
                return false;
	          }
        }
    }

    static void Main()
    {
        int[] array = new int[] { 2, 3, 7, 3, 6, 7, 3, 7, 9, 4, 7, 0, 5, 3 };
        Console.WriteLine("enter position:");
        int position = int.Parse(Console.ReadLine());
        Console.WriteLine(BiggerNeighbours(array, position));
    }
}
