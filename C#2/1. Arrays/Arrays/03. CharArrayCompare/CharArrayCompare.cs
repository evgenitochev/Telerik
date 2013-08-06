/* Write a program that compares two char arrays lexicographically (letter by letter). */

using System;

class CharArraysCompare
{
    static void Main()
    {
        Console.WriteLine("Please enter length for the first array: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter length for the second array: ");
        int p = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the first {0} characters for the first string", n);
        char[] array1 = new char[n];

        Console.WriteLine("Please enter the first {0} characters for the second string", p);
        char[] array2 = new char[p];

        bool same = true;

        for (int i = 0; i < array1.Length; i++)
        {
            array1[i] = char.Parse(Console.ReadLine());
        }

        for (int i = 0; i < array2.Length; i++)
        {
            array2[i] = char.Parse(Console.ReadLine());
        }

        if (array1.Length > array2.Length)
        {
            Console.WriteLine("lexicographically the second string is shorter");
        }
        else
        {
            if (array1.Length < array2.Length)
            {
                Console.WriteLine("lexicographically the first string is shorter");
            }
            else
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i] != array2[i])
                    {
                        same = false;
                    }

                }
                if (same == true)
                {
                    Console.WriteLine("The two arrays are  lexicographically the same!");
                }
            }
        }



    }
}