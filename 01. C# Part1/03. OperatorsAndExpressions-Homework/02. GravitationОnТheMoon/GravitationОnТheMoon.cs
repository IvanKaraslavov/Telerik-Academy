using System;

    class GravitationОnТheMoon
    {
        static void Main()
        {
            //Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

            Console.WriteLine("Enter your weight:");
            double weightOnTheEarth = double.Parse(Console.ReadLine());
            double weightOnTheMoon = 0.17 * weightOnTheEarth;
            Console.WriteLine("Your weight on the Moon is: {0}", weightOnTheMoon);
        }
    }

