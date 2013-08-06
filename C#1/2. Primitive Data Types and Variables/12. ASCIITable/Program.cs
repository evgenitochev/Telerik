// Write a program that prints the entire ASCII table of characters on the console.



using System;

class PrintsASCIITable
{
    static void Main()
    {
        Console.WriteLine("ASCII");
        for (byte i = 32; i < 128; i++)
        {
            Console.WriteLine((char)i);
        }
    }
}