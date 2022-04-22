using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int number=1111;number<=9999;number++)
            {
                int tempNumber = number;
                bool flag = true;
                while(tempNumber>0)
                {
                    int digit = tempNumber % 10;
                    if(digit==0)
                    {
                        flag = false;
                        break;
                    }
                    if(n%digit!=0)
                    {
                        flag = false;
                        break;
                    }
                    tempNumber = tempNumber / 10;
                }
                if(flag==true)
                {
                    Console.Write(number+" ");
                }
            }
        }
    }
}
