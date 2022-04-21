using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
			string name = Console.ReadLine();
			int grades = 1;
			double sum = 0;
			int exclude = 0;
			bool flag = true;
			while (grades <= 12)
			{
				double grade = double.Parse(Console.ReadLine());
				if (grade < 4.00)
				{
					exclude++;
					if (exclude > 1)
					{
						Console.WriteLine(name + " has been excluded at " + grades + " grade");
						flag = false;
						break;

					}
					continue;
				}
				sum += grade;
				grades++;
			}
			if (flag == true)
			{
				double average = sum / 12;
				Console.WriteLine(name + " graduated. Average grade: " + "{0:F2}", average);
			}
		}
    }
}
