﻿//Declare two string variables and assign them with following value:
//The "use" of quotations causes difficulties.
//Do the above in two different ways: with and without using quoted strings.



using System;

class Quotes
{
    static void Main()
    {
        string firstway = "The \"use\" of quotations causes difficulties.";
        string secondway = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(firstway);
        Console.WriteLine(secondway);

    }
}