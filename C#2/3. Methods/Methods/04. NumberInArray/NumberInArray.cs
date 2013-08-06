//Write a method that counts how many times given number appears in given array. 
//Write a test program to check if the method is working correctly.


using System;

class NumberInArray
{
    static int NumberOfTimes(int[] array, int num)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == num)
            {
                count++;
            }
        }
        return count;
    }


    static void Main()
    {
        Console.WriteLine("Enter number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("number of elements:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("array elements:");

        int[] array = new int[n];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Your number {0} exsits {1} times", number, NumberOfTimes(array, number));
       
    }
}