using System;

namespace EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
           
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());
                int br = 0;
                for (int number = firstNumber; number <= secondNumber; number++)
                {
                    br = 0;
                    int evenSum = 0;
                    int oddSum = 0;
                    int tempNumber = number;
                    while (tempNumber > 0)
                    {
                        int digit = tempNumber % 10;
                        br++;
                        if (br % 2 != 0)
                        {
                            evenSum += digit;
                        }
                        else
                        {
                            oddSum += digit;
                        }
                        tempNumber = tempNumber / 10;
                    }
                    if (evenSum == oddSum)
                    {
                        Console.Write(number + " ");
                    }
                }

            }
        }
    }

