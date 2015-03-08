using System;

        //Declare the variables needed to keep the information for a single employee using appropriate primitive data types. 
        //Use descriptive names. Print the data at the console.

    class EmployeeData
    {
        static void Main()
        {
            Console.WriteLine("Write employee's first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Write employee's last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Write employee's age:");
            byte age = byte.Parse(Console.ReadLine());
            Console.WriteLine("Write employee's gender(ex. \"m\" or \"f\" :");
            char gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Write employee's personalID (example: 8306112507):");
            long personalID = long.Parse(Console.ReadLine());
            Console.WriteLine("Write employee's number:");
            int employeeNumber = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("First Name: {0}", firstName);
            Console.WriteLine("Last Name: {0}", lastName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Personal ID: {0}", personalID);
            Console.WriteLine("Employee Number: {0}", employeeNumber);
            Console.WriteLine(new string ('-', 30));

        }
    }

