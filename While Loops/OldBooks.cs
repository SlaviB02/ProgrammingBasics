using System;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
			string book = Console.ReadLine();
			string input = "";
			int counter = 0;
			bool flag = true;
			while (input != book)
			{
				input = Console.ReadLine();
				counter++;
				if (input == "No More Books")
				{
					counter--;
					Console.WriteLine("The book you search is not here!");
					Console.WriteLine("You checked " + counter + " books.");
					flag = false;
					break;
				}
			}
			if (flag == true)
			{
				counter--;
				Console.WriteLine("You checked " + counter + " books and found it.");
			}

		}
	}
}
