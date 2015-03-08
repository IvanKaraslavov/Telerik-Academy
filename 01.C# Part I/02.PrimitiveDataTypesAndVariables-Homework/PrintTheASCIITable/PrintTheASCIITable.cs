using System;
using System.Text;
            //Find online more information about ASCII (American Standard Code for Information Interchange) and write 
            //a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).
    class PrintTheASCIITable
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.BufferHeight = 256;
            
            for (char i = (char)000; i <= (char)255; i++)
            {

                Console.WriteLine(i);
                
                
            }
        }
    }

