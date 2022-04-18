using System;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());
            double actorPoints = 0.0;
            bool flag = true;
            for(int i=0;i<number;i++)
            {
                string judgeName = Console.ReadLine();
                double judgePoints = double.Parse(Console.ReadLine());
                actorPoints = (judgeName.Length*judgePoints) / 2;
                academyPoints = academyPoints + actorPoints;
                if(academyPoints>1250.5)
                {
                    flag = false;
                    break;
                }
            }
            if(flag==false)
            {
                Console.WriteLine($"Congratulations, {name} got a nominee for leading role with " + "{0:F1}" + "!", academyPoints);
            }
            else
            {
                Console.WriteLine($"Sorry, {name} you need " + "{0:F1}" + " more!", 1250.5-academyPoints);
            }
        }
    }
}
