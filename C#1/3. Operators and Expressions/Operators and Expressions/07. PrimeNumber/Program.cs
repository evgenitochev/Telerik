//Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.


using System;

class PrimeNumber
{
    static void Main()
    {
        string str = Console.ReadLine();
        int number = int.Parse(str);
        int maxResultToChek = 10;

        bool isPrime = ((number % 2 > 0) && (number % 3 > 0) && (number % 5 > 0)
                                         && (number % 7 > 0)) || ((number == 2)
                                         || (number == 3) || (number == 5)
                                         || (number == 7));

        Console.WriteLine(isPrime);

    }
}