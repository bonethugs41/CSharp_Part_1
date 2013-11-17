//Write a program that reads two positive integer numbers and prints
//how many numbers p exist between them such that the reminder of the
//division by 5 is 0 (inclusive). Example: p(17,25) = 2.



using System;

class IntervalNumbers
{
    static void Main()
    {
        Console.Title = "Numbers defined by interval";
        Console.WriteLine("Enter two different numbers. First one should be smaller than second:");
        int x;
        int y;
        while (true)
        {
            string value = Console.ReadLine();
            bool xResult = int.TryParse(value, out x);
            value = Console.ReadLine();
            bool yResult = int.TryParse(value, out y);
            if ((xResult == true) && (yResult == true) && (x < y))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid numbers. Try Again:");
            }
        }
        int sum = 0;
        for (int i = x; i <= y; i++)
        {
            if (i % 5 == 0)
            {
                sum = sum + 1;
            }
        }
        Console.WriteLine("THere are {0} numbers between {1} and {2} which can be devided by 5.", sum, x, y);
    }
}