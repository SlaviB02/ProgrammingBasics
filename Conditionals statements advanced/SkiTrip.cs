using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string rating = Console.ReadLine();
            double discount = 0.0;
            double price = 0.0;
            if(room== "room for one person")
            {
                price = (days - 1) * 18;
                if(rating=="positive")
                {
                    price = price + (price * 0.25);
                }
                else if(rating=="negative")
                {
                    price = price - (price * 0.10);
                }
                Console.WriteLine("{0:F2}", price);
            }   
            else if(room=="apartment")
            {
                price = (days - 1) * 25;
                if(days<=10)
                {
                    discount = 0.30;
                }
               else if(days>10 && days<=15)
                {
                    discount = 0.35;
                }
                else if(days>15)
                {
                    discount = 0.50;
                }
                double newPrice = price - (price * discount);
                if (rating == "positive")
                {
                    newPrice = newPrice + (newPrice * 0.25);
                }
                else if (rating == "negative")
                {
                    newPrice = newPrice - (newPrice * 0.10);
                }
               
                Console.WriteLine("{0:F2}", newPrice);

            }
            else if (room == "president apartment")
            {
                price = (days - 1) * 35;
                if (days <= 10)
                {
                    discount = 0.10;
                }
                else if (days > 10 && days <= 15)
                {
                    discount = 0.15;
                }
                else if (days > 15)
                {
                    discount = 0.20;
                }
                if (rating == "positive")
                {
                    price = price + (price * 0.25);
                }
                else if (rating == "negative")
                {
                    price = price - (price * 0.10);
                }
                price = price - (price * discount);
                Console.WriteLine("{0:F2}", price);

            }

        }
    }
}
