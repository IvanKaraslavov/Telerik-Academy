using System;

//Declare two string variables and assign them with Hello and World.
//Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
//Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).

class StringAndObjects
{
    static void Main()
    {
        string nameHello = "Hello";
        string nameWorld = "World";
        object nameHelloWorld = nameHello + " " + nameWorld;
        Console.WriteLine(nameHelloWorld);
        string castedString = (string)nameHelloWorld;
        Console.WriteLine(castedString);
    }
}
