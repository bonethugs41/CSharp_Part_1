//Write a program that, depending on the user's choice inputs int, double or string variable.
//If the variable is integer or double, increases it with 1. If the variable is string,
//appends "*" at its end. The program must show the value of that variable as a console output.
//Use switch statement.



using System;

class UserInput
{
    static void Main()
    {
        Console.Title = "User input ";
        Console.Write("Press: (I) for integer, (D) for double or (S) for string.");
        string i = "i";
        string d = "d";
        string s = "s";
        string userInput;
        while (true)
        {
            userInput = Console.ReadLine();
            if ((userInput.ToLower() == i) || (userInput.ToLower() == d) || (userInput.ToLower() == s))
            {
                break;
            }
            else
            {
                Console.WriteLine("Please, choose I, D or S.");
            }
        }
        switch (userInput)
        {
            case "i":
                {
                    int @int;
                    while (true)
                    {
                        Console.Write("Input integer:");
                        string check = Console.ReadLine();
                        bool intCheck = int.TryParse(check, out @int);
                        if (intCheck == true)
                        {
                            Console.WriteLine(@int + 1);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid number, try again.");
                        }
                    }
                    break;
                }
            case "s":
                {
                    Console.WriteLine("Write a string:");
                    string @string = Console.ReadLine();
                    Console.WriteLine(@string + "*");
                    break;
                }
            case "d":
                {
                    double @double;
                    while (true)
                    {
                        Console.Write("Input double:");
                        string check = Console.ReadLine();
                        bool doubleCheck = double.TryParse(check, out @double);
                        if (doubleCheck == true)
                        {
                            Console.WriteLine(@double + 1);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid number, try again.");
                        }
                    }
                    break;
                }
        }
    }

}