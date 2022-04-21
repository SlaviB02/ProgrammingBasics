using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeLength = int.Parse(Console.ReadLine());
            int cakeWidth = int.Parse(Console.ReadLine());
            int pieces = cakeLength * cakeWidth;
            int piece = 0;
            bool flag = false;
            while(pieces>=0 && !flag)
            {
                string input = Console.ReadLine();
                if(input=="STOP")
                {
                    flag = true;
                    break;

                }
                piece = int.Parse(input);
                pieces -= piece;
            }
            if(flag==false)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(pieces)} pieces more.");

            }
            else
            {
                Console.WriteLine($"{pieces} pieces are left.");
            }
        }
    }
}
