
//Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). 
//Write a program to test this method.


using System;

class Hello
{
    static void PrintName(string name)
    {
        Console.WriteLine("Hello, {0}", name);
    }

    static void Main()
    {
        Console.WriteLine("Enter your name:");
        string yourName = Console.ReadLine();
        PrintName(yourName);
    }
}

