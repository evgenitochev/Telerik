
//Write a program that finds the maximal sequence of equal elements in an array.


using System;

class MaximimumSequenceOfEqualElements
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        int n = int.Parse(Console.ReadLine());
        int[] table = new int[n];

        int len = 1;
        int bestlen = 0;
        int elem = 0;


        for (int i = 0; i < table.Length - 1; i++)
        {
            
            table[i] = int.Parse(Console.ReadLine());


            if (table[i] == table[i + 1])
            {
                len++;
            }
            else
            {
                if (len > bestlen)
                {
                    bestlen = len;
                    elem = table[i];
                }

                len = 1;
            }
        }
        if (len > bestlen)
        {
            bestlen = len;
            elem = table[table.Length - 1];
        }

        Console.WriteLine("The longest sequence is {0} elements of type \"{1}\" .", bestlen, elem);
        //Console.WriteLine(bestlen);
        //   Console.WriteLine(elem);
    }
}