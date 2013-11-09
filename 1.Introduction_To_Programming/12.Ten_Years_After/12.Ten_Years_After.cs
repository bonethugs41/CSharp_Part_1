//Write a program to read your age from the console and print how old you will be after 10 years.


using System;

class AgePlusTen
{
    static void Main()
    {
        Console.Title = "How old you will be after ten years?";
        Console.WriteLine("How old are you now?");
        string line = Console.ReadLine();
        int value;
        int.TryParse(line, out value);
        Console.Write("In ten years you will be: ");
        Console.WriteLine(value + 10);
    }
}