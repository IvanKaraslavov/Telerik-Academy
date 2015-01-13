using System;

        //Declare five variables choosing for each of them the most appropriate of the types 
       //byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 
      //52130, -115, 4825932, 97, -10000.
     //Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
class DeclareVariables
{
    static void Main()
    {
        ushort ushortValuable = 52130;
        Console.WriteLine(ushortValuable);
        sbyte sbyteValuable = -115;
        Console.WriteLine(sbyteValuable);
        int intValuable = 4825325;
        Console.WriteLine(intValuable);
        byte byteValuable = 97;
        Console.WriteLine(byteValuable);
        short shortValuable = -1000;
        Console.WriteLine(shortValuable);
    }
}

