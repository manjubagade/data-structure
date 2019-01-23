//-----------------------------------------------------------------------
// <copyright file=" Utility.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStrucure
{
    using System;
    using System.Collections;

    /// <summary>
    /// this class is used to run all the programs
    /// </summary>

   public class Utility
    {
        /// <summary>
        /// the queue object is created
        /// </summary>
        public Queue queue = new Queue();
        /// <summary>
        /// Files for taking input of unordered list.
        /// </summary>
        /// <returns>the path of a folder</returns>

        public string FileForUnoderedList()
        {
            string path = @"C:\Users\Admin\Desktop\manjupgm\Algorithms\Algorithmspgm\underredList.txt";
            return path;
        }

        public string ResultForUnderedlist()
        {
            string path = @"C:\Users\Admin\Desktop\manjupgm\Algorithms\Algorithmspgm\ResultList.txt";
            return path;
        }

        public string FileForOrderedList()
        {
            string path = @"C:\Users\Admin\Desktop\manjupgm\DataStructure\DataStrucure\orderedList.txt";
            return path;
        }

        public string ResultForlist()
        {
            string path = @"C:\Users\Admin\Desktop\manjupgm\Algorithms\Algorithmspgm\ResultListOrder.txt";
            return path;
        }

        public int GetInt()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            return n;
        }

        public double GetDouble()
        {
            double d = Convert.ToDouble(Console.ReadLine());
            return d;
        }

        public int DayOfWeek(int year, int month)
        {
            string[] week = { "Sunday", "monday", "tuesday", "wednesday", "thrusday", "friday", "saturday" };
            int y = year;
            int m = month;
            int d = 1;
            int y0 = y - ((14 - m) / 12);
            int x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
            int m0 = m + (12 * ((14 - m) / 12)) - 2;
            int d0 = (d + x + (31 * m0 / 12)) % 7;
            return d0;

        }
             public ArrayList PrimeNum()
        {
            //// creating the arraylist objects
            ArrayList spn = new ArrayList();
            ////looping the start from 1 to 1000
            for (int i = 1; i <= 1000; i++)
            {
                int count = 0;
                ////looping from 1 to 1000
                for (int j = 1; j <= 1000; j++)
                {
                    ////condition check i and j 
                    if ((i % j) == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    spn.Add(i);
                }
            }
            return spn;
        }


    }
}
