//Create a program that assigns null values to an integer and to double variables.
//Try to print them on the console, try to add some values or the null literal to them and see the result.



using System;

class NullValues
{
    static void Main()
    {
        int? intNumber = null;
        double? doubleNumber = null;
        Console.WriteLine("intNumber = >>{0}<<", intNumber);
        Console.WriteLine("doubleNumber = >>{0}<<", doubleNumber);
    }
}