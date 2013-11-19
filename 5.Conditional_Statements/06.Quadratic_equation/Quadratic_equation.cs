//Write a program that enters the coefficients a, b and c of a quadratic equation
//		a*x^2 + b*x + c = 0
//and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.



using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Title = "Quadratic equation";
        double a;
        double b;
        double c;
        Console.WriteLine("Input as follows.");
        while (true)
        {
            Console.Write("A:");
            string check = Console.ReadLine();
            bool aCheck = double.TryParse(check, out a);

            Console.Write("B:");
            check = Console.ReadLine();
            bool bCheck = double.TryParse(check, out b);

            Console.Write("C:");
            check = Console.ReadLine();
            bool cCheck = double.TryParse(check, out c);

            if ((aCheck == true) && (bCheck == true) && (cCheck == true))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid numbers. Try again.");
            }
        }
        double discreminant = Math.Pow(b, 2) - (4 * a * c);
        if (discreminant == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("The equation has one solution: x = {0}", x);
        }
        else
        {
            if (discreminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discreminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discreminant)) / (2 * a);
                Console.WriteLine("The equation has two real roots: \nx1 = {0} \nx2 = {1}", x1, x2);
            }
            else
            {
                Console.WriteLine("The equation has no real roots.");
            }
        }
    }
}