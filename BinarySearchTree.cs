using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStrucure
{
    class BinarySearchTree
    { 
              public long Factorial(int n)
        {
            ////declaring result variable store the factorial results
            long result = 1;
                ////iterating while loop till number is greater than zero
                while (n > 0)
                {
                ////multiplying and storing factorial value in result variable
                result = result * n;
                    ////on every iterating decrementing value of n to n-1
                    n--;
                }
            ////returning res
            return result; 
        }
        /// <summary>
        /// count binary search tree method will calculate the number of binary search tree
        /// </summary>
        /// <param name="n"> integer </param>
        public void CountBst(int n)
        {
            try
            {
                //// using formula 
                long count = this.Factorial(2 * n) / (this.Factorial(n + 1) * this.Factorial(n));
                Console.WriteLine("Number OF BINARY SEARCH IS  " + count);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
