using System;

namespace Time_15
{
    class Program
    {
        static void Main(string[] args)
        {
			int hours = int.Parse(Console.ReadLine());
			int minutes = int.Parse(Console.ReadLine());
			int totalMinutes = hours * 60 + minutes + 15;
			int finalHours = totalMinutes / 60;
			int finalMinutes = totalMinutes % 60;
			if (finalHours > 23)
			{
				if (finalMinutes < 10)
				{
					Console.WriteLine("0:0" + finalMinutes);
				}
				else
				{
					Console.WriteLine("0:" + finalMinutes);
				}
			}
			else
			{
				if (finalMinutes < 10)
				{
					Console.WriteLine(finalHours + ":0" + finalMinutes);
				}
				else
				{
					Console.WriteLine(finalHours + ":" + finalMinutes);
				}
			}
		}
    }
}
