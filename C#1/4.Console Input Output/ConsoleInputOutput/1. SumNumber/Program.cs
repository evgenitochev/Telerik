//Write a program that reads 3 integer numbers from the console and prints their sum.



using System;

class SumNumber
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        int num3 = int.Parse(Console.ReadLine());

        Console.WriteLine("The sum of {0},{1},{2} is {3} ", num1, num2, num3, num1 + num2 + num3);
    }
}    
