//Problem 8. Isosceles Triangle

//Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
//   ©

//  © ©

// ©   ©

//© © © ©

using System;
using System.Text;
class IsoscelesTriangle
{
    static void Main()
    {
        char copyRight = Convert.ToChar(169);
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("   {0}   ", copyRight);
        Console.WriteLine("  {0} {1}  ", copyRight, copyRight);
        Console.WriteLine(" {0}   {1}", copyRight, copyRight);
        Console.WriteLine("{0} {1} {2} {3}", copyRight, copyRight, copyRight, copyRight);
    }
}
