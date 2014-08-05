public class FloorArea
{
	public static void Main()
	{
        //Variables
		double length, width, area, cost, total;
		string strLength, strWidth, strCost;

        //Get Input from Users
		System.Console.Out.Write("Please enter the length of the room (in feet): ");
		strLength = System.Console.ReadLine();
		length = System.Convert.ToDouble(strLength);
	
		System.Console.Out.Write("Please enter the width of the room (in feet): ");
		strWidth = System.Console.ReadLine();
		width = System.Convert.ToDouble(strWidth);

        System.Console.Out.Write("Please enter the cost of the carpet per square foot: ");
		strCost = System.Console.ReadLine();
		cost = System.Convert.ToDouble(strCost);

        //Calculate Area
		area = length * width;

        //Calculate Total Cost
		total = area * cost;

        //Display Result in Square Feet
		System.Console.Out.WriteLine("The area is " + area + " square feet");

        //Display Total Cost in $
		System.Console.Out.WriteLine("The total cost is $" + total);
	}
}		