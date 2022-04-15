using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            string operate= Console.ReadLine();
            double result = 0.0;
            if(operate=="+")
            {
                if ((N1 + N2) % 2 == 0)
                {
                    Console.WriteLine($"{N1} + {N2} = {N1 + N2} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} + {N2} = {N1 + N2} - odd");
                }
            }
            else if(operate=="-")
            {
                if ((N1-N2) % 2 == 0)
                {
                    Console.WriteLine($"{N1} - {N2} = {N1-N2} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} - {N2} = {N1-N2} - odd");
                }
            }
            else if(operate=="*")
            {
                result =N1 * N2;
                if(result%2==0)
                {
                  
                    Console.WriteLine($"{N1} * {N2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} * {N2} = {result} - odd");
                }

            }
            else if(operate=="/")
            {
                result = (double)N1 / N2;
                if(N2==0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
                else
                {
                    Console.WriteLine($"{N1} / {N2} = "+"{0:F2}",result);
                }

            }
            else if(operate=="%")
            {
                if (N2 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
                else
                {
                    Console.WriteLine($"{N1} % {N2} = {N1%N2}");
                }
            }
        }
    }
}
