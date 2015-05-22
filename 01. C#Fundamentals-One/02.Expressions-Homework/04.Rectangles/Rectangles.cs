//Problem 4. Rectangles

//Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;
class Rectangles
{
    static void Main()
    {
        Console.Write("Enter rectrangle width: ");
        int width = int.Parse(Console.ReadLine());
        Console.Write("Enter rectrangle height: ");
        int height = int.Parse(Console.ReadLine());
        int perimeter = 2 * width + 2 * height;
        int area = width * height;
        Console.WriteLine("Rectangle's perimeter is {0}", perimeter);
        Console.WriteLine("Rectangle's area is {0}", area);
    }
}
