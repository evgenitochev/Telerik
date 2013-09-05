//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;
using System.Linq;

public class AlpabeticalOrder
{
    public static void Main()
    {
        string[] inWords = Console.ReadLine().Split();

        var sortedWords = inWords.OrderBy(x => x); 
        foreach (var item in sortedWords)
        {
            Console.Write("{0} ", item);
        }
    }
}