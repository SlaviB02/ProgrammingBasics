using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int grades = int.Parse(Console.ReadLine());
            string input = "";
            int badGrades = 0;
            bool flag = true;
            double sum = 0.0;
            int taskCounter = 0;
            string lastTask = "";
            while (input!="Enough")
            {
                input= Console.ReadLine();
                if(input=="Enough")
                {
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if(grade<=4)
                {
                    badGrades++;
                }
                if(badGrades==grades)
                {
                    Console.WriteLine($"You need a break, {grades} poor grades.");
                    flag = false;
                    break;
                }
                taskCounter++;
                lastTask = input;
                sum += grade;
            }
            if(flag==true)
            {
                Console.WriteLine("Average score: " + "{0:F2}",(double)sum / taskCounter);
                Console.WriteLine($"Number of problems: {taskCounter}");
                Console.WriteLine($"Last problem: {lastTask}");
            }
        }
    }
}
