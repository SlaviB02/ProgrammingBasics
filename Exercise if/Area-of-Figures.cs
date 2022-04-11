using System;

namespace Area_of_Figures
{
	class Program
	{
		static void Main(string[] args)
		{
			string figure = Console.ReadLine();
			if (figure == "square")
			{
				double side = double.Parse(Console.ReadLine());
				double area = side * side;
				Console.WriteLine("{0:F3}", area);
			}
			if (figure == "rectangle")
			{
				double firstSide = double.Parse(Console.ReadLine());
				double secondSide = double.Parse(Console.ReadLine());
				double area = firstSide * secondSide;
				Console.WriteLine("{0:F3}", area);
			}
			if (figure == "circle")
			{
				double radius = double.Parse(Console.ReadLine());
				double area = Math.PI * radius * radius;
				Console.WriteLine("{0:F3}", area);
			}
			if (figure == "triangle")
			{
				double side = double.Parse(Console.ReadLine());
				double height = double.Parse(Console.ReadLine());
				double area = (side * height) / 2;
				Console.WriteLine("{0:F3}", area);
			}
		}
	}
}
