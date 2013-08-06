//Write a program that reads two arrays from the console and compares them element by element.

using System;
class CompareArayys
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        int[] arr1 = new int[n];
        int[] arr2 = new int[m];

        bool equal = true;

        if (m == n)
        {
            for (int i = 0; i < n; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < m; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    equal = false; break;
                }
            }
        }
        else
        {
            equal = false;
        }
        Console.WriteLine("Are the arrays equal? {0}", equal);
    }
}