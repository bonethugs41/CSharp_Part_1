//Write an expression that checks if given point (x,  y) is within a circle K(O, 5)*.

//*I guess this means the circle has center coordinate (0,0) and radius 5.

using System;


class DotInCircle
{
    static void Main()
    {
        Console.Title = "Is the given dot inside a circle K(0,5)";
        Console.Write("X coordinate of dot: ");
        double inputX = double.Parse(Console.ReadLine());                   //Not sure if float or double?
        Console.Write("Y coordinate of dot: ");
        double inputY = double.Parse(Console.ReadLine());
        double dist = Math.Sqrt((inputX * inputX) + (inputY * inputY));
        if (dist < 5)
        {
            Console.WriteLine("The dot is in the circle.");
        }
        else
        {
            if (dist == 5)
            {
                Console.WriteLine("The dot is on the circle.");
            }
            else
            {
                Console.WriteLine("The dot is outside the circle.");
            }
        }
    }
}




// The circle with centre coordinates (a, b) and radius r is the set of all points (x, y) such that:
//                  (x^2 - a^2) + (y^2 - b^2) = r^2
// If the circle is centred at the origin (0, 0), then the equation simplifies to:
//                  x^2 + y^2 = r^2.