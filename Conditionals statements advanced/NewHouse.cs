using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            int money = int.Parse(Console.ReadLine());
            double price = 0.00;
            switch(flower)
            {
                case "Roses":
                    {
                        price = number * 5.00;
                        if(number>80)
                        {
                            price = price - (price * 0.10);
                        }
                        break;
                    }
                case "Dahlias":
                    {
                        price = number * 3.80;
                        if(number>90)
                        {
                            price = price - (price * 0.15);
                        }
                        break;
                    }
                case "Tulips":
                    {
                        price = number * 2.80;
                        if(number>80)
                        {
                            price = price - (price * 0.15);
                        }
                        break;
                    }
                case "Narcissus":
                    {
                        price = number * 3.00;
                        if(number<120)
                        {
                            price = price + (price * 0.15);
                        }
                        break;
                    }
                case "Gladiolus":
                    {
                        price = number * 2.50;
                        if(number<80)
                        {
                            price = price + (price * 0.20);
                        }
                        break;
                    }
                  
            }
            if (money >= price)
            {
                Console.WriteLine("Hey, you have a great garden with " + number + " " + flower + " and " + "{0:F2}" + " leva left.", money - price);
            }
            else
            {
                Console.WriteLine("Not enough money, you need " + "{0:F2}" + " leva more.", price - money);
            }
        }
    }
}
