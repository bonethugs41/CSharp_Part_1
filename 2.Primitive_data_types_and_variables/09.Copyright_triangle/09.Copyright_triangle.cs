//Write a program that prints an isosceles triangle of 9 copyright symbols ©.
//Use Windows Character Map to find the Unicode code of the © symbol.


using System;

class Triangle
{
    static void Main()
    {
        Console.Title = "Copyright Triangle";
        char copy = '\u00a9';
        Console.WriteLine("  {0}", copy);
        Console.WriteLine(" {0}{0}{0}", copy);
        Console.WriteLine("{0}{0}{0}{0}{0}", copy);
    }
}