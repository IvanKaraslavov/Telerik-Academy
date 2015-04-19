//Define a class that holds information about battery characteristics (model, hours idle and
//hours talk). 

//Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field for the batteries

using System;
public enum BatteryType
{
    Li_Poly,
    Li_Ion,
    NiCd,
    NiMH
}

public class Battery
{
    private string model;
    private BatteryType type;
    private int hoursIdle;
    private int hoursTalk;

    //Define several constructors for the defined classes that take different sets 
    //of arguments (the full information for the class or part of it). 

    public Battery()
    {

    }

    public Battery(string model, int hoursIdle)
    {
        this.model = model;
        this.hoursIdle = hoursIdle;
    }

    public Battery(string model, int hoursIdle, int hoursTalk, BatteryType type)
    {
        this.model = model;
        this.hoursIdle = hoursIdle;
        this.hoursTalk = hoursTalk;
        this.type = type;
    }

    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            if (value.Length > 0 || value == null)
            {
                this.model = value;
            }
            else
            {
                throw new ArgumentException("Wrong input");
            }
        }
    }

    public int HoursIdle
    {
        get
        {
            return this.hoursIdle;
        }
        set
        {
            if ((value > 0 && value < byte.MaxValue) || value == null)
            {
                this.hoursIdle = value;
            }
            else
            {
                throw new ArgumentException("Wrong input");
            }
        }
    }

    public int HoursTalk
    {
        get
        {
            return this.hoursTalk;
        }
        set
        {
            if ((value > 0 && value < byte.MaxValue) || value == null)
            {
                this.hoursTalk = value;
            }
            else
            {
                throw new ArgumentException("Wrong input");
            }
        }
    }

    public BatteryType Type
    {
        get
        {
            return this.type;
        }
        set
        {
            this.type = value;
        }
    }


}

