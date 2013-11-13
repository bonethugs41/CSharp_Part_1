//Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.




using System;

class ThirdBit
{
    static void Main(string[] args)
    {
        Console.Title = "3rd bit of number";
        Console.WriteLine("Input any number:");
        int inputNumber = int.Parse(Console.ReadLine());
        int bitPosition = 3;
        int mask = 1 << bitPosition;
        int numberAndMask = inputNumber & mask;
        int bit = numberAndMask >> bitPosition;

        string numberBinary = Convert.ToString(inputNumber, 2);
        Console.WriteLine("The entered number has the following binary representation: {0}", numberBinary);      //This helps me to find if the program works properly.

        Console.WriteLine("The third bit of the number is: {0}", bit);
    }
}