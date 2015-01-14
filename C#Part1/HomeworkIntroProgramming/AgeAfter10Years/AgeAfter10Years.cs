//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

using System;

class AgeAfter10Years
{
    static void Main()
    {
        Console.WriteLine("Enter your birthday in format DD.MM.YYYY:");
        DateTime birdday = Convert.ToDateTime(Console.ReadLine());
        int age = 0;
        DateTime currentDate = DateTime.Today;

        if (currentDate.Month < birdday.Month)
        {
            age = currentDate.Year - birdday.Year - 1;
        }
        else if (currentDate.Month > birdday.Month)
        {
            age = currentDate.Year - birdday.Year;
        }
        else
        {
            if (currentDate.Day < birdday.Day)
            {
                age = currentDate.Year - birdday.Year - 1;
            }
            else
            {
                age = currentDate.Year - birdday.Year;
            }
        }

        Console.WriteLine("Your age after 10 years will be: {0}", age + 10);
    }
}

