using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());
            double price = 0.00;
           if(season=="Spring")
            {
                price = 3000;
                if(fishermen<=6)
                {
                    price = price - (price * 0.10);
                }
                else if(fishermen>7 && fishermen<=11)
                {
                    price = price - (price * 0.15);
                }
                else if(fishermen>=12)
                {
                    price = price - (price * 0.25);
                }
            }
           else if(season=="Summer" || season=="Autumn")
            {
                price = 4200;
                if (fishermen <= 6)
                {
                    price = price - (price * 0.10);
                }
                else if (fishermen > 7 && fishermen <= 11)
                {
                    price = price - (price * 0.15);
                }
                else if (fishermen >= 12)
                {
                    price = price - (price * 0.25);
                }
            }
           else if(season=="Winter")
            {
                price = 2600;
                if (fishermen <= 6)
                {
                    price = price - (price * 0.10);
                }
                else if (fishermen > 7 && fishermen <= 11)
                {
                    price = price - (price * 0.15);
                }
                else if (fishermen >= 12)
                {
                    price = price - (price * 0.25);
                }
            }
           if(fishermen%2==0 && season!="Autumn")
            {
                price = price - (price * 0.05);
            }
           if(budget>=price)
            {
                Console.WriteLine("Yes! You have " + "{0:F2}" + " leva left.", budget - price);
            }
            else
            {
                Console.WriteLine("Not enough money! You need " + "{0:F2}" + " leva.", price - budget);
            }


        }
    }
}
