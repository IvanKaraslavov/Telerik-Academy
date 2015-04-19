using System;

    class PrintCompanyInformation
    {
        static void Main()
        {
                //A company has name, address, phone number, fax number, web site and manager. 
                //The manager has first name, last name, age and a phone number.
                //Write a program that reads the information about a company and its manager and prints it back on the console.

            Console.WriteLine("Enter Company Name:");
            string companyName = Console.ReadLine();
            Console.WriteLine("Enter Company Address:");
            string companyAddress = Console.ReadLine();
            Console.WriteLine("Enter Phone Number:");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Fax Number:");
            byte faxNumber = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter Web site:");
            string webSite = Console.ReadLine();
            Console.WriteLine("Enter Manager's first name:");
            string managerFirstName = Console.ReadLine();
            Console.WriteLine("Enter Manager's last name:");
            string managerLastName = Console.ReadLine();
            Console.WriteLine("Enter Manager's age:");
            byte managerAge = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter Manager's phone:");
            string managerPhone = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("{0} \nAdress: {1} \nTel. {2} \nFax: {3} \nManager: {4} {5} (age: {6}, tel. {7})", 
                companyName, companyAddress, phoneNumber, faxNumber, managerFirstName, managerLastName, managerAge, managerPhone );
        }
    }
