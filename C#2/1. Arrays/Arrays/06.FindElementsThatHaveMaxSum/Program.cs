//Write a program that reads two integer numbers N and K and an array of N elements from the console. 
//Find in the array those K elements that have maximal sum.


using System;

class FindElementsThatHaveMaxSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        int sum = 0;

        if (k > n)
        {
            Console.WriteLine("N must be bigger than K!");
            return;
        }

        for (int index = 0; index < n; index++)
        {
            array[index] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);

        for (int index = n - 1; index >= n - k; index--)
        {
            sum += array[index];
        }

        Console.WriteLine(sum);
    }
}