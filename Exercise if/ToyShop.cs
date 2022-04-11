using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
			double price = double.Parse(Console.ReadLine());
			int puzzles = int.Parse(Console.ReadLine());
			int dolls = int.Parse(Console.ReadLine());
			int bears = int.Parse(Console.ReadLine());
			int miners = int.Parse(Console.ReadLine());
			int trucks = int.Parse(Console.ReadLine());
			double sum = puzzles * 2.60 + dolls * 3 + bears * 4.10 + miners * 8.20 + trucks * 2;
			int number = puzzles + dolls + bears + miners + trucks;
			if (number >= 50)
			{
				double discount = sum * 0.25;
				double totalSum = sum - discount;
				double rent = totalSum * 0.10;
				double money = totalSum - rent;
				if (money >= price)
				{
					Console.WriteLine("Yes! " + "{0:F2}" + " lv left.", money - price);
				}
				else
				{
					Console.WriteLine("Not enough money! " + "{0:F2}" + " lv needed.", price - money);

				}
			}
			else
			{
				double rent = sum * 0.10;
				double money = sum - rent;
				if (money > price)
				{
					Console.WriteLine("Yes! " + "{0:F2}" + " lv left.", money - price);
				}
				else
				{
					Console.WriteLine("Not enough money! " + "{0:F2}" + " lv needed.", price - money);

				}
			}
		}
    }
}
