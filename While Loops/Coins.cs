using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());
            double lv = Math.Floor(change);
            double coins = Math.Round((change - lv) * 100);
            int br = 0;
            while (lv > 0)
            {
                if (lv >= 2)
                {
                    br++;
                    lv -= 2;
                }
                else if (lv >= 1)
                {
                    br++;
                    lv -= 1;
                }
            }
                while (coins > 0)
                {
                    if (coins >= 50)
                    {
                        br++;
                        coins -= 50;
                    }
                    else if (coins >= 20)
                    {
                        br += 1;
                        coins -= 20;
                    }
                    else if (coins >= 10)
                    {
                        br += 1;
                        coins -= 10;
                    }
                    else if (coins >= 05)
                    {
                        br += 1;
                        coins -= 05;
                    }
                    else if (coins >= 02)
                    {
                        br += 1;
                        coins -= 02;
                    }
                    else if (coins >= 01)
                    {
                        br += 1;
                        coins -= 01;
                        break;
                    }

                }

                Console.WriteLine(br);
            }

        }
    }

