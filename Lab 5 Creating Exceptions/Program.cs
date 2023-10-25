namespace Lab_5_Creating_Exceptions
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Create a circle object with positive radius and display it
			Circle circle1 = new Circle();
			circle1.SetRadius(12.5);
			Console.WriteLine(circle1);

			// Create a circle object with negative radius and display it
			Circle circle2 = new Circle();
			try
			{
				circle2.SetRadius(-4.5);
				Console.WriteLine(circle2);
			}
			catch (InvalidRadiusException e)
			{
				// Catch and print the exception message if the radius is invalid
				Console.WriteLine(e.Message);
			}

			// Create a circle object with zero radius and display it
			Circle circle3 = new Circle();
			try
			{
				circle3.SetRadius(0);
				Console.WriteLine(circle3);
			}
			catch (InvalidRadiusException e)
			{
				// Catch and print the exception message if the radius is invalid
				Console.WriteLine(e.Message);
			}
		}
	}
}