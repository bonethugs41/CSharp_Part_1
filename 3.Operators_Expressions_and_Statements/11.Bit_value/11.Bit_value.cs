//Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2  value=1.


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Check bit at any position";
        Console.WriteLine("Input any number:");
        int inputNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the number of the bit you want to check:");
        int bitPosition = int.Parse(Console.ReadLine());
        int mask = 1 << bitPosition;
        int numberAndMask = inputNumber & mask;
        int bit = numberAndMask >> bitPosition;

        string numberBinary = Convert.ToString(inputNumber, 2);
        Console.WriteLine("The entered number has the following binary representation: {0}", numberBinary);

        Console.WriteLine("The {0} bit of the number is: {1}", bitPosition, bit);
    }
}
