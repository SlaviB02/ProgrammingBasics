using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentTickets = 0;
            int standardTickets = 0;
            int kidTickets = 0;
            int totalTickets = 0;
            while(true)
            {
                string input = Console.ReadLine();
                if(input=="Finish")
                {
                    Console.WriteLine($"Total tickets: {totalTickets}");
                    Console.WriteLine($"{(double)studentTickets / totalTickets * 100:F2}% student tickets.");
                    Console.WriteLine($"{(double)standardTickets / totalTickets * 100:F2}% standard tickets.");
                    Console.WriteLine($"{(double)kidTickets / totalTickets * 100:F2}% kids tickets.");
                    break;
                }
                int freeSpaces = int.Parse(Console.ReadLine());
                int temp = freeSpaces;
                while(temp>0)
                {
                    string ticket = Console.ReadLine();
                    if(ticket=="End")
                    {
                        break;
                    }
                   
                    if(ticket=="student")
                    {
                        studentTickets++;
                    }
                    else if(ticket=="standard")
                    {
                        standardTickets++;
                    }
                    else if(ticket=="kid")
                    {
                        kidTickets++;
                    }
                    totalTickets++;
                    temp--;
                }
                if (temp == 0)
                {
                    Console.WriteLine($"{input} - {100:F2}% full.");
                }
                else
                {
                  int total=freeSpaces - temp;
                    Console.WriteLine($"{input} - {(double)total / freeSpaces*100:F2}% full.");

                }
            }
        }
    }
}
