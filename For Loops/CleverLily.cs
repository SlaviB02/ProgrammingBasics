using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceWashingMachine = double.Parse(Console.ReadLine());
            int priceToy = int.Parse(Console.ReadLine());
            int brother = 0;
            int presentMoney = 0;
            int savedMoney = 0;
            int toyCounter = 0;
            for(int i=1;i<=age;i++)
            {
                if(i%2==0)
                {

                    presentMoney += 10;
                    savedMoney = savedMoney + presentMoney;
                    brother++;
                }
                else
                {
                    toyCounter++;
                }
            }
            double totalMoney = savedMoney - brother + (toyCounter * priceToy);
            if(totalMoney>=priceWashingMachine)
            {
                Console.WriteLine("Yes! " + "{0:F2}", totalMoney - priceWashingMachine);
            }
            else
            {
                Console.WriteLine("No! " + "{0:F2}", priceWashingMachine - totalMoney);
            }

        }
    }
}
