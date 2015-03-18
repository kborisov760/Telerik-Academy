//Problem 4. Download file

//Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
//Find in Google how to download files in C#.
//Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.IO;
using System.Net;
using System.Text;
using System.Collections.Generic;
class DownloadFile
{
    static void Main()
    {
        // Description on http://msdn.microsoft.com/en-us/library/ez801hhe%28v=vs.110%29.aspx
        string myWebPath = @"http://www.devbg.org/img/Logo-BASD.jpg";
        string myLocalPath = @"..\..\MyDownload.jpg";
        WebClient myWebClient = new WebClient();
        try
        {
            myWebClient.DownloadFile(myWebPath, myLocalPath);
            Console.WriteLine("File is downloaded in the desired directory ...");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Address empty");
        }
        catch (WebException)
        {
            Console.WriteLine("Invalid Web address, local Path or inaccessible target File");
        }
    }
}
