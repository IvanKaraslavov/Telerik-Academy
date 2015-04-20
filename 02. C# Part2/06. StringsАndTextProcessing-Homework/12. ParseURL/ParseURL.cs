using System;
using System.Linq;

//Write a program that parses an URL address given in the format: [protocol]:
//[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.

    class ParseURL
    {
        static void Main()
        {
            Console.WriteLine("Please enter an URL: ");
            string input = Console.ReadLine();
            int protocolEnd = input.IndexOf(':');
            string protocol = input.Substring(0, protocolEnd);
            int serverEnd = input.IndexOf('/', 8);
            int serverStart = input.IndexOf('/');
            string server = input.Substring(serverStart + 2, serverEnd - serverStart - 2);
            string resource = input.Substring(serverEnd);
            Console.WriteLine("[protocol] = {0}", protocol);
            Console.WriteLine("[server] = {0}", server);
            Console.WriteLine("[resource] = {0}", resource);
        }
    }

