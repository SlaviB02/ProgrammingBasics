using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double apartment = 0.0;
            double studio = 0.0;
            double discountStudio = 0.0;
            double discountApartment = 0.0;
            if(month=="May" || month=="October")
            {
                studio = nights * 50;
                apartment = nights * 65;
                if (nights>7 && nights<=14)
                {
                    discountStudio = 0.05;
                    studio = studio - discountStudio * studio;
                }
                else if(nights>14)
                {
                    discountStudio = 0.30;
                    discountApartment = 0.10;
                    studio = studio - discountStudio * studio;
                    apartment = apartment - discountApartment * apartment;

                }
                

            }
            else if(month == "June" || month == "September")
            {
                studio = nights * 75.20;
                apartment = nights * 68.70;
                if (nights > 14)
                {
                    discountStudio = 0.20;
                    discountApartment = 0.10;
                    studio = studio - discountStudio * studio;
                    apartment = apartment - discountApartment * apartment;

                }
            }
            else if(month=="July" || month=="August")
            {
                studio = nights * 76;
                apartment = nights * 77;
                if (nights > 14)
                {
                    discountApartment = 0.10;

                    apartment = apartment - discountApartment * apartment;

                }
            }
            Console.WriteLine("Apartment: " + "{0:F2}" + " lv.", apartment);
            Console.WriteLine("Studio: " + "{0:F2}" + " lv.", studio);

        }
    }
}
