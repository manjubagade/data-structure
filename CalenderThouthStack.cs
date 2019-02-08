//-----------------------------------------------------------------------
// <copyright file="CalenderThouthStack.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStrucure
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// finding the weeks of days program calender using stack
    /// </summary>
   public class CalenderThouthStack
    {
        /// <summary>
        /// weeks of days using stack this instance
        /// </summary>
        public void StackImp()
        {
            ////creating the object class 
            Utility util = new Utility();
            ////creating the stack object
            Stack<Queue<int>> stack = new Stack<Queue<int>>();
            ////creating the stack object store all stack in reverse order
            Stack<Queue<int>> stackReverse = new Stack<Queue<int>>();
            ////creating the one queue obects
            Queue<int> queue = new Queue<int>();
            int year = 0;
            int month = 0;
            Console.WriteLine("ENTER THE YEAR");
           ////taking the input of a year from user
           year = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("ENTER THE MONTH");
           ////taking the input month from the user
           month = Convert.ToInt32(Console.ReadLine());
            if (month >= 1 && month <= 12 && year >= 1000 && year <= 9999)
            {
                int[] days = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                int sdate = util.DayOfWeek(year, month);
                if ((month == 2) && (year % 4 == 0))
                {
                    days[2] = 29;
                }
                int date = 01;
                for (int i = sdate; i < 7; i++)
                {
                    queue.Enqueue(date);
                    date++;
                }

                stack.Push(queue);
                queue = new Queue<int>();

                while (days[month] >= date)
                {
                    for (int i = 0; i < 7; i++)
                    {
                        if (date <= days[month])
                        {
                            queue.Enqueue(date);
                            date++;
                        }
                    }
                    
                    stack.Push(queue);
                    queue = new Queue<int>();
                }
                Console.WriteLine("sun \tmon \ttue \twed \tthr \tfri \tsat");
                for (int i = 1; i <= sdate; i++)
                {
                    Console.Write("\t");
                }
                while (stack.Count != 0)
                {
                    stackReverse.Push(stack.Pop());
                }

                while (stackReverse.Count != 0)
                {
                    foreach (var item in stackReverse.Pop())
                    {
                        Console.Write(item + "\t");
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
        }
    }
}

