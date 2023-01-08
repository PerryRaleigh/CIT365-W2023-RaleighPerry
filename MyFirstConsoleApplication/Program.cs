using System;

namespace MyFirstConsoleApplication
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double width, height, woodLength, glassArea;
			string widthString, heightString;
			string yourName = "Perry Raleigh";
			string yourLocation = "Nampa Idaho";

			Console.WriteLine($"My name is {yourName}");
			Console.WriteLine($"I am from {yourLocation}");
			Console.WriteLine($"The current date is {DateTime.Now.ToString("MM / dd / yyyy")}\n");

			Console.WriteLine($"Enter window width: ");
			widthString = Console.ReadLine();
			width = double.Parse(widthString);

			Console.WriteLine($"Enter window height: ");
			heightString = Console.ReadLine();
			height = double.Parse(heightString);

			woodLength = 2 * (width + height) * 3.25;

			glassArea = 2 * (width * height);

			Console.WriteLine("The length of the wood is " +
				woodLength + " feet");
			Console.WriteLine("The area of the glass is " +
				glassArea + " square metres");

			Console.WriteLine("\nPress any key to exit");
			Console.ReadKey();
		}
	}
}
