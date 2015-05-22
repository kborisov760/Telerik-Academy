using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class ParseURL
{
    static void Main()
    {
        Uri webAddress = new Uri("http://telerikacademy.com/Courses/Courses/Details/212");
        Console.WriteLine("[protocol] = {0}", webAddress.Scheme);
        Console.WriteLine("[server] = {0}", webAddress.Authority);
        Console.WriteLine("[resource] = {0}", webAddress.LocalPath);
    }
}
