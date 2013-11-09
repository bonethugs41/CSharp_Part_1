//Declare two string variables and assign them with “Hello” and “World”.
//Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval).
//Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).



using System;

class Strings
{
    static void Main(string[] args)
    {
        string firstword = "Hello";
        string secondword = "World";
        Console.WriteLine("This is object:");
        object hwobject = string.Concat(firstword, " ", secondword, "!");
        Console.WriteLine(hwobject);
        Console.WriteLine();
        Console.WriteLine("This is string:");
        string hwstring = hwobject.ToString();
        Console.WriteLine(hwstring);
    }
}