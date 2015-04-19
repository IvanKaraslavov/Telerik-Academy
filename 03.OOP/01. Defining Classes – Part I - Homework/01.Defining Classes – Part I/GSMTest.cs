using System;

//Write a class GSMTest to test the GSM class:
//Create an array of few instances of the GSM class.
//Display the information about the GSMs in the array.
//Display the information about the static property IPhone4S.

class GSMTest
{
    static void Main()
    {
        GSM[] phones = new GSM[3];
        GSM phone1 = new GSM("Desire X", "HTC One Mini", "HTC Store", 499.99M);
        phones[0] = phone1;
        GSM phone2 = new GSM("Lumia 810", "Nokia");
        phone2.Price = 499.99M;
        phone2.Owner = "OVI Store";
        phone2.battery.Type = BatteryType.Li_Ion;
        phones[1] = phone2;
        GSM phone3 = GSM.iPhone;
        phones[2] = phone3;
        foreach (var phone in phones)
        {
            Console.WriteLine(phone);
        }

        // Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
        //Create an instance of the GSM class.
        //Add few calls.
        //Display the information about the calls.
        //Assuming that the price per minute is 0.37 calculate and print the total price of the calls in 
        //the history.
        //Remove the longest call from the history and calculate the total price again.
        //Finally clear the call history and print it.

        phone1.AddCall(DateTime.Now, "0897789987", 230);
        phone1.AddCall(DateTime.Now, "0897789987", 540);
        phone1.ShowCallHistory();
        phone1.CalcPrice(0.37M);
        phone1.RemoveLongestCall();
        phone1.CalcPrice(0.37M);
        phone1.ClearHistory();
    }
}

