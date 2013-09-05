//Write a program that extracts from given XML file all the text without the tags.


using System;
using System.IO;
using System.Text;
using System.Xml;

namespace ParseXml
{
    class ParseXml
    {
        static void Main()
        {
            string fileSourcePath = "test.xml";
            string fileResultPath = "result.txt";

            try
            {
                using (XmlReader reader = XmlReader.Create(new StreamReader(fileSourcePath, Encoding.GetEncoding("utf-8"))))
                {
                    while (!reader.EOF)
                    {
                        using (StreamWriter writer = new StreamWriter(fileResultPath, false, Encoding.GetEncoding("utf-8")))
                        {
                            while (!reader.EOF)
                            {
                                reader.Read();
                                if (reader.NodeType == XmlNodeType.Text)
                                {
                                    writer.WriteLine(reader.Value);
                                }
                            }
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("io operation error!");
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("error while trying to parse xml!");
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("error while trying to parse xml!");
                Console.WriteLine(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("error while trying to parse xml!");
                Console.WriteLine(ex.Message);
            }
            catch (XmlException ex)
            {
                Console.WriteLine("error while trying to parse xml!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}