using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());
            switch (type)
            {
                case "Premiere":
                    {
                        double income = rows * colums * 12.00;
                        Console.WriteLine("{0:F2} leva", income); break;
                    }
                case "Normal":
                    {
                        double income = rows * colums * 7.50;
                        Console.WriteLine("{0:F2} leva", income); break;
                    }
                case "Discount":
                    {
                        double income = rows * colums * 5.00;
                        Console.WriteLine("{0:F2} leva", income); break;
                    }
            }
        }
    }
}
