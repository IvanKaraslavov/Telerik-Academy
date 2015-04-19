using System;

    class PrimeNumberCheck
    {
        static void Main()
        {
            //Write an expression that checks if given positive integer number n (n <= 100) 
            //is prime (i.e. it is divisible without remainder only to itself and 1).

            Console.WriteLine("Enter your number:");
            int n = int.Parse(Console.ReadLine());
            bool prime = false;
            if (n < 2 )
            {
                prime = false;
                Console.WriteLine(prime);
            }
            else if ( n == 2 || n == 3)
            {
                prime = true;
                Console.WriteLine(prime);
            }
            else
            {
                for (int i = 2; i <= (int)Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        prime = false;
                        break;
                    }
                    else
                    {
                        prime = true;
                        
                    }
                    
                }
                Console.WriteLine(prime);
            }
        }
    }

