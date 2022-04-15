using System;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());
            int examTotal = examHour * 60 + examMinutes;
            int arrivalTotal = arrivalHour * 60 + arrivalMinutes;
            if (arrivalTotal > examTotal)
            {
                Console.WriteLine("Late");
                if ((arrivalTotal - examTotal) < 60)
                {
                    Console.WriteLine($"{arrivalTotal - examTotal} minutes after the start");

                }
                else if ((arrivalTotal - examTotal) == 60)
                {
                    Console.WriteLine($"1:00 hours after the start");
                }
                else
                {
                    int total = arrivalTotal - examTotal;
                    int tempMinutes = total % 60;
                    if (tempMinutes < 10)
                    {
                        Console.WriteLine($"{total / 60}:0{total % 60} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{total / 60}:{total % 60} hours after the start");
                    }

                }
            }
            else if ((examTotal - arrivalTotal) <= 30)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{examTotal - arrivalTotal} minutes before the start");
            }
            else if (arrivalTotal == examTotal)
            {
                Console.WriteLine("On time");
            }
            else if ((examTotal - arrivalTotal) > 30)
            {
                Console.WriteLine("Early");
                if ((examTotal - arrivalTotal) > 30 && (examTotal - arrivalTotal) < 60)
                {

                    Console.WriteLine($"{examTotal - arrivalTotal} minutes before the start");

                }
                else if ((examTotal - arrivalTotal) == 60)
                {
                    Console.WriteLine($"1:00 hours before the start");
                }
                else
                {

                    int total = examTotal - arrivalTotal;
                    int tempMinutes = total % 60;
                    if (tempMinutes < 10)
                    {
                        Console.WriteLine($"{total / 60}:0{total % 60} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{total / 60}:{total % 60} hours before the start");
                    }


                }
            }

        }
        }
        }
   
