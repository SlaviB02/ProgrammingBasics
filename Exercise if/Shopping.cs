using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
			double budget = double.Parse(Console.ReadLine());
			int videoCard = int.Parse(Console.ReadLine());
			int processor = int.Parse(Console.ReadLine());
			int ram = int.Parse(Console.ReadLine());
			double videoPrice = videoCard * 250;
			double processorPrice = processor * (videoPrice * 0.35);
			double ramPrice = ram * (videoPrice * 0.10);
			double totalPrice = videoPrice + processorPrice + ramPrice;
			if (videoCard > processor)
			{
				totalPrice = totalPrice - totalPrice * 0.15;
			}
			if (budget >= totalPrice)
			{
				Console.WriteLine("You have " + "{0:F2}" + " leva left!", budget - totalPrice);

			}
			else
			{
				Console.WriteLine("Not enough money! You need " + "{0:F2}" + " leva more!", totalPrice - budget);

			}
		}
    }
}
