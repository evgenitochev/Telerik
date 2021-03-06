﻿//Write a program that compares two text files line by line and prints the number of 
//lines that are the same and the number of lines that are different.
//Assume the files have equal number of lines.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class CompareLineByLine
{
    static void Main(string[] args)
    {
        string firstFileName = "../../mytemp01.txt";//the dir of the .cs file
        string secondFileName = "../../mytemp02.txt"; //the dir of the .cs file


        CompareTwoFiles(firstFileName, secondFileName);
    }

    private static void CompareTwoFiles(string firstFileName, string secondFileName)
    {
        int equalLines = 0;
        int differentLines = 0;

        using (StreamReader firstReader = new StreamReader(firstFileName))
        {
            using (StreamReader secondReader = new StreamReader(secondFileName))
            {
                string firstLine = firstReader.ReadLine();
                string secondLine = secondReader.ReadLine();

                while (firstLine != null && secondLine != null)
                {
                    if (firstLine == secondLine)
                    {
                        equalLines++;
                    }
                    else
                    {
                        differentLines++;
                    }

                    firstLine = firstReader.ReadLine();
                    secondLine = secondReader.ReadLine();
                }
            }
        }

        Console.WriteLine("Total lines: {0}", equalLines + differentLines);
        Console.WriteLine("Equal lines: {0}", equalLines);
        Console.WriteLine("Different lines: {0}", differentLines);

    }
}
