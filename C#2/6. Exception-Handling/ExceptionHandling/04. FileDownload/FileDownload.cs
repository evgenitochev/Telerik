//Write a program that downloads a file from Internet 
//(e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores it the current directory.
//Find in Google how to download files in C#. Be sure to catch all exceptions and to free any used resources in the finally block.


using System;
using System.Linq;
using System.Net;

class FileDownload
{
    static void Main(string[] args)
    {
        using (WebClient picture = new WebClient())
        {
            try
            {
                Console.WriteLine("This program will download the logo of BARS to your desktop.");
                string path = Environment.ExpandEnvironmentVariables(@"%UserProfile%\Desktop\logo-basd.jpg");
                picture.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", path);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("You entered an empty address.");
            }
            catch (WebException we)
            {
                Console.WriteLine(we.Message);
            }
            catch (NotSupportedException nse)
            {
                Console.WriteLine(nse.Message);
            }
        }

    }
}