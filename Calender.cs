//-----------------------------------------------------------------------
// <copyright file="Calender.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStrucure
{
    using System;

    /// <summary>
    /// finding the weeks of days using the 2 d arrays 
    /// </summary>
    public class Calender
    {
        /// <summary>
        /// this weeks of days this instance
        /// </summary>
        public void Cal()
        {
            ////creating one utility object  
            Utility util = new Utility();
            int year = 0;
            int month = 0;
            Console.WriteLine("ENTER THE YEAR ");
            ////take the input from user for year
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER THE MONTH OF YEAR");
            ////take the input from user for month
            month = Convert.ToInt32(Console.ReadLine());
            if (month >= 1 && month <= 12 && year >= 1000 && year <= 9999)
            {
                ////creating 2 dimestional array store the days
                int[,] cale = new int[6, 7];
                ////creating the array that stores the names of a months 
                string[] months = { "", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
                ////storing the day of a month in to an array
                int[] days = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                ////calling the DayOfWeek method for calculating the at which day the date 1st is comming
                int sdate = util.DayOfWeek(year, month);
                ////this condition is used for checking wheter the given year is a leap year, if it is a leap year we will replace 28 days with 29 days
                if ((month == 2) && (year % 4 == 0))
                { 
                    days[2] = 29;
                }
                int date = 01;
                 //// First rows of days 
                for (int i = sdate; i < cale.GetLength(1); i++)
                {
                    cale[0, i] = date;
                    date++;
                }
                ////this loop is used for storing the dates in to a remaining rows and columns
                for (int i = 1; i < cale.GetLength(0); i++)
                {
                    for (int j = 0; j < cale.GetLength(1); j++)
                    {
                        ////this condition is used for checking whether the dates are upto the dates in a month
                        if (date <= days[month])
                        {
                            cale[i, j] = date++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                Console.WriteLine(months[month] + " " + year);
                Console.WriteLine("sun \t mon \t tue \t wed \t thr \t fri \t sat");
                ////this loop is used for printing the dates in a first row
                for (int i = 0; i < cale.GetLength(1); i++)
                {
                    if (cale[0, i] > 0)
                    {
                        Console.Write(cale[0, i] + "\t");
                    }
                    else
                    {
                        Console.Write(" " + "\t");
                    }
                }

                Console.WriteLine();
                ////this loop is used for printing the elements in a remaining rows
                for (int i = 1; i < cale.GetLength(0); i++)
                {
                    ////this loop is used for printing the columns in a row
                    for (int j = 0; j < cale.GetLength(1); j++)
                    {
                        if (cale[i, j] > 0)
                        {
                            Console.Write(cale[i, j] + "\t");
                        }
                        else
                        {
                            Console.Write(" " + "\t");
                        }
                    }

                    Console.WriteLine();
                }
            }
           
        }
    }
}
        

