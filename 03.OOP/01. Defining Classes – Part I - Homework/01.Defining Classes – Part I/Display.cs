//Define a class that holds information about display characteristics (size and number of colors).
using System;
public class Display
{
    private double size;
    private int numberOfColours;

    //Define several constructors for the defined classes that take different sets 
    //of arguments (the full information for the class or part of it). 

    public Display()
        : this(0, 0)
    {
    }

    public Display(double size)
        : this(size, 0)
    {
    }

    public Display(double size, int numberOfColours)
    {
        this.numberOfColours = numberOfColours;
        this.size = size;
    }

    public double Size
    {
        get
        {
            return this.size;
        }
        set
        {
            if ((value > 0 && value < double.MaxValue) || value == null)
            {
                this.size = value;
            }
            else
            {
                throw new ArgumentException("Wrong input");
            }
        }
    }

    public int NumberOfColours
    {
        get
        {
            return this.numberOfColours;
        }
        set
        {
            if ((value > 0 && value < double.MaxValue) || value == null)
            {
                this.numberOfColours = value;
            }
            else
            {
                throw new ArgumentException("Wrong input");
            }
        }
    }

}

