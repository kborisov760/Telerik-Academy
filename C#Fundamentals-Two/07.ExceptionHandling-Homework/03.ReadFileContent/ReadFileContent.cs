//Problem 3. Read file contents

//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
//Find in MSDN how to use System.IO.File.ReadAllText(…).
//Be sure to catch all possible exceptions and print user-friendly error messages.

using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
class ReadFileContent
{
    static void Main()
    {
        string fileToRead = @"c:\Windows\win.ini";
        string allText = "";
        Encoding myEncode = Encoding.GetEncoding("Windows-1251");
        try
        {
            allText = File.ReadAllText(fileToRead, myEncode);
            Console.WriteLine(allText);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found");
        }
        catch (FileLoadException)
        {
            Console.WriteLine("File cannot be accessed");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Path not exists");
        }
    }
}
