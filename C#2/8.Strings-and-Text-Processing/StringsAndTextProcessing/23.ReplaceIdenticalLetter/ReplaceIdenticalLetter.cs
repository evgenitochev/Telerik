//Write a program that reads a string from the console and replaces all series of 
//consecutive identical letters with a single one. Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".

using System;
using System.Collections.Generic;

class ReplaceIdenticalLetter
{

    static void Main()
    {
        List<string> str = new List<string> { "abc", "abbbbbcs", "abcddd", "aabc", "aabbcc" };

        for (int word = 0; word < str.Count; word++)
        {
            int wordLength = str[word].Length;
            int countRemovedLetter = 1;
            for (int letter = 0; letter < wordLength - countRemovedLetter; letter++)
            {
                if (str[word].Substring(letter, 1) == str[word].Substring(letter + 1, 1))
                {
                    str[word] = str[word].Remove(letter, 1);
                    countRemovedLetter++;
                    letter--;
                }
            }
        }
        foreach (var item in str)
        {
            Console.WriteLine(item);
        }
    }
}
