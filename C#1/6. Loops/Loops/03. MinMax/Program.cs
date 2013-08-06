//Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.

using System;

class Program
{
    static void Main()
    {

        Console.Write("Enter the numbers count: ");
        int n = int.Parse(Console.ReadLine());
        int[] numberArray = new int[n];

        for (int i = 0; i < n; i++)
        {
            numberArray[i] = int.Parse(Console.ReadLine());
        }


        int min = numberArray[0];
        int max = numberArray[0];

        for (int i = 0; i < numberArray.Length; i++)
        {
            if (max < numberArray[i])
            {
                max = numberArray[i];
            }
            if (min > numberArray[i])
            {
                min = numberArray[i];
            }
        }
        Console.WriteLine("Minimum is {0}", min);
        Console.WriteLine("Maximum is {0}", max); 
    }
}
