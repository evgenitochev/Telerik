//Write a program to calculate n! for each n in the range [1..100]. 
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 


using System;
using System.Numerics;

class NFactorial
{
    static BigInteger Factorial(BigInteger number)
    {
        BigInteger multiplication = 1;

        for (int i = 1; i <= number; i++)
        {
            multiplication *= i;
        }
        return multiplication;
    }

    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine(Factorial(i));
        }
    }
}
