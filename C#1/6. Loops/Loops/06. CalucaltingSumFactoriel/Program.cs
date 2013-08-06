//Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN


using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());

        double sum = 1;
        double nFactoriel = 1;
        double poweredX;

        for (int i = 1; i <= n; i++)
        {
            poweredX = (int)Math.Pow(x, i);
            nFactoriel *= i;
            sum += nFactoriel / poweredX;
        }
        Console.WriteLine(sum);
    }
}
