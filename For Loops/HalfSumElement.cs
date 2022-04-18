using System;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
			int n = int.Parse(Console.ReadLine());
			int max = int.MinValue;
			int sum = 0;
			for (int i = 0; i < n; i++)
			{
				int num = int.Parse(Console.ReadLine());
				sum += num;
				if (num > max)
				{
					max = num;
				}
			}
			int sumWithout = sum - max;
			if (max == (sumWithout))
			{
				Console.WriteLine("Yes");
				Console.WriteLine("Sum = " + sumWithout);
			}
			else
			{
				Console.WriteLine("No");
				Console.WriteLine("Diff = " + Math.Abs(max - sumWithout));
			}
		}
    }
}
