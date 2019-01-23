//-----------------------------------------------------------------------
// <copyright file="AddPrimeNumQueue.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStrucure
{
    using System;
    using System.Collections;

    /// <summary>
    /// this program is printing the 0 to 1000 prime number anagagram printing using queue
    /// </summary>
    public class AddPrimeNumQueue
    {
        /// <summary>
        /// prime number anagram using queue this is instance
        /// </summary>
        public void AddPrimeQueue()
        {
            //// ctreating object for utiliy class
            Utility u = new Utility();
            //// creating object for queue 
            Queue queue = new Queue();
            //// creating object from arraylist
            ArrayList primenum = u.PrimeNum();
            ////looping from 0 to 1000
            for (int i = 0; i < primenum.Count; i++)
            {
                string num1 = primenum[i] + string.Empty;
                //// string array is converting into the charater array
                char[] num11 = num1.ToCharArray();
                //// sorting the array
                Array.Sort(num11);
                string s1 = new string(num11);
                //// looping from 0 to 1000
                for (int j = i + 1; j < primenum.Count; j++)
                {
                    string num2 = primenum[j] + string.Empty;
                    //// string arrays is converting into the char array
                    char[] num22 = num2.ToCharArray();
                    //// sorting the array
                    Array.Sort(num22);
                    string s2 = new string(num22);
                    //// check the equality of i and j array
                    if (s1.Equals(s2))
                    {
                        queue.Enqueue(num1);
                        queue.Enqueue(num2);
                    }
                }
            }
            Console.WriteLine("ANAGRAM OF PRIME NUMBER FROM 0 TO 1000");
            foreach (string num in queue)
            {
                Console.WriteLine(num + "\t");
            }
        }
    }
}
