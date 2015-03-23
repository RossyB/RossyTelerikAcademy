//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Workdays
{
    static void Main()
    {
        Console.Write("Enter a end date in YYYY.MM.DD format: ");
        DateTime endDay = DateTime.Parse(Console.ReadLine());
        int workDays = NumberOfWorkdays(endDay);
        Console.WriteLine(workDays);
    }

    static int NumberOfWorkdays(DateTime endDay) 
    {
        int currentYear = DateTime.Today.Year;

        DateTime[] holidays = { new DateTime(currentYear, 1, 1), // January the 1st
                                new DateTime(currentYear, 3, 3), // Marth the 3rd
                                new DateTime(currentYear, 5, 1), // Labor day
                                new DateTime(currentYear, 5, 6), // Georgeday
                                new DateTime(currentYear, 5, 24), // St. Kiril i Metodii
                                new DateTime(currentYear, 9, 6), // Union
                                new DateTime(currentYear, 9, 22), // Indepence
                                new DateTime(currentYear, 11, 1), // Buditeli
                                new DateTime(currentYear, 12, 24), // The Eve before Christmas
                                new DateTime(currentYear, 12, 25), // Christmas Eve
                                new DateTime(currentYear, 12, 26) // The day after Christmas Eve
                              };

        DateTime today = DateTime.Today;
        int allDays = (endDay - today).Days;
        int workDays = allDays;
        DateTime day = today;

        while (day >= endDay)
        {
            if (day.DayOfWeek == DayOfWeek.Saturday || day.DayOfWeek == DayOfWeek.Sunday)
            {
                workDays--;
            }
            else
            {
                for (int i = 0; i < holidays.Length; i++)
                {
                    if (day == holidays[i])
                    {
                        workDays--;
                    }
                }
            }
            day = day.AddDays(1);
        }
        return workDays;
    }
}
