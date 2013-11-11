//Write a boolean expression that checks for given integer if it can be divided (without remainder)
//by 7 and 5 in the same time.



using System;

class Divided
{
    static void Main()
    {
        Console.Title = "Divided by 7 and 5";
        Console.WriteLine("Type a number:");
        int a = int.Parse(Console.ReadLine());
        bool check5 = (a % 5 == 0);
        bool check7 = (a % 7 == 0);
        if (check5 == true && check7 == true)
        {
            Console.WriteLine("The number can be divided by 5 and 7 at the same time.");
        }
        else
        {
            Console.WriteLine("The number cannot be divided by 5 and 7 at the same time.");
        }
    }
}

