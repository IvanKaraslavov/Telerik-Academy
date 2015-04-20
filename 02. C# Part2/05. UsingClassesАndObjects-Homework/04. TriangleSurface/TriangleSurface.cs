using System;

//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it;
//Three sides;
//Two sides and an angle between them;
//Use System.Math.

    class TriangleSurface
    {
        static void Main()
        {
            Console.WriteLine("This programm calculates the surface of a triangle by given:");
            Console.WriteLine("1.Side and an altitude to it");
            Console.WriteLine("2.Three sides");
            Console.WriteLine("3.Two sides and an angle between them");
            Console.WriteLine("Please enter a number (1,2 or 3)");
            byte choice = byte.Parse(Console.ReadLine());
            if (choice == 1)
            {
                CalcSurfaceBySideAndAltitude();
            }
            else if (choice == 2)
            {
                CalcSurfaceByThreeSides();
            }
            else if (choice == 3)
            {
                CalcSurfaceByTwoSidesAndAngle();
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }

        private static void CalcSurfaceByTwoSidesAndAngle()
        {
            Console.WriteLine("Please enter the first side: ");
            decimal firstSide = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second side: ");
            decimal secondSide = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the angle between the two sides in gradus: ");
            decimal angle = decimal.Parse(Console.ReadLine());
            decimal sinusAngle = (decimal)Math.Sin((double)angle);
            decimal surface = (firstSide * secondSide * sinusAngle) / 2;
            Console.WriteLine("The surface: {0:F3} cm^2", surface);

        }

        private static void CalcSurfaceByThreeSides()
        {
            Console.WriteLine("Please enter the first side: ");
            decimal firstSide = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second side: ");
            decimal secondSide = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the third side: ");
            decimal thirdSide = decimal.Parse(Console.ReadLine());
            decimal poluperimetar = (firstSide + secondSide + thirdSide) / 2;
            decimal surface = (decimal)Math.Sqrt((double)( poluperimetar * (poluperimetar - firstSide) *
                                      (poluperimetar - secondSide) * (poluperimetar - thirdSide)));
            Console.WriteLine("The surface: {0} cm^2", surface);
        }

        private static void CalcSurfaceBySideAndAltitude()
        {
            Console.WriteLine("Please enter the side: ");
            decimal side = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the altitude: ");
            decimal altitude = decimal.Parse(Console.ReadLine());
            decimal surface = (side * altitude) / 2;
            Console.WriteLine("The surface: {0} cm^2", surface);
        }
    }

