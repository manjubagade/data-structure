//-----------------------------------------------------------------------
// <copyright file="CalenderThouthQueue.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStrucure
{
    using System;
    using System.Collections;

    /// <summary>
    /// finding the weeks of days using the queue
    /// </summary>
     public class CalenderThouthQueue
      {
        /// <summary>
        /// this weekofdays using the queue this instance
        /// </summary>
        public void CalToQue()
        { ////creating The queue object
            Queue mqueue = new Queue();
            ////creating the object of a queue
            Queue squeue = new Queue();
            ////creating the object of utility class
            Utility utility = new Utility();
            int year = 0;
            int month = 0;
                Console.WriteLine("ENTER THE YEAR");
                ////take the input from usr
                year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ENTER THE MONTH");
                ////take the input from user
                month = Convert.ToInt32(Console.ReadLine());
            if (month >= 1 && month <= 12 && year >= 1000 && year <= 9999)
            {
                int[] days = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };  
                int sdate = utility.DayOfWeek(year, month);
                if ((month == 2) && (year % 4 == 0))
                {
                    days[2] = 29;
                }
                int date = 01;
                for (int i = sdate; i < 7; i++)
                {
                    squeue.Enqueue(date);
                    date++;
                }
                mqueue.Enqueue(squeue);
                squeue = new Queue();
                while (days[month] >= date)
                {
                    for (int i = 0; i < 7; i++)
                    {                    
                        if (date <= days[month])
                        {
                            squeue.Enqueue(date);  
                            date++;
                        }
                    }
                    mqueue.Enqueue(squeue);
                    squeue = new Queue();
                }
                Console.WriteLine("sun \tmon \ttue \twed \tthr \tfri \tsat");
                for (int i = 1; i <= sdate; i++)
                {
                    Console.Write("\t");
                }
                while (mqueue.Count != 0)
                {
                    Queue queue = (Queue)mqueue.Dequeue();
                    foreach (int obj in queue)
                    {
                        Console.Write(obj + "\t");
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
        }
    }
}