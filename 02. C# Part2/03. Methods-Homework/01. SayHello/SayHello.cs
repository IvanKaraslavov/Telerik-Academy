using System;

          //Write a method that asks the user for his name and prints “Hello, <name>”
          //Write a program to test this method.
 public class SayHello
{
    public static void Main()
    {
        Console.WriteLine("Please write your name: ");
        string inputName = Console.ReadLine();
        WriteName(inputName);
        Console.WriteLine(WriteName(inputName));
    }

    public static string WriteName(string inputName)
    {
        return string.Format("Hello, {0}!", inputName);
    }
}

