namespace Space3D
{

    //Write a static class with a static method to calculate the distance between two points
    //in the 3D space

    using System;

    public static class CalculateDistance
    {
        public static double Calculate(Point3D firstPoint, Point3D secondPoint)
        {
            return Math.Sqrt(Math.Pow(firstPoint.X - secondPoint.X, 2)
                + Math.Pow(firstPoint.Y - secondPoint.Y, 2) 
                + Math.Pow(firstPoint.Z - secondPoint.Z, 2));
        }
    }
}
