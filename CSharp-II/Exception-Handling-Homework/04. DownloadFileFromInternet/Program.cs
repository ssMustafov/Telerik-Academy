// Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) 
// and stores it the current directory. Find in Google how to download files in C#. 
// Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.Net;

class Program
{
    static void Main()
    {
        string url = "http://www.devbg.org/simg/Logo-BASD.jpg";
        string file = "Logo-BASD.jpg";

        try
        {
            using (WebClient web = new WebClient())
            {
                web.DownloadFile(url, file);
            }
        }
        catch (WebException we)
        {
            Console.WriteLine(we.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}