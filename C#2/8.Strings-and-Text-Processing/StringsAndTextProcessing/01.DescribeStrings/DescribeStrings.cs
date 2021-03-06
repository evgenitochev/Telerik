﻿//1.Describe the strings in C#. What is typical for the string data type? Describe the most important methods
//of the String class.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DescribeStrings
{
    static void Main()
    {
        Console.WriteLine("Strings are collections of characters.");
        Console.WriteLine("This type allows us to manipulate character data through different methods and properties.");
        Console.WriteLine("You can use string methods to concatenate, append, replace, search and split strings.");
        Console.WriteLine("A string is a class, that holds characters and provides operations such as:");
        Console.WriteLine("subscripting, concatenation, and comparison.");
        Console.WriteLine("Below, you will find some examples for using string and string methods" + Environment.NewLine);

        //Get lenght of the string
        string text = "somestring";
        Console.WriteLine(text + " lenght -> " + text.Length);

        // Convert to uppercase.
        text = text.ToUpper();
        Console.WriteLine("ToUpper ->" + text);

        // Convert to lowercase.
        text = text.ToLower();
        Console.WriteLine("ToLower ->" + text);
        Console.WriteLine();

        //Substring -  get the first 4 characters
        Console.WriteLine("Substring - get first four characters:");
        string substring = text.Substring(0, 4);
        Console.WriteLine("Substring: {0}", substring);
        Console.WriteLine();

        //Remove leading or trailing whitespace
        string removeSpace = "  some string text  ";
        Console.WriteLine(Environment.NewLine + "Remove leading or trailing whitespace: " + "!" + removeSpace + "!");
        Console.Write("!");
        Console.Write(removeSpace.Trim());
        Console.WriteLine("!");

        //Split string
        string stringSample = "This is an example for string split";
        Console.WriteLine(Environment.NewLine + "Split string on spaces.This will separate all words of the string.");

        string[] words = stringSample.Split(' ');
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        //IndexOf method - one of the searching methods
        Console.WriteLine(Environment.NewLine + "IndexOf method:");
        if (stringSample.IndexOf("example") != -1)
        {
            Console.Write("string contains 'example'");
        }
        Console.WriteLine();

        //Copy string
        Console.WriteLine(Environment.NewLine + "Copy a literal string");

        string sample = "This is a string";
        string copySample = string.Copy(sample);

        Console.WriteLine("First string: ");
        Console.WriteLine(sample);
        Console.WriteLine("Second string: ");
        Console.WriteLine(copySample);
        // See if the references are equal.
        Console.WriteLine("Are two strings Equal?: " + object.ReferenceEquals(sample, copySample));
        Console.WriteLine("That is because the object data is equivalent in both objects, but the data ");
        Console.WriteLine("is not in the same storage location and the references are unequal.");

        //Concatenation
        Console.WriteLine(Environment.NewLine + "Concatenation of strings:");
        sample = string.Concat(sample, " and ", copySample);
        Console.WriteLine(sample);

        //Replace
        Console.WriteLine(Environment.NewLine + "Replace text in string:");
        string replace = copySample.Replace("This", "That");
        Console.WriteLine(replace);
        Console.WriteLine();

        //Append
        Console.WriteLine(Environment.NewLine + "Append the word \"NEW\" to the previous string.");
        copySample += " NEW";
        Console.WriteLine(copySample);

        //Compare strings
        string first = "First string";
        string second = "Second string";
        Console.WriteLine(Environment.NewLine + "Compare strings: " + first + ", " + second);
        Console.WriteLine("If the first string is bigger, the result is 1. If the first string is smaller, the result is -1.");
        Console.WriteLine("If both strings are equal, the result is 0. The number essentially indicates how much larger the first string is.");

        int compare = string.Compare(first, second);
        Console.WriteLine("Compare first, second " + compare);

        compare = string.CompareOrdinal(second, first);
        Console.WriteLine("Compare second, first " + compare);

        compare = first.CompareTo(second);
        Console.WriteLine("first.CompareTo(second) " + compare);

        compare = second.CompareTo(first);
        Console.WriteLine("second.CompareTo(first) " + compare);
    }
}