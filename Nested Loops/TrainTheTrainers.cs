using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string input = "";
            int br = 0;
            double sum = 0;
            while(true)
            {
                double average = 0;
                input = Console.ReadLine();
                    if (input == "Finish")
                    {
                    Console.WriteLine("Student's final assessment is " + "{0:F2}"+".",sum/br);
                        break;
                    }
                    
                    for(int i=0;i<people;i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    average += grade;
                }
                average = average / people;
                Console.WriteLine(input + " - "+"{0:F2}"+".",average);
                sum = sum + average;
                br++;
            }
        }
    }
}
