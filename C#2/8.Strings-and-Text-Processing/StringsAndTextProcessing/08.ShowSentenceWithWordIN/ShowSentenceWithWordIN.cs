//Write a program that extracts from a given text all sentences containing given word.

using System;

class ShowSentenceWithWordIN
{
    static void Main()
    {
        string str = @"In A in living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

        ShowSentenceWithWord(str);
    }

    static void ShowSentenceWithWord(string str)
    {
        int startIndex = 0;
        int endIndex = 0;

        bool afterInDot = false;
        bool afterInSpace = false;

        bool beforeInDot = false;
        bool beforeInSpace = false;
        bool iZeroBased = false;

        for (int i = 0; i < str.Length; i++)
        {
            if (str.Substring(i, 1) == "." && startIndex < i)
            {
                endIndex = i - 1;

                for (int k = startIndex; k <= endIndex; k++)
                {
                    if (str.Substring(k, 2).ToLower() == "in")
                    {
                        if (str.Substring(k, 2).ToLower() == "in" && k != 0)
                        {
                            if (str.Substring(k + 2, 1) == ".")
                            {
                                afterInDot = true;
                            }
                            if (str.Substring(k + 2, 1) == " ")
                            {
                                afterInSpace = true;
                            }
                            if (str.Substring(k - 1, 1) == " ")
                            {
                                beforeInSpace = true;
                            }
                            if (str.Substring(k - 1, 1) == " ")
                            {

                            }
                        }

                        if (str.Substring(k, 2).ToLower() == "in" && k == 0)
                        {
                            iZeroBased = true;
                            if (str.Substring(k + 2, 1) == " ")
                            {
                                afterInSpace = true;
                            }
                        }
                    }

                    if (beforeInSpace && afterInSpace || beforeInSpace && afterInDot || iZeroBased && afterInDot)
                    {
                        int length = endIndex - startIndex;
                        Console.WriteLine(str.Substring(startIndex, length + 2).Trim());
                        startIndex = 0;
                        endIndex = 0;

                        afterInDot = false;
                        afterInSpace = false;

                        beforeInSpace = false;
                        iZeroBased = false;
                        break;
                    }
                }
                startIndex = i + 1;
            }
        }
    }
}