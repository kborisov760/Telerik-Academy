//Problem 1. Say Hello

//Write a method that asks the user for his name and prints “Hello, <name>”
//Write a program to test this method.

using System;
using System.Collections.Generic;
class SayHello
{
    static void SayHelloMethod(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }
    static void Main()
    {
        SayHelloMethod("Ivan");
    }
}
