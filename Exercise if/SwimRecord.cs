using System;

namespace SwimRecord
{
    class Program
    {
        static void Main(string[] args)
        {
			double recordTime = double.Parse(Console.ReadLine());
			double distance = double.Parse(Console.ReadLine());
			double time = double.Parse(Console.ReadLine());
			double swimTime = distance * time;
			double resistance = (Math.Floor(distance / 15)) * 12.5;
			double totalTime = resistance + swimTime;
			if (totalTime < recordTime)
			{
				Console.WriteLine(" Yes, he succeeded! The new world record is " + "{0:F2}" + " seconds.", totalTime);

			}
			else
			{
				Console.WriteLine("No, he failed! He was " + "{0:F2}" + " seconds slower.", totalTime - recordTime);
			}

		}
	}
}
