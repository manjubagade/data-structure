using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DataStrucure
{
  public class PrimeNum
    {
        public void PrimeNum1()
        {
            Utility util = new Utility();
            ArrayList primeNums = util.PrimeNum();
            int[,] pnr = new int[10, 25];
            int startindex = 0;
            int range1 = 0;
            int range2 = 100;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j <= pnr.GetLength(1); j++)
                {
                    
                        if (startindex < primeNums.Count && ((int)primeNums[startindex] > range1) && ((int)primeNums[startindex] <= range2))
                        {
                            pnr[i, j] = (int)primeNums[startindex];
                            startindex++;
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