//Sort 3 real values in descending order using nested if statements.


using System;

class SortNumbers
{
    static void Main()
    {
        Console.Title = "Sort values";
        int x;
        int y;
        int z;
        Console.WriteLine("Input three numbers:");
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

            if ((xCheck == true) && (yCheck == true) && (zCheck == true))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid number. Try again.");
            }
        }
        if (x > y)
        {
            if (y > z)
            {
                Console.WriteLine("{0}, {1}, {2}", x, y, z);
            }
            else
            {
                if (x > z)
                {
                    Console.WriteLine("{0}, {1}, {2}", x, z, y);
                }
                else
                {
                    Console.WriteLine("{0}, {1}, {2}", z, x, y);
                }
            }
        }
        else
        {
            if (x > z)
            {
                Console.WriteLine("{0}, {1}, {2}", y, x, z);
            }
            else
            {
                if (y > z)
                {
                   Console.WriteLine("{0}, {1}, {2}", y, z, x); 
                }
                else
                {
                    Console.WriteLine("{0}, {1}, {2}", z, y, x);
                }
            }
        }
    }
}