using System;

namespace godzilla_vs_kong
{
    class Program
    {
        static void Main(string[] args)
        {
			double budget = double.Parse(Console.ReadLine());
			int extras = int.Parse(Console.ReadLine());
			double price = double.Parse(Console.ReadLine());
			double decor = budget * 0.10;
			double clothing = 0.0;
			if (extras >= 150)
			{
				clothing = extras * price;
				double discount = clothing * 0.10;
				clothing = clothing - discount;
			}
			else
			{
				clothing = extras * price;
			}
			double totalPrice = decor + clothing;
			if (totalPrice > budget)
			{
				Console.WriteLine("Not enough money!");
				Console.WriteLine("Wingard needs " + "{0:F2}" + " leva more.", totalPrice - budget);
			}
			else
			{
				Console.WriteLine("Action!");
				Console.WriteLine("Wingard starts filming with " + "{0:F2}" + " leva left.", budget - totalPrice);

			}
		}
    }
}
