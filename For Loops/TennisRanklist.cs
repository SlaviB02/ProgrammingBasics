using System;

namespace TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());
            int totalPoints = 0;
            int winCounter = 0;
            for(int i=0;i<tournaments;i++)
            {
                string stage = Console.ReadLine();
                if(stage=="W")
                {
                    totalPoints += 2000;
                    winCounter++;
                }
                else if(stage=="F")
                {
                    totalPoints += 1200;
                }
                else if(stage=="SF")
                {
                    totalPoints += 720;
                }
            }
            double average = (double)totalPoints / tournaments;
            totalPoints = totalPoints + startingPoints;
            double winPercent = (double)winCounter / tournaments*100;
            Console.WriteLine($"Final points: {totalPoints}");
            Console.WriteLine("Average points: " + Math.Floor(average));
            Console.WriteLine("{0:F2}%", winPercent);

        }
    }
}
