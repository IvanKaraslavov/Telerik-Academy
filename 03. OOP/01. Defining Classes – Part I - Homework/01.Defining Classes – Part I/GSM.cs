using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Define a class that holds information about a mobile phone device:
//model, manufacturer, price, owner, battery characteristics and display characteristics.


public class GSM
{
    public Battery battery = new Battery();
    public Display display = new Display();

    private string model;
    private string manufacturer;
    private string owner;
    private decimal price;
    private List<Call> callHistory = new List<Call>();

    //Add a static field and a property IPhone4S in the GSM class to hold
    //the information about iPhone 4S.


    static private GSM Iphone4S = new GSM("Iphone 4S", "Apple", "iStore", 999.99M);

    //Define several constructors for the defined classes that take different sets 
    //of arguments (the full information for the class or part of it). 

    public GSM(string model, string manufacturer)
        : this(model, manufacturer, null, 0)
    {
    }
    public GSM(string model, string manufacturer, string owner)
        : this(model, manufacturer, owner, 0)
    {
    }
    public GSM(string model, string manufacturer, string owner, decimal price)
    {
        this.model = model;
        this.manufacturer = manufacturer;
        this.price = price;
        this.owner = owner;
    }
    public GSM(string model, string manufacturer, string owner, decimal price, Battery battery, Display display)
        : this(model, manufacturer, owner, price)
    {
        this.battery = battery;
        this.display = display;
    }

    //Add a property CallHistory in the GSM class to hold a list of the performed calls. 
    //Try to use the system class List<Call>.

    public List<Call> CallHistory
    {
        get
        {
            return callHistory;
        }
    }

    public static GSM iPhone
    {
        get { return Iphone4S; }
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

    public string Manufacturer
    {
        get
        {
            return this.manufacturer;
        }
        set
        {
            if (value.Length > 0 || value == null)
            {
                this.manufacturer = value;
            }
            else
            {
                throw new ArgumentException("Wrong input");
            }
        }
    }

    public string Owner
    {
        get
        {
            return this.owner;
        }
        set
        {
            if (value.Length > 0 || value == null)
            {
                this.owner = value;
            }
            else
            {
                throw new ArgumentException("Wrong input");
            }
        }
    }

    public decimal Price
    {
        get
        {
            return this.price;
        }
        set
        {
            if ((value > 0 && value < decimal.MaxValue) || value == null)
            {
                this.price = value;
            }
            else
            {
                throw new ArgumentException("Wrong input");
            }
        }
    }

    //Add methods in the GSM class for adding and deleting calls from the calls history.
    //Add a method to clear the call history.


    public void AddCall(DateTime time, string number, uint duration)
    {
        Call call = new Call(time, number, duration);
        callHistory.Add(call);
    }

    public void ClearHistory()
    {
        callHistory.Clear();
    }

    public void ShowCallHistory()
    {
        foreach (var call in this.callHistory)
        {
            Console.WriteLine("{0}\n{1} - {2}seconds", call.DialedNumber, call.Time, call.Duration);
        }
    }

    public void RemoveLongestCall()
    {
        uint longestCall = callHistory.Max(x => x.Duration);
        for (int i = 0; i < callHistory.Count; i++)
        {
            if (callHistory[i].Duration == longestCall)
            {
                DeleteCall(i);
            }
        }
    }

    //Add a method that calculates the total price of the calls in the call history.
    //Assume the price per minute is fixed and is provided as a parameter.


    public decimal CalcPrice(decimal price)
    {
        decimal toPay = 0;
        foreach (var call in callHistory)
        {
            toPay += (call.Duration / 60) * price;
        }
        Console.WriteLine("You have to pay: {0:C}", toPay);
        return toPay;

    }
    public void DeleteCall(int index = 0)
    {
        callHistory.RemoveAt(index);
    }

    //Add a method in the GSM class for displaying all information about it. 
    //Try to override ToString().


    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendFormat("Model: {0} \t", this.model);
        sb.AppendFormat("Manufacturer: {0}\n", this.manufacturer);
        sb.AppendFormat("Owner: {0} \t", this.owner ?? "Unknown");
        sb.AppendFormat("Price: {0:C} \n", this.price);
        sb.AppendFormat("Battery Model: {0}\t", this.battery.Model ?? "Unknown");
        sb.AppendFormat("Battery Type: {0}\n", this.battery.Type);
        sb.AppendFormat("Battery Hours Idle: {0}\t", this.battery.HoursIdle);
        sb.AppendFormat("Battery Hours Talk: {0}\n", this.battery.HoursTalk);
        sb.AppendFormat("Display Size: {0} inches\t", this.display.Size);
        sb.AppendFormat("Display Number of Colors: {0} millions\n", this.display.NumberOfColours);
        return sb.ToString();
    }
}

