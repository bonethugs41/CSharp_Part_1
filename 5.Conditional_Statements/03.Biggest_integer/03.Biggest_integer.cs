//Write a program that finds the biggest of three integers using nested if statements.


using System;

class Program
{
    static void Main()
    {
        Console.Title = "Greater number";
        int x;
        int y;
        int z;
        while (true)
	    {
	        Console.Write("Input X:");
            string check = Console.ReadLine();
            bool xCheck = int.TryParse(check, out x);

            Console.Write("Input Y:");
            check = Console.ReadLine();
            bool yCheck = int.TryParse(check, out y);

            Console.Write("Input Z:");
            check = Console.ReadLine();
            bool zCheck = int.TryParse(check, out z);

            //Don't know how to check if the three numbers are different

            if ((xCheck == true) && (yCheck == true) && (zCheck == true))
            {
                break;
	        }
            else
	        {
                Console.WriteLine("Invalid numbers. Try again:");
	        }
	    }
        if (x > y)
        {
            if (x > z)
            {
                Console.WriteLine("The biggest number is X={0}", x);
            }
            else
            {
                Console.WriteLine("The biggest number is Z={0}", z);
            }
        }
        else
        {
            if (y > z)
            {
                Console.WriteLine("The biggest number is Y={0}", y);
            }
            else
            {
                Console.WriteLine("The biggest number is Z={0}", z);
            }
        }
    }
}