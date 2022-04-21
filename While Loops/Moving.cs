using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int size = length * width * height;
            bool flag = false;
            while(size>=0 && !flag)
            {
                string input = Console.ReadLine();
                if(input=="Done")
                {
                    flag = true;
                    break;
                }
                int space = int.Parse(input);
                size -= space;
            }
            if(flag==true)
            {
                Console.WriteLine($"{size} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(size)} Cubic meters more.");
            }

        }
    }
}
