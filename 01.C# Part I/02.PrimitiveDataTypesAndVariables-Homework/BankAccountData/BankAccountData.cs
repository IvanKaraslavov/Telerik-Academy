using System;

            //Declare the variables needed to keep the information for a single bank account using 
            //the appropriate data types and descriptive names.
    class BankAccountData
    {
        static void Main()
        {
            Console.WriteLine("Write your first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Write your last name:");
            string lastName = Console.ReadLine();
            uint bankBalance = 33324;
            string bankName = "UniCredit Bulbank";
            string IBAN = "BG80 BNBG 9661 1020 3456 78 ";
            ulong creditCardNumber1 = 5555555555554444;
            ulong creditCardNumber2 = 5105105105105100;
            ulong creditCardNumber3 = 4012888888881881;
            Console.Clear();
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("First Name: {0}", firstName);
            Console.WriteLine("Last Name: {0}", lastName);
            Console.WriteLine("Available amount of money: {0}", bankBalance);
            Console.WriteLine("Bank Name: {0}", bankName);
            Console.WriteLine("IBAN: {0}", IBAN);
            Console.WriteLine("Credit Card Number: {0}", creditCardNumber1);
            Console.WriteLine("Credit Card Number: {0}", creditCardNumber2);
            Console.WriteLine("Credit Card Number: {0}", creditCardNumber3);
            Console.WriteLine(new string('-', 30));
        }
    }

