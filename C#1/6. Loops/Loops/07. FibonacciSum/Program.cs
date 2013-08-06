//Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci.

using System;
using System.Numerics;
using System.Collections.Generic;
 
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        BigInteger a = 0;
        BigInteger b = 1;
        BigInteger sum = 0;
        List<BigInteger> listOfNumbers = new List<BigInteger>();
        listOfNumbers.Add(a);
        listOfNumbers.Add(b);

        for (int i = 0; i < n; i++)
        {
            a = a + b;
            b = b + a;
            listOfNumbers.Add(a);
            listOfNumbers.Add(b);
        }
        for (int i = 0; i < n; i++)
        {
            sum += listOfNumbers[i];

        }
        Console.WriteLine("The sum of the first {0} members of the Fibonacci sequance is: {1}", n, sum);
    }
}


/*
using System;

class FibonacciSum
{
    static void Main()
    {
        Console.Write("Enter N: ");
        ulong n = ulong.Parse(Console.ReadLine());

        ulong firstN = 1;
        ulong secondN = 0;
        ulong thirtN = 0;
        ulong sum = 0;

        for (ulong i = 0; i <= n; i++)
        {
            thirtN = firstN + secondN;
            firstN = secondN;
            secondN = thirtN;
            Console.WriteLine(i + ": " + thirtN);
            sum += thirtN;
        }
        Console.WriteLine("The Sum is: {0}", sum);
    }
}

*/