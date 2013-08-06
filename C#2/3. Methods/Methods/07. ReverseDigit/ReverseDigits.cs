//Write a method that reverses the digits of given decimal number. Example: 256  652

using System;

class ReverseDigits
{
    static int ReversedNumber(int num)
    {
        int result = 0;
        while (num > 0)
        {
            result = result * 10 + num % 10;
            num /= 10; 
        }
        return result;
    }
    static void Main()
    {
        Console.WriteLine("enter number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(ReversedNumber(number));
    }
}
