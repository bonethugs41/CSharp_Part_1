//Write an expression that calculates rectangle’s area by given width and height.



using System;

class RectangleArea
{
    static void Main(string[] args)
    {
        Console.Title = "Rectangle Area";
        Console.WriteLine("Width:");
        uint width = uint.Parse(Console.ReadLine());
        Console.WriteLine("Height:");
        uint height = uint.Parse(Console.ReadLine());
        uint area = width * height;
        Console.WriteLine("The area is:{0}", area);

    }
}
