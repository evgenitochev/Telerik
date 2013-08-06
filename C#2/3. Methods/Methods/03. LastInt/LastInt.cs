//Write a method that returns the last digit of given integer as an English word. 
//Examples: 512  "two", 1024  "four", 12309  "nine".


using System;

class LastInt
{
    static string LastDigit(int number)
    {
        int remainder = number % 10;
        string digitWord = "";
        switch (remainder)
        {
            case 0: digitWord = "Zero";
                break;
            case 1: digitWord = "One";
                break;
            case 2: digitWord = "Two";
                break;
            case 3: digitWord = "Three";
                break;
            case 4: digitWord = "Four";
                break;
            case 5: digitWord = "Five";
                break;
            case 6: digitWord = "Six";
                break;
            case 7: digitWord = "Seven";
                break;
            case 8: digitWord = "Eight";
                break;
            case 9: digitWord = "Nine";
                break;
            default:
                break;
        }
        return digitWord;

    }

    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(LastDigit(num));
    }
}