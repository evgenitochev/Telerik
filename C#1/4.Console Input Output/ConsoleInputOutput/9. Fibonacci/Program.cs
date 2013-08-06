//Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21...

using System;

class Fibonacci
{
    static void Main()
    {
        decimal num1 = 0;
        Console.WriteLine(num1);
        decimal num2 = 1M;
        Console.WriteLine(num2);
        decimal num3 = 0;
        for (decimal i = 0; i < 100; i++)
        {
            
            num3 = num1 + num2;
            Console.WriteLine(num3);

            num1 = num2;
            num2 = num3;
        }
    }
}
