﻿//Write a program that reverses the words in given sentence.


using System;
using System.Text;

class ReverseWordInSentence
{
    static void Main()
    {
        string str = "C# is not C++, not, PHP .and not Delphi!";
        string[] strWords = str.Split(new char[] { '!', '.', ',', ' ', }, StringSplitOptions.RemoveEmptyEntries);
        string[] signs = str.Split(new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                                                'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
                                                '+', '#', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k',
                                                'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x',
                                                'y', 'z', '1', '2', '3', '4', '5', '6', '7', '8', '9', ')', '(',
                                                '*', '/', '=', '~', '`' }, StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(strWords);
        StringBuilder strWordsReversed = new StringBuilder();

        for (int i = 0; i < signs.Length; i++)
        {
            strWordsReversed.Append(strWords[i]);
            strWordsReversed.Append(signs[i]);
        }
        Console.WriteLine(strWordsReversed.ToString());
    }
}