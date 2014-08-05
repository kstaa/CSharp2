//A Program to Balance your Checkbook.  To practice the ability to pass variables by reference.
using System;

public class CheckBook
{
	public static void Main()
	{
		double start = 0.0, add = 0.0, subtract = 0.0, end = 0.0;
	
        //Get Starting Balance from the user
		Console.Out.WriteLine("Starting Balance:");
		getDouble(ref start);

        //Get Withdrawal Amount from the user
		Console.Out.WriteLine("\nTotal Withdrawal:");
		getDouble(ref subtract);

        //Get Deposit Amount from the user
		Console.Out.WriteLine("\nTotal Deposit:");
		getDouble(ref add);

        //Call balanceBook to calculate Ending Balance
  		balanceBook(start, add, subtract, ref end);

		Console.Out.WriteLine("The Ending Balance is " + end);
	}

    //Get a value from the user
	public static void getDouble(ref double value)
	{
		String strValue;

		System.Console.Out.Write("Enter a value: ");
		strValue = System.Console.ReadLine();
		value = Convert.ToDouble(strValue);
	}
	
    //Calculate the Ending Balance
	public static void balanceBook(double beginning, double deposits, double withdrawals, ref double ending)
	{
		ending = beginning + deposits - withdrawals;
	}

}