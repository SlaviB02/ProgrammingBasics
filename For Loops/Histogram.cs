using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;
            for(int i=0;i<n;i++)
            {
                int number = int.Parse(Console.ReadLine());
                if(number<200)
                {
                    p1++;
                }
               else if(number>=200 && number<=399)
                {
                    p2++;
                }
               else if(number>=400 && number<=599)
                {
                    p3++;
                }
               else if(number>=600 && number<=799)
                {
                    p4++;
                }
               else if(number>=800)
                {
                    p5++;
                }
            }
            double firstPercent = (double)p1 / n*100;
            double secondPercent = (double)p2 / n*100;
            double thirdPercent = (double)p3 / n*100;
            double forthPercent = (double)p4 / n*100;
            double fifthPercent = (double)p5 / n*100;
            Console.WriteLine("{0:F2}%", firstPercent);
            Console.WriteLine("{0:F2}%", secondPercent);
            Console.WriteLine("{0:F2}%", thirdPercent);
            Console.WriteLine("{0:F2}%", forthPercent);
            Console.WriteLine("{0:F2}%", fifthPercent);

        }
    }
}
