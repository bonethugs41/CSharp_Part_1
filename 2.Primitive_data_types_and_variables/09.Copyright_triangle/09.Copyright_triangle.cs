//Write a program that prints an isosceles triangle of 9 copyright symbols ©.
//Use Windows Character Map to find the Unicode code of the © symbol.


using System;
using System.Text;


class Triangle
{
    static void Main()
    {
        Console.Title = "Copyright Triangle";
        char copy = '\u00A9';
        Console.OutputEncoding = Encoding.UTF8;               
        Console.WriteLine("  {0}", copy);
        Console.WriteLine(" {0}{0}{0}", copy);
        Console.WriteLine("{0}{0}{0}{0}{0}", copy);
    }
}