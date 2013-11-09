//Which of the following values can be assigned to a variable of type
//float and which to a variable of type double:
//34.567839023, 12.345, 8923.1234857, 3456.091?


using System;

class FloatDouble
{
    static void Main()
    {
        Console.Title = "Float and Double";
        float a = 12.345f;
        float b = 3456.091f;
        double c = 34.567839023;
        double d = 8923.1234857;
        Console.WriteLine("float: \n{0} \n{1} \ndouble: \n{2} \n{3}", a, b, c, d);
    }
}