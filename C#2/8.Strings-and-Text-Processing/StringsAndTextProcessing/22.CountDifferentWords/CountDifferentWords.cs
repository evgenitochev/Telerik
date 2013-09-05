
//Write a program that reads a string from the console and lists all different words 
//in the string along with information how many times each word is found.

using System;
using System.Collections.Generic;
using System.Diagnostics;

class CountDifferentWords
{
    static void Main()
    {
        string text = "i will try to explain, what is dictionary and how to use dictionary.";
        string[] allWordsArr = text.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> dict = new Dictionary<string, int>();

        foreach (var word in allWordsArr)
        {
            if (dict.ContainsKey(word))
            {
                dict[word] = dict[word] + 1;
            }
            else //(!rechnik.ContainsKey(word))
            {
                dict.Add(word, 1);
            }
        }

        foreach (var word in dict)
        {
            Console.WriteLine("{0,-15} - {1} times", word.Key, word.Value);
        }
    }
}