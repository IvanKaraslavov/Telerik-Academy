namespace Shapes
{
    using System;

    public class Circle : Shape
    {
        private const double PI = 3.14;

        public Circle(double parameter)
            :base(parameter)
        { }

        public override double CalculateSurface()
        {
            return PI * Math.Pow(this.Width / 2.0, 2);
        }
    }
}
