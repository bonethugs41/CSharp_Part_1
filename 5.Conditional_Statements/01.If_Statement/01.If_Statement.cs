//Write an if statement that examines two integer variables and exchanges their values
//if the first one is greater than the second one.



using System;

class ValuesExchange
{
    static void Main()
    {
        Console.Title = "Value exchange";
        Console.WriteLine("Please input two numbers to compare.");
        int a;
        int b;
        while (true)
        {
            Console.Write("a=");
            string value = Console.ReadLine();
            bool aResult = int.TryParse(value, out a);
            Console.Write("b=");
            value = Console.ReadLine();
            bool bResult = int.TryParse(value, out b);
            if ((aResult == true) && (bResult == true))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid numbers.Try again:");
            }
        }
        
        if (a > b)
        {
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("a is greater than b, so they will exchange their values:\na={0} \nb={1}", a, b);
        }
        else
        {
            Console.WriteLine("b is greater or equal of a, and they will keep their values. \na={0} \nb={1}", a, b);
        }
    }
}