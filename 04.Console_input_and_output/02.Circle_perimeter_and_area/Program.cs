//Write a program that reads the radius r of a circle and prints its perimeter and area.



using System;

class CircleParameters
{ 
    static void Main()
    {
        Console.Title = "Perimeter and area of a circle";
        Console.WriteLine("Please input the radius of the circle:");
        double radius = double.Parse(Console.ReadLine());
        double perimeter = 2 * radius * 3.14;
        double area = 3.14 * radius * radius;
        Console.WriteLine("The perimeter of the circle is: {0}", perimeter);
        Console.WriteLine("The area of the circle is: {0}", area);

    }
}
