//Write a program to convert decimal numbers to their hexadecimal representation.


using System;
using System.Collections.Generic;
class DecimalToHexadecimal
{
    static void Main()
    {
        Console.WriteLine("Enter your number:");
        int number = int.Parse(Console.ReadLine());

        List<string> hexNum = new List<string>();

        while (number > 0)
        {
            switch (number % 16)
            {
                case 10: hexNum.Add("A");
                    break;
                case 11: hexNum.Add("B");
                    break;
                case 12: hexNum.Add("C");
                    break;
                case 13: hexNum.Add("D");
                    break;
                case 14: hexNum.Add("E");
                    break;
                case 15: hexNum.Add("F");
                    break;
                default: hexNum.Add((number % 16).ToString());
                    break;
            }
            number = number / 16;
        }

        hexNum.Reverse();

        for (int i = 0; i < hexNum.Count; i++)
        {
            Console.Write("{0}", hexNum[i]);
        }

        Console.WriteLine();
    }
}
