//Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 



using System;

class SumOfnNumbers
{

    static void Main()
    {

        Console.Write("Please enter a number n:");
        int n = int.Parse(Console.ReadLine());

        int number = 0;
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number n{0}: ", i);
            number = int.Parse(Console.ReadLine());
            sum = sum + number;
        }

        Console.WriteLine("The sum of the numbers is {0}.", sum);
    }
}
