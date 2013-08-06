/*Declare two string variables and assign them with following value:
  Do the above in two different ways: with and without using quoted strings.*/

using System;

class StringsWithWithoutQuoted
{
    static void Main()
    {
        string withQuoted = @"The ""use"" of quotations causes difficulties.";
        string withoutQuoted = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine("With Quoted: {0}\n Whitout Quoted: {1}", withQuoted, withoutQuoted);
    }
}