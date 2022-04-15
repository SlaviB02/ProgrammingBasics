using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double spentMoney = 0.0;
            if(budget<=100)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                if(season=="summer")
                {
                    spentMoney = budget * 0.30;
                    Console.WriteLine("Camp - " + "{0:F2}", spentMoney);
                }
              else if(season=="winter")
                {
                    spentMoney = budget * 0.70;
                    Console.WriteLine("Hotel - " + "{0:F2}", spentMoney);
                }
                
            }
            else if (budget>100 && budget<=1000)
            {
                Console.WriteLine("Somewhere in Balkans");
                if (season == "summer")
                {
                    spentMoney = budget * 0.40;
                    Console.WriteLine("Camp - " + "{0:F2}", spentMoney);
                }
                else if (season == "winter")
                {
                    spentMoney = budget * 0.80;
                    Console.WriteLine("Hotel - " + "{0:F2}", spentMoney);
                }

            }
            else if(budget>1000)
            {
                Console.WriteLine("Somewhere in Europe");
                spentMoney = budget * 0.90;
                Console.WriteLine("Hotel - " + "{0:F2}", spentMoney);
            }
        }
    }
}
