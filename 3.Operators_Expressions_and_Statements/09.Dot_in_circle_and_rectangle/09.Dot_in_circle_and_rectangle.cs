//Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3)
//and out of the rectangle R(top=1, left=-1, width=6, height=2).


using System;

class Program
{
    static void Main()
    {
        Console.Title = "Is the given dot inside a circle K((1,1),3)";
        Console.WriteLine("Please enter the coordinates of the dot.");
        Console.WriteLine("X:");
        double coorX = double.Parse(Console.ReadLine());                    //Not sure if float or double?
        Console.WriteLine("Y:");
        double coorY = double.Parse(Console.ReadLine());
        if (coorX >= -1 && coorX <= 5 && coorY >= -1 && coorY <= 1)
        {
            Console.WriteLine("The dot is in the rectanel.");           
        }
        else
        {
            Console.WriteLine("The dot is outside the rectangel.");
        }
        coorX = coorX - 1;
        coorY = coorY - 1;
        double dist = Math.Sqrt((coorX * coorX) + (coorY * coorY));
        if (dist < 3)
        {
            Console.WriteLine("The dot is in the circle.");
        }
        else
        {
            if (dist == 3)
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
