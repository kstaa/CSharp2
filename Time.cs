
//Run this class as a netmodule.  Needs to be compiled before UsingTime.cs
namespace TimeNamespace
{
   using System;

   class Time
   {
	private int hour;
	private int minute;
	private int second;
    
    //Set up current time when there is no parameter are passed
	public Time()
	{
		DateTime current = DateTime.Now;
		hour = current.Hour;
		minute = current.Minute;
		second = current.Second;
	}

    //Set up the user entered time
	public Time(int h, int m, int s)
	{
		if (h < 0 || h > 23)
		   	hour = 0;
		else 
		    	hour = h;
	
		if (m < 0 || m > 59)
		   	minute = 0;
		else 
		    	minute = m;

		if (s < 0 || s > 59)
		   	second = 0;
		else 
		    	second = s;

	}

    //Setting hour method
	public void SetHour(int h)
	{
		if (h <  0 || h > 23)
		{
			Console.Out.Write("Invalid hour.");
			Console.Out.WriteLine(" Setting hour to 0.");
			hour = 0;
		}
		else
			hour = h;
	}

	
	public int GetHour()
	{
		return hour;
	}

    //Setting minute method
	public void SetMinute(int m)
	{
		if ( m < 0 || m > 59)
		{
			Console.Out.Write("Invalid minute.");
			Console.Out.WriteLine(" Setting minute to 0.");
			minute = 0;
		}
		else
			minute = m;
		
	}

	public int GetMinute()
	{
		return minute;
	}

    //Setting second method
	public void SetSecond(int s)
	{
		if ( s < 0 || s > 59)
		{
			Console.Out.Write("Invalid second.");
			Console.Out.WriteLine(" Setting second to 0.");
			second = 0;
		}
		else
			second = s;
		
	}


	public int GetSecond()
	{
		return second;
	}
	
    //This method should add 1 to the second variable stored in the current object.
    //If the second becomes 60, set the second to 0 and add the minute variable by one.
	public void AddSecond()
	{
		second++;
		if (second == 60)
		{
			second = 0;
			AddMinute();
		}
	}

    //This method should add 1 to the minute variable stored in the current object.
    //If the minute becomes 60, set the minute to 0 and add the hour variable by one.
	public void AddMinute()
	{
		minute++;
		if (minute == 60)
		{
			minute = 0;
			AddHour();
		}
	}

    //This method should add 1 to the hour variable stored in the current object.
    //If the hour becomes 24, set the hour to 0.
	public void AddHour()
	{
		hour++;
		if (hour == 24)
		{
			hour = 0;
		}
	}


    //Display Civilian Time format
	public void DisplayCivilian()
	{
		Console.Out.Write("The time is ");
		if (hour <= 12)
		{
			Console.Out.Write(hour + ":");
            Console.Out.WriteLine(minute + ":" + second + " (Civilian Time)");
		}
		else
		{
			Console.Out.Write(hour - 12 + ":");
			Console.Out.WriteLine(minute + ":" + second + " (Civilian Time)");
		}
	}
	
    //Display Military Time format
    public void DisplayMilitary()
	{
		Console.Out.Write("The time is ");
	    Console.Out.Write(hour + ":");
		Console.Out.WriteLine(minute + ":" + second + " (Military Time)");
		
	}

    //This method compare the time stored in the current object to the time stored in the Time object t that is passed into the method.
	public bool Equals(Time t)
	{
		if ( t.GetHour() == hour &&
		     t.GetMinute() == minute &&
		     t.GetSecond() == second)
		   return true;
		else
		   return false;
	}
	

   }	

}