//Write a program that converts a string to a sequence of C# Unicode character literals. 
//Use format strings. 

using System;

class ConvertToUnicode
{
    static void Main()
    {
        string str = @"Hi .NET Ninja!";

        foreach (var symbol in str)
        {
            Console.WriteLine("\\u{0:X4}", (int)symbol);
        }
    }
}