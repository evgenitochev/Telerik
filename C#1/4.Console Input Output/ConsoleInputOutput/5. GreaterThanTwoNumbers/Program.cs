//Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.


using System;

class GreaterThanTwoNumbers
{
    static void Main()
    {
        Console.Write("First number:");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Second number:");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("The greater of the two entered numbers is {0}", Math.Max(num1, num2));
    }
}
