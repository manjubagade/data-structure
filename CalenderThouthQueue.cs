using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStrucure
{
    class CalenderThouthQueue
    {
        public void CalToQue()
        { ////creating The queue object
            Queue mQueue = new Queue();
            ////creating the object of a queue
            Queue sQueue = new Queue();
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
                int sDate = utility.DayOfWeek(year, month);
                if ((month == 2) && (year % 4 == 0))
                {
                    days[2] = 29;
                }
                int date = 01;
                for (int i = sDate; i < 7; i++)
                {
                    sQueue.Enqueue(date);
                    date++;
                }
                mQueue.Enqueue(sQueue);
                sQueue = new Queue();
                while (days[month] >= date)
                {
                    for (int i = 0; i < 7; i++)
                    {                    
                        if (date <= days[month])
                        {
                            sQueue.Enqueue(date);  
                            date++;
                        }
                    }
                    mQueue.Enqueue(sQueue);
                    sQueue = new Queue();
                }
                Console.WriteLine("sun \tmon \ttue \twed \tthr \tfri \tsat");
                for (int i = 1; i <= sDate; i++)
                {
                    Console.Write("\t");
                }
                while (mQueue.Count != 0)
                {
                    Queue queue = (Queue)mQueue.Dequeue();
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