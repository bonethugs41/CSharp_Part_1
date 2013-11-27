//Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). The cards should be printed with their English names. Use nested for loops and switch-case.



using System;

class CardDeck
{
    static void Main()
    {
        Console.Title = "Deck of playing cards";
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= 13; j++)
            {
                switch (j)
                {
                    case 1:
                        Console.Write("Ace");
                        break;
                    case 2:
                        Console.Write("Two");
                        break;
                    case 3:
                        Console.Write("Three");
                        break;
                    case 4:
                        Console.Write("Four");
                        break;
                    case 5:
                        Console.Write("Five");
                        break;
                    case 6:
                        Console.Write("Six");
                        break;
                    case 7:
                        Console.Write("Seven");
                        break;
                    case 8:
                        Console.Write("Eight");
                        break;
                    case 9:
                        Console.Write("Nine");
                        break;
                    case 10:
                        Console.Write("Ten");
                        break;
                    case 11:
                        Console.Write("Jack");
                        break;
                    case 12:
                        Console.Write("Queen");
                        break;
                    case 13:
                        Console.Write("King");
                        break;
                }
                switch (i)
                {
                    case 1:
                        Console.WriteLine(" of Spades");
                        break;
                    case 2:
                        Console.WriteLine(" of Hearts");
                        break;
                    case 3:
                        Console.WriteLine(" of Clubs");
                        break;
                    case 4:
                        Console.WriteLine(" of Diamonds");
                        break;
                }
            }

        }
    }
}