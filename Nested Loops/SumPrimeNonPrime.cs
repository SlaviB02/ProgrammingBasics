using System;

namespace SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeSum = 0;
            int nonPrimeSum = 0;
            string input = "";
            while(true)
            {
                input = Console.ReadLine();
                if(input=="stop")
                {
                    break;
                }
                int number = int.Parse(input);
                if(number<0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }
                bool flag = true;
                for(int i=2;i<=Math.Sqrt(number);i++)
                {
                    if(number%i==0)
                    {
                        flag = false;
                        break;
                    }
                }
                if(flag==false)
                {
                    nonPrimeSum += number;
                }
                else
                {
                    primeSum += number;
                }

            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");



        }
    }
}
