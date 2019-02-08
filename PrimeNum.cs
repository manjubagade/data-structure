//-----------------------------------------------------------------------
// <copyright file="PrimeNum.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStrucure
{
    using System;
    using System.Collections;


    /// <summary>
    /// this class prime number of print 0 to 1000
    /// </summary>


    public class PrimeNum
    {
        /// <summary>
        /// Define the method of primenumbers 
        /// </summary>
        /// <param name="args">The arguments.</param>
        public void PrimeNum1()
        {
            Utility util = new Utility();
            ArrayList primeNums = util.PrimeNum();
            int[,] pnr = new int[10, 25];
            int sindex = 0;
            int range1 = 0;
            int range2 = 100;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j <= pnr.GetLength(1); j++)
                {
                        if (sindex < primeNums.Count && ((int)primeNums[sindex] > range1) && ((int)primeNums[sindex] <= range2))
                        {
                            pnr[i, j] = (int)primeNums[sindex];
                            sindex++;
                        }
                }

                range1 = range1 + 100;
                range2 = range2 + 100;
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < pnr.GetLength(1); j++)
                {
                        if (pnr[i, j] > 0)
                        {
                            Console.Write(pnr[i, j] + "\t");
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}