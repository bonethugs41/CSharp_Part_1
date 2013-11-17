//Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 
//and solves it (prints its real roots).



using System;

class EquationQ
{
    static void Main()
    {
        Console.Title = "Quadratic equation";
        double a;
        double b;
        double c;
        Console.WriteLine("Input as follows:");
        while (true)
        {
            Console.Write("a = ");
            string check = Console.ReadLine();
            bool aResult = double.TryParse(check, out a);

            Console.Write("b = ");
            check = Console.ReadLine();
            bool bResult = double.TryParse(check, out b);

            Console.Write("c = ");
            check = Console.ReadLine();
            bool cResult = double.TryParse(check, out c);
            if ((aResult == true) && (bResult == true) && (cResult == true))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid numbers. Try again.");
            }
        }
        double D = Math.Pow(b, 2) - (4 * a * c);
        if (D == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("Equation has one solution: {0}", x);
        }
        else
        {
            double x1 = (-b + Math.Sqrt(D)) / (2 * a);
            double x2 = (-b - Math.Sqrt(D)) / (2 * a);
            Console.WriteLine("Equation has two solutions:\nx={0}\nx={1}", x1, x2);
        }
    }
}