//Write a program that prompts the user for a list of up to 100 numbers to be stored in array.
//The program should stop asking for numbers if the user enters the value of 999 of if the array is full.
//When the user finished entering values, calculate the average of the numbers entered.

using System;
public class AvgNumbers
{
	public static void Main()
	{
		int[] numbers = new int[100];
		int number, count = 0;
		double sum = 0.0, average;
		String strNumber;

		Console.Out.WriteLine("===Average Calculator for up to 100 numbers===\n");

		do
		{
			//Get input from the user
			Console.Out.Write("Please enter a number (type 999 to quit); ");
			strNumber = Console.ReadLine();
			number = Convert.ToInt32(strNumber);

			//Store input
			numbers[count] = number;

			//Increment the total count
			count++;

		} while(count < numbers.Length && number != 999);

		// Check to see if the user enter 999
		if (number == 999)
		{
			//Exclude the last input (999)
			count = count - 1;
		}

		for (int i = 0; i < count; i++)
		{
			//Calculate the sum of numbers entered
			sum = sum + numbers[i];
		}	

		//Make sure the user entered at least 1 number
		if (count > 0)
		{
			//Display Result
			Console.Out.WriteLine("\nYou have entered " + count + " numbers");
			Console.Out.WriteLine("Sum of your numbers is " + sum);
			
			average = sum/count;
			Console.Out.WriteLine("\nThe average of your numbers is " + average);
		}
		
		else
		{	
			Console.Out.WriteLine("n\nPlease enter at least 1 number to calculate an average.");
		}
		
	}
}