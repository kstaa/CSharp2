using System;
using TimeNamespace;

public class UsingTime
{
	public static void Main()
	{
		Time myTime = new Time();
		Time yourTime = new Time();
		int hr, min, sec;
		String stHr, stMin, stSec;


        //Get User's Input
		Console.Out.Write("Please enter hour (0 - 23): ");
   		stHr = Console.ReadLine();
		hr = Convert.ToInt32(stHr);


		Console.Out.Write("Please enter minute (0 - 59): ");
   		stMin = Console.ReadLine();
		min = Convert.ToInt32(stMin);

		Console.Out.Write("Please enter second (0 - 59): ");
   		stSec = Console.ReadLine();
		sec = Convert.ToInt32(stSec);

		myTime.SetHour(hr);
		myTime.SetMinute(min);
		myTime.SetSecond(sec);

        //Display entered time in Civilian format 
        Console.Out.WriteLine("The user's entered time: ");
		myTime.DisplayCivilian();

        //Add 1 second to the entered time and display in Civilian format
        Console.Out.WriteLine("Add 1 second to the entered time: ");
		myTime.AddSecond();

		myTime.DisplayCivilian();

        //Display current system time in Military format        
        Console.Out.WriteLine("Current System Time: ");
		yourTime.DisplayMilitary();
	}
}