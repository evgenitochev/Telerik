/*Write a program that finds in given array of integers a sequence of given sum S (if present).
 * Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}	
*/


using System;

class SequenceS
{
    static void Main(string[] args)
    {
        Console.Write("Enter sum: ");
        int sum = int.Parse(Console.ReadLine());
        int[] arr = new int[] { 4, 3, 1, 4, 2, 5, 8 };
        int S = 0;
        int startIndex = 0;
        int endIndex = 0;


        for (int i = 0; i < arr.Length; i++)
        {
            startIndex = i;
            S = arr[i];
            for (int j = i + 1; j < arr.Length; j++)
            {
                endIndex = j;
                S = S + arr[j];
                if (S == sum)
                {
                    Console.WriteLine("Sequence of given sum is found.");
                    Console.Write("{ ");
                    for (int print = startIndex; print <= endIndex; print++)
                    {

                        Console.Write(arr[print] + ", ");

                    }
                }
            }
        }
        Console.WriteLine("}");
    }
}