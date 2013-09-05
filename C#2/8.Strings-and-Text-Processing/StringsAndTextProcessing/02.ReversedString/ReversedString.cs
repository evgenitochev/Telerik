//Write a program that reads a string, reverses it and prints the result at the console.


using System;

class ReversedString
{
    static void Main()
    {
        string str = "abcd";
        char[] stringArr = str.ToCharArray();
        Array.Reverse(stringArr);

        Console.WriteLine(stringArr);
        
    }
}