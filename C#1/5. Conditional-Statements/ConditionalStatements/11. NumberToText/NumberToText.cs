//* Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. 

using System;

class NumberToText
{
    static void Main()
    {
        Console.WriteLine("Enter integer between 0 and 999: ");
        int enter = int.Parse(Console.ReadLine());

        if (enter >= 0 && enter <= 999)
        {
            int hundreds = enter % 10;
            enter /= 10;
            int tens = enter % 10;
            enter /= 10;
            int ones = enter % 10;
            switch (ones)
            {
                case 1: Console.Write("one hundred "); break;
                case 2: Console.Write("two hundred "); break;
                case 3: Console.Write("three hundred "); break;
                case 4: Console.Write("four hundred "); break;
                case 5: Console.Write("five hundred "); break;
                case 6: Console.Write("six hundred "); break;
                case 7: Console.Write("seven hundred "); break;
                case 8: Console.Write("eight hundred "); break;
                case 9: Console.Write("nine hundred "); break;
                case 0: break;
            }
            switch (tens)
            {
                case 1:
                    if (ones == 0)  break;
                    else 
                    {
                        Console.Write("and ");
                    }
                    break;
                case 2: Console.Write("twenty "); break;
                case 3: Console.Write("thirty "); break;
                case 4: Console.Write("fourty "); break;
                case 5: Console.Write("fifty "); break;
                case 6: Console.Write("sixsty "); break;
                case 7: Console.Write("seventy "); break;
                case 8: Console.Write("eighty "); break;
                case 9: Console.Write("ninety "); break;
                case 0:
                    if (ones == 0) break;
                    else if (hundreds == 0) break;

                    else
                    {
                        Console.Write("and ");
                    }
                    break;
            }
            switch (hundreds)
            {
                case 1:
                    if (tens == 1) Console.WriteLine("eleven");
                    else if (tens == 0 && ones == 0) Console.WriteLine("one");
                    else if (tens == 0) Console.WriteLine("one");
                    else
                    {
                        Console.WriteLine("one");
                    }
                    break;
                case 2:
                    if (tens == 1) Console.WriteLine("twelve");
                    else if (tens == 0 && ones == 0) Console.WriteLine("two");
                    else if (tens == 0) Console.WriteLine("two");
                    else
                    {
                        Console.WriteLine("two");
                    }
                    break;
                case 3:
                    if (tens == 1) Console.WriteLine("thirteen");
                    else if (tens == 0 && ones == 0) Console.WriteLine("three");
                    else if (tens == 0) Console.WriteLine("three");
                    else
                    {
                        Console.WriteLine("three");
                    }
                    break;
                case 4:
                    if (tens == 1) Console.WriteLine("fourtheen");
                    else if (tens == 0 && ones == 0) Console.WriteLine("four");
                    else if (tens == 0) Console.WriteLine("four");
                    else
                    {
                        Console.WriteLine("four");
                    }
                    break;
                case 5:
                    if (tens == 1) Console.WriteLine("fifteen");
                    else if (tens == 0 && ones == 0) Console.WriteLine("five");
                    else if (tens == 0) Console.WriteLine("five");
                    else
                    {
                        Console.WriteLine("five");
                    }
                    break;
                case 6:
                    if (tens == 1) Console.WriteLine("sixteen");
                    else if (tens == 0 && ones == 0) Console.WriteLine("six");
                    else if (tens == 0) Console.WriteLine("six");
                    else
                    {
                        Console.WriteLine("six");
                    }
                    break;
                case 7:
                    if (tens == 1) Console.WriteLine("seventeen");
                    else if (tens == 0 && ones == 0) Console.WriteLine("seven");
                    else if (tens == 0) Console.WriteLine("seven");
                    else
                    {
                        Console.WriteLine("seven");
                    }
                    break;
                case 8:
                    if (tens == 1) Console.WriteLine("eighteen");
                    else if (tens == 0 && ones == 0) Console.WriteLine("eight");
                    else if (tens == 0) Console.WriteLine("eight");
                    else
                    {
                        Console.WriteLine("eight");
                    }
                    break;
                case 9:
                    if (tens == 1) Console.WriteLine("nineteen");
                    else if (tens == 0 && ones == 0) Console.WriteLine("nine");
                    else if (tens == 0) Console.WriteLine("nine");
                    else
                    {
                        Console.WriteLine("nine");
                    }
                    break;
                case 0:
                    if (tens == 0 && ones == 0) Console.WriteLine("zero");
                    else break;
                    break;
            }
        }
        else
        {
            Console.WriteLine("Incorrect input!");
        }
    }
}