//Write an expression that calculates trapezoid's area by given sides a and b and height h.



using System;

class Trapezoid
{
    static void Main()
    {
        Console.Title = "Trapezoid's area";
        Console.WriteLine("Please input the trapezoid's parameters.");
        Console.WriteLine("Side a:");
        uint sideA = uint.Parse(Console.ReadLine());
        Console.WriteLine("Side b:");
        uint sideB = uint.Parse(Console.ReadLine());
        Console.WriteLine("Height h:");
        uint heightH = uint.Parse(Console.ReadLine());
        uint area = (((sideA + sideB) / 2) * heightH);
        Console.WriteLine("The trapezoid area is: {0}", area);
    }
}