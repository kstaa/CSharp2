using System;

public class LetterGrade
{
	public static void Main()
	{
	double gradeNumber;
	String strGrade;

	System.Console.Out.WriteLine("Please enter your grade: ");
	strGrade = System.Console.ReadLine();
	gradeNumber = Convert.ToDouble(strGrade);

	if (gradeNumber >= 90)
		Console.Out.WriteLine("A");
	else if (gradeNumber >= 80)
		Console.Out.WriteLine("B");
	else if (gradeNumber >= 70)
		Console.Out.WriteLine("C");
	else if (gradeNumber >= 60)
		Console.Out.WriteLine("D");
	else 
		Console.Out.WriteLine("E");
	
	}

}