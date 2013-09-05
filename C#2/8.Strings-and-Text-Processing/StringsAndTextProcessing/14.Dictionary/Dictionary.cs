//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary. 

using System;

class Dictionary
{
    static void Main()
    {
        string[] words = { ".NET", "CLR", "namespace" };
        string[] description = { "platform for applications from Microsoft",
                                 "managed execution environment for .NET",
                                 "hierarchical organization of classes" };
        string input = Console.ReadLine();

        for (int i = 0; i < words.Length; i++)
        {
            if (input == words[i])
            {
                Console.WriteLine("{0} - {1}", words[i], description[i]);
            }
        }
    }
}