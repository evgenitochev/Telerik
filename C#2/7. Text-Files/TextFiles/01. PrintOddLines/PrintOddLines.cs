//Write a program that reads a text file and prints on the console its odd lines.


using System;
using System.IO;
namespace ConsoleApplication1
{
    class oddLines
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("mytemp.txt");
            using (reader)
            {
                string content = reader.ReadLine();
                int numOfLine = 0;
                while (content != null)
                {

                    numOfLine++;
                    if (numOfLine % 2 == 1)
                    {
                        Console.WriteLine(content);
                    }
                    content = reader.ReadLine();


                }
            }
        }
    }
}