//Problem 2. Gravitation on the Moon

//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

using System;
class GravitationOnTheMoon
{
    static void Main()
    {
        Console.Write("Enter man's weight: ");
        double weight = double.Parse(Console.ReadLine());
        double moonWeight = Math.Round((weight*17)/100, 3);
        Console.WriteLine("This man's weight on the Moon will be {0}kg.", moonWeight);
    }
}
