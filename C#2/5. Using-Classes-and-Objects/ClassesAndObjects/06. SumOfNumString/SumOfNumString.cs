//You are given a sequence of positive integer values written into a string, separated by spaces. 
//Write a function that reads these values from given string and calculates their sum.

using System;

class SumOfNumString
{
    static void Main()
    {
       
        //string input = "43 68 9 23 318";
        string input = Console.ReadLine();

        input = input.Trim();
        int sum = 0;
        string[] strNums = input.Split(' ');
        for (int i = 0; i < strNums.Length; i++)
        {
            sum = sum + int.Parse(strNums[i].Trim());
        }
        Console.WriteLine(sum);
    }
}