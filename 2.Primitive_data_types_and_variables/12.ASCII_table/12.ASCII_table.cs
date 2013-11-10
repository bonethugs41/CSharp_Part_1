//Find online more information about ASCII (American Standard Code for Information Interchange)
//and write a program that prints the entire ASCII table of characters on the console.



using System;

class ASCII_Table
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 127; i++)
        {
            Console.Title = "ASCII Table";
            char letter = (char)i;
            Console.WriteLine("To number {0} corresponds: {1}", i, letter);
        }
    }
}