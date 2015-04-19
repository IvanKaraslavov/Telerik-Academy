using System;

//Create a class Call to hold a call performed through a GSM. It should contain date, 
//time, dialed phone number and duration (in seconds).

public class Call
{
    private DateTime time;
    private string dialedNumber;
    private uint duration;

    public Call(DateTime time, string dialedNumber, uint duration)
    {
        this.time = time;
        this.dialedNumber = dialedNumber;
        this.duration = duration;
    }

    public DateTime Time
    {
        get
        {
            return this.time;
        }
        set
        {
            this.time = value;
        }
    }
    public string DialedNumber
    {
        get
        {
            return this.dialedNumber;
        }
        set
        {
            if (value.Length >= 5)
            {
                this.dialedNumber = value;
            }
        }
    }

    public uint Duration
    {
        get
        {
            return this.duration;
        }
        set
        {
            if (value > 0 && value < uint.MaxValue)
            {
                this.duration = value;
            }
        }
    }
}

