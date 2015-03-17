namespace Shapes
{
    using System;

    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape( double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public Shape(double parameter)
        {
            this.Width = parameter;
            this.Height = parameter;
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentNullException("Enter the width");
                }
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Enter a positive width");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentNullException("Enter the width");
                }
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Enter a positive width");
                }
                this.height = value;
            }
        }

        public virtual double CalculateSurface()
        {
            return 0.0;
        }
    }
}
