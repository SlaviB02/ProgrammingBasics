using System;

namespace Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int m1 = 0, m2 = 0, m3 = 0, m4 = 0, m5 = 0;
            int totalPeople = 0;
            for (int i=0;i<number;i++)
            {
                int numberPeople = int.Parse(Console.ReadLine());
                totalPeople = totalPeople + numberPeople;
                if(numberPeople<=5)
                {
                    m1=m1+numberPeople;
                }
                else if(numberPeople>=6 && numberPeople<=12)
                {
                    m2=m2+numberPeople;
                }
                else if(numberPeople>=13 && numberPeople<=25)
                {
                    m3=m3+numberPeople;
                }
                else if(numberPeople>=26 && numberPeople<=40)
                {
                    m4=m4+numberPeople;
                }
                else if(numberPeople>=41)
                {
                    m5=m5+numberPeople;
                }
            }
            double firstPercent = (double)m1 / totalPeople * 100;
            double secondPercent = (double)m2 / totalPeople * 100;
            double thirdPercent = (double)m3 / totalPeople * 100;
            double forthPercent = (double)m4 / totalPeople * 100;
            double fifthPercent = (double)m5 / totalPeople * 100;
            Console.WriteLine("{0:F2}%", firstPercent);
            Console.WriteLine("{0:F2}%", secondPercent);
            Console.WriteLine("{0:F2}%", thirdPercent);
            Console.WriteLine("{0:F2}%", forthPercent);
            Console.WriteLine("{0:F2}%", fifthPercent);

        }
    }
}
