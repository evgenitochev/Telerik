/*Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. Example:
	Ivan			George
	Peter			Ivan
	Maria			Maria
	George			Peter
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class SortNames
{
    static void Main(string[] args)
    {

        string firstFileName = "../../mytemp01.txt";//the dir of the .cs file
        string newFileName = "../../ConcatenatedFile.txt"; //the dir of the .cs file

        Archive(newFileName);

        List<string> listOrder = SortFile(firstFileName);

        listOrder.Sort();

        WriteToFile(listOrder, newFileName);

        PrintFile(newFileName);

    }

    private static void WriteToFile(List<string> listOrder, string newFileName)
    {
        using (StreamWriter destinationFile = new StreamWriter(newFileName))
        {
            for (int i = 0; i < listOrder.Count; i++)
            {
                destinationFile.WriteLine(listOrder[i]);
            }
        }
    }

    private static List<string> SortFile(string firstFileName)
    {
        List<string> listOrder = new List<string>();

        using (StreamReader sourceFile = new StreamReader(firstFileName))
        {
            string line = sourceFile.ReadLine();
            while (line != null)
            {
                listOrder.Add(line);
                line = sourceFile.ReadLine();
            }
        }

        return listOrder;
    }

    private static void PrintFile(string newFileName)
    {
        Console.Write("Do You want to read the concatenated file <y/n>: ");
        char answer = (char)Console.Read();

        if (answer == 'y')
        {
            using (StreamReader concatenated = new StreamReader(newFileName))
            {
                string line = concatenated.ReadLine();

                while (line != null)
                {
                    Console.WriteLine(line);
                    line = concatenated.ReadLine();
                }
            }
        }
        else
        {
            Console.WriteLine("GoodBye");
        }
    }


    private static void Archive(string newFileName)
    {
        if (File.Exists(newFileName)) //if the file already exists we make an archive
        {
            string archiveName = newFileName.Remove(0, 6);
            string archive = "../../archive" + "-" + DateTime.Now.Hour + "-" + DateTime.Now.Day + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second + archiveName;
            File.Copy(newFileName, archive);
            File.Delete(newFileName);
        }

        File.Create(newFileName).Close();
    }
}