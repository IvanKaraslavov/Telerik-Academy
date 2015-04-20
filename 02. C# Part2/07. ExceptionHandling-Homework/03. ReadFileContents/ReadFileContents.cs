﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
//reads its contents and prints it on the console.
//Find in MSDN how to use System.IO.File.ReadAllText(…).
//Be sure to catch all possible exceptions and print user-friendly error messages.

class ReadFileContents
{
    static void Main()
    {
        const string path = "C:\\WINDOWS\\win.ini";

        try
        {
            Console.WriteLine("> Trying to read file content...\n");

            using (StreamReader reader = new StreamReader(path))
            {
                Console.WriteLine(File.ReadAllText(path));
            }

            Console.WriteLine("> File's content was sucessfully read!\n");
        }
        catch (DriveNotFoundException dnfe)
        {
            PrintErrorMessage(dnfe);
        }
        catch (DirectoryNotFoundException dirnfe)
        {
            PrintErrorMessage(dirnfe);
        }
        catch (EndOfStreamException eose)
        {
            PrintErrorMessage(eose);
        }
        catch (FileNotFoundException fnfe)
        {
            PrintErrorMessage(fnfe);
        }
        catch (FileLoadException fle)
        {
            PrintErrorMessage(fle);
        }
        catch (PathTooLongException ptle)
        {
            PrintErrorMessage(ptle);
        }
        catch (UnauthorizedAccessException ua)
        {
            PrintErrorMessage(ua);
        }
    }

    static void PrintErrorMessage(Exception error)
    {
        Console.Error.WriteLine("Error! {0}\n", error.Message);
    }
}
    

