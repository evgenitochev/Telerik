﻿// In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:
// (2*n)! / (n + 1)! * n!
// Write a program to calculate the Nth Catalan number by given N.

using System;

class Program
{
    static void Main()
    {
        ulong NcataNum = ulong.Parse(Console.ReadLine());

        ulong factN = 1;
        ulong factNPlus1 = 1;

        for (ulong i = 1; i <= NcataNum + 1; i++)
        {
            if (i <= NcataNum)
            {
                factN *= i;
            }
            factNPlus1 *= i;
        }

        ulong doubleFactN = 1;

        for (ulong i = 1; i <= NcataNum * 2; i++)
        {
            doubleFactN *= i;
        }

        NcataNum = doubleFactN / (factNPlus1 * factN);

        Console.WriteLine(NcataNum);
    }
}