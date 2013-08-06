//Write a method that returns the index of the first element in array 
//that is bigger than its neighbors, or -1, if there’s no such element.

using System;

class FirstElement
{
    static int FirstIndexElementBiggerThanNeighbours (int[] array)
    {
        int indexOfFirst = 0;

        for (int i = 1; i < array.Length-1; i++)
        {
            if (array[i] > array[i-1] && array[i] > array[i+1])
            {
                indexOfFirst = i;
            }
            else
            {
                indexOfFirst = -1;
            }
        }

        return indexOfFirst;

    }

    static void Main( )
    {
        int[] array = new int[] { 2, 3, 7, 3, 6, 7, 3, 7, 9, 4, 7, 0, 5, 3 };
        Console.WriteLine("first element that is bigger than his neighbours has index {0}",  FirstIndexElementBiggerThanNeighbours(array)); 
    }
}