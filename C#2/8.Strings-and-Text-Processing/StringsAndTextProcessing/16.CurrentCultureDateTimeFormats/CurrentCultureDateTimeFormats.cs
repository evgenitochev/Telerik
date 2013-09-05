//Write a program that reads two dates in the format: day.month.year and 
//calculates the number of days between them.

using System;
using System.Globalization;
using System.Text;

class CurrentCultureDateTimeFormats
    {
        static void Main()
        {
            //needed to display cyrillic characters
            Console.OutputEncoding = Encoding.Unicode;

            DateTimeFormatInfo di = DateTimeFormatInfo.CurrentInfo;
            string[] dateTimeFormats = di.GetAllDateTimePatterns();

            PrintDateTimeFormats(dateTimeFormats);
        }


        private static void PrintDateTimeFormats(string[] dateTimeFormats)
        {
            int index = 1;
            foreach (var format in dateTimeFormats)
            {
                Console.WriteLine(index + ":   " + format);
                index++;
            }
        }
    }