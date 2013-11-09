//Create a console application that prints the current date and time.


using System;

class TimeAndDate
{
    static void Main(string[] args)
    {
        Console.Title = "Time & Date";
        Console.WriteLine(DateTime.Now);
        Console.ReadLine();
    }
}
