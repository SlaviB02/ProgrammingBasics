using System;

namespace LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
			string name = Console.ReadLine();
			int lengthEpisode = int.Parse(Console.ReadLine());
			int lengthBreak = int.Parse(Console.ReadLine());
			double lunchTime = (double)lengthBreak / 8;
			double freeTime = (double)lengthBreak / 4;
			double time = lengthBreak - lunchTime - freeTime;
			if (time >= lengthEpisode)
			{
				Console.WriteLine("You have enough time to watch " + name + " and left with " + Math.Ceiling(time - lengthEpisode) + " minutes free time.");
			}
			else
			{
				Console.WriteLine("You don't have enough time to watch " + name + ", you need " + Math.Ceiling(lengthEpisode - time) + " more minutes.");
			}
		}
    }
}
