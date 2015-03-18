//Problem 6. Strings and Objects

//Declare two string variables and assign them with Hello and World.
//Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
//Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).

using System;
class StringObject
{
    static void Main()
    {
        string firstVar = "Hello";
        string secondVar = "World";
        object concatVar = firstVar + " " + secondVar;
        string printVar = concatVar.ToString();
        Console.WriteLine(printVar);
    }
}