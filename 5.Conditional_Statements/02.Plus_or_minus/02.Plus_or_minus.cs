//Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it.
//Use a sequence of if statements.



using System;

class PlusMinus
{
    static void Main()
    {
        Console.Title = "Plus or minus";
        double x;
        double y;
        double z;
        while (true)
        {
            Console.Write("Input X:");
            string value = Console.ReadLine();
            bool xCheck = double.TryParse(value, out x);
            Console.Write("Input Y:");
            value = Console.ReadLine();
            bool yCheck = double.TryParse(value, out y);
            Console.Write("Input Z:");
            value = Console.ReadLine();
            bool zCheck = double.TryParse(value, out z);
            if ((xCheck == true) && (yCheck == true) && (zCheck == true))
	        {
                 break;		 
	        }
            else
	        {
                 Console.WriteLine("Invalid numbers. Try again:");
	        }
        }
        if (x == 0 || z == 0 || y == 0)
	    {
            Console.WriteLine("Product is 0.");
	    }
        else
        {
            if ((x > 0 && y > 0 && z > 0) || (x < 0 && y < 0 && z > 0) || (x < 0 && y > 0 && z < 0) || (x > 0 && y < 0 && z < 0))
            {
	        	 Console.WriteLine("Sign is '+'");
            }
            else
	        {
                Console.WriteLine("Sign is '-'");
        	}
        }
        
    }
}