//Write a program to convert binary numbers to their decimal representation.

using System;
using System.Collections.Generic;

class BinToDec
{
    static void Main(string[] args)
    {
        long number = long.Parse(Console.ReadLine());

        List<double> digits = new List<double>(); //declare array

        while (number > 0)
        {
            digits.Add(number % 10);
            number = number / 10;
        }

        for (int i = 0; i < digits.Count; i++)
        {
            digits[i] = digits[i] * Math.Pow(2, i); 
        }

        double sum = 0;

        for (int i = 0; i < digits.Count; i++)
        {
            sum += digits[i];
        }
        Console.WriteLine(sum);
           
    }
}
