using System;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            if(city=="Sofia")
            {
                if(volume>=0 && volume<=500)
                {
                    Console.WriteLine("{0:F2}", volume * 0.05);
                }
                else if(volume>500 && volume<=1000)
                {
                    Console.WriteLine("{0:F2}", volume * 0.07);
                }
                else if (volume >1000 && volume <= 10000)
                {
                    Console.WriteLine("{0:F2}", volume * 0.08);
                }
                else if (volume >10000)
                {
                    Console.WriteLine("{0:F2}", volume * 0.12);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if(city=="Varna")
            {
                if (volume >= 0 && volume <= 500)
                {
                    Console.WriteLine("{0:F2}", volume * 0.045);
                }
                else if (volume > 500 && volume <= 1000)
                {
                    Console.WriteLine("{0:F2}", volume * 0.075);
                }
                else if (volume > 1000 && volume <= 10000)
                {
                    Console.WriteLine("{0:F2}", volume * 0.10);
                }
                else if (volume > 10000)
                {
                    Console.WriteLine("{0:F2}", volume * 0.13);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if(city=="Plovdiv")
            {
                if (volume >= 0 && volume <= 500)
                {
                    Console.WriteLine("{0:F2}", volume * 0.055);
                }
                else if (volume > 500 && volume <= 1000)
                {
                    Console.WriteLine("{0:F2}", volume * 0.08);
                }
                else if (volume > 1000 && volume <= 10000)
                {
                    Console.WriteLine("{0:F2}", volume * 0.12);
                }
                else if (volume > 10000)
                {
                    Console.WriteLine("{0:F2}", volume * 0.145);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
