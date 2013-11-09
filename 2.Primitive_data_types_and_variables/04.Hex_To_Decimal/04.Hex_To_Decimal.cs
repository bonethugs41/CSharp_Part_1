//Declare an integer variable and assign it with the value 254 in hexadecimal format.
//Use Windows Calculator to find its hexadecimal representation.


using System;

class HexToDec
{
    static void Main()
    {
        Console.Title = "Hex to Decimal";
        string hexValue = "FE";
        int decValue = Convert.ToInt32(hexValue, 16);
        Console.WriteLine("{0}", decValue);
    }
}