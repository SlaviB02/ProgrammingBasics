using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = 0;
            int totalSteps = 0;
            string input = "";
            bool flag = false;
            while(totalSteps<=10000 && !flag)
            {
               input = Console.ReadLine();
                if (input == "Going home")
                {
                    input = Console.ReadLine();
                    flag = true;
                }
                steps = int.Parse(input);
                totalSteps += steps;

            }
            if(totalSteps>=10000)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{totalSteps - 10000} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{10000 - totalSteps} more steps to reach goal.");
            }
        }
    }
}
