//Write a program that will prompt the user for their year number in school, 1 through 4.  Based on the response,
//your program should display their class rank as Freshman (1), Sophomore (2), Junior (3), Senior (4), or Error (any other number)
//After prompting the user for their year number, also ask them if they want the program to use a nested if structure or a switch structure

using System;

public class YearInSchool
{
    public static void Main()
    {
	int year, choice;
	String strYear, strChoice;

	//Get year number from the user
	Console.Out.Write("Please enter your year number in school (1 - 4): ");
  	strYear = Console.ReadLine();
	year = Convert.ToInt32(strYear);

	//Test the user input and prompt the user for the choice of nested if or a switch structure
	if (year < 1 || year > 4)
		Console.Out.WriteLine("Invalid year number");
	else
	{
		Console.Out.Write("\n\nWould you like the program to use an If (1) or a Switch (2)? ");
		strChoice = Console.ReadLine();
		choice = Convert.ToInt32(strChoice);

		if (choice == 1)
		Console.Out.WriteLine("\n\nUsing an If, you are a " + GetRankIf(year));
		
		else
		Console.Out.WriteLine("\n\nUsing a Switch, you are a " + GetRankSwitch(year));

		
	}	
    }


    public static String GetRankIf(int numYear)
    {
     	if (numYear == 1)
	   return "Freshman";
       	if (numYear == 2)
	   return "Sophomore";
	if (numYear == 3)
	   return "Junior";
	if (numYear == 4)
	   return "Senior";
	return "Error";
    }

    public static String GetRankSwitch(int numYear)
    {
	switch(numYear)
	{
	   case 1: return "Freshman";
      	   case 2: return "Sophomore";
           case 3: return "Junior";
    	   case 4: return "Senior";
	   default: return "Error";
	}
    }

}


	
