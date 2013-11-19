//Write a program that finds the greatest of given 5 variables.


using System;

class GreatestNumber
{
    static void Main()
    {
        Console.Title = "Greatest of five numbers";
        int first;
        int second;
        int third;
        int fourth;
        int fifth;
        Console.WriteLine("Input five integers.");
        while (true)
        {
            Console.Write("1: ");
            string check = Console.ReadLine();
            bool firstCheck = int.TryParse(check, out first);

            Console.Write("2: ");
            check = Console.ReadLine();
            bool secondCheck = int.TryParse(check, out second);

            Console.Write("3: ");
            check = Console.ReadLine();
            bool thirdCheck = int.TryParse(check, out third);

            Console.Write("4: ");
            check = Console.ReadLine();
            bool fourthCheck = int.TryParse(check, out fourth);
            
            Console.Write("5: ");
            check = Console.ReadLine();
            bool fifthCheck = int.TryParse(check, out fifth);

            if ((firstCheck == true) && (secondCheck == true) && (thirdCheck == true) && (fourthCheck == true) && (fifthCheck == true))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid numbers, try again!");
            }
        }
        double biggest = first;
        if (biggest < second)
        {
            biggest = second;
        }
        if (biggest < third)
        {
            biggest = third;
        }
        if (biggest < fourth)
        {
            biggest = fourth;
        }
        if (biggest < fifth)
        {
            biggest = fifth;
        }
        Console.WriteLine("The greatest variable is: {0}", biggest);
    }
}