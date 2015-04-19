using System;

          //Which of the following values can be assigned to a variable of type float and which to a variable of type double: 
          //34.567839023, 12.345, 8923.1234857, 3456.091?

class FloatOrDouble
{
    static void Main()
    {
        double doubleNumber1 = 34.56783902d;
        float floatNumber1 = 12.345f;
        double doubleNumber2 = 8923.1234857d;
        float floatNumber2 = 3456.091f;
        Console.WriteLine(doubleNumber1);
        Console.WriteLine(floatNumber1);
        Console.WriteLine(doubleNumber2);
        Console.WriteLine(floatNumber2);
    }
}
