//Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;
using System.Collections.Generic;
class BinaryToHex
{
    static void Main()
    {
        string binNumber = Console.ReadLine();

        char[] binArray = binNumber.ToCharArray();

        int remainder = binArray.Length % 4;

        List<string> hexNum = new List<string>();

        binArray = (new string('0', remainder) + binNumber).ToCharArray();

        for (int i = 0; i < binArray.Length - 1; i += 4)
        {
            string bit = string.Concat(binArray[i].ToString(), binArray[i + 1].ToString(), binArray[i + 2].ToString(), binArray[i + 3].ToString());
            switch (bit)
            {
                case "0000": hexNum.Add("0");
                    break;
                case "0001": hexNum.Add("1");
                    break;
                case "0010": hexNum.Add("2");
                    break;
                case "0011": hexNum.Add("3");
                    break;
                case "0100": hexNum.Add("4");
                    break;
                case "0101": hexNum.Add("5");
                    break;
                case "0110": hexNum.Add("6");
                    break;
                case "0111": hexNum.Add("7");
                    break;
                case "1000": hexNum.Add("8");
                    break;
                case "1001": hexNum.Add("9");
                    break;
                case "1010": hexNum.Add("A");
                    break;
                case "1011": hexNum.Add("B");
                    break;
                case "1100": hexNum.Add("C");
                    break;
                case "1101": hexNum.Add("D");
                    break;
                case "1110": hexNum.Add("E");
                    break;
                case "1111": hexNum.Add("F");
                    break;
                default:
                    break;

            }
        }
        for (int i = 0; i < hexNum.Count; i++)
        {
            Console.Write(hexNum[i]);
        }
        Console.WriteLine();
      
    }
}
