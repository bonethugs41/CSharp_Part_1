//Declare five variables choosing for each of them the most appropriate
//of the types byte, sbyte, short, ushort, int, uint, long, ulong
//to represent the following values: 52130, -115, 4825932, 97, -10000.


using System;

class IntegerTypes
{
    static void Main()
    {
        Console.Title = "Signed and Unsigned";
        byte a = 97;
        sbyte b = -117;
        short c = -10000;
        ushort d = 52130;
        int e = 4825932;
        Console.WriteLine("This is byte: {0}, \nThis is sbyte: {1}, \nThis is short: {2}, \nThis is ushort: {3}, \nThis is int: {4}", a, b, c, d, e);
    }
}

