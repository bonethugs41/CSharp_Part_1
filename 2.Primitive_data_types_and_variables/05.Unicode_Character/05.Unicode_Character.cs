//Declare a character variable and assign it with the symbol that has Unicode code 72.
//Hint: first use the Windows Calculator to find the hexadecimal representation of 72.



using System;

class UnicodeCharacter
{
    static void Main()
    {
        Console.Title = "Unicode character";
        char u72 = '\u0048';
        Console.WriteLine("The symbol that has unicode 72 is: {0}", u72);
        char symbol = 'H';
        Console.WriteLine("The unicode of {0} is: {1}", symbol, (int)symbol);
    }
}
