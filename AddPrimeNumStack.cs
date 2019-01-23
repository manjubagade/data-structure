//-----------------------------------------------------------------------
// <copyright file="AddPrimeNumStack.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStrucure
{
    using System;
    using System.Collections;

    /// <summary>
    /// finding the prime number anagram using sytack
    /// </summary>
    public  class AddPrimeNumStack
    {
        /// <summary>
        /// this is primenumberanagram using stack this instance
        /// </summary>
        
        public void AddAnagramStack()
        {
            //// creating one utilty objects
            Utility utility = new Utility();
            ////creating one stack object
            Stack stack = new Stack();
            ArrayList pnum = utility.PrimeNum();
            //// looping from 0 t0 1000
            for (int i = 0; i < pnum.Count; i++)
            { 
                string num1 = pnum[i] + string.Empty;
                //// string is converting into the char array
                char[] num11 = num1.ToCharArray();
                //// sorting the array
                Array.Sort(num11);
                string s1 = new string(num11);
                //// looping the 0 to 1000
                for (int j = i + 1; j < pnum.Count; j++) 
                {
                    string num2 = pnum[j] + string.Empty;
                    ////string array is converting into the char arrays
                    char[] num22 = num2.ToCharArray();
                    //// sorting array
                    Array.Sort(num22);
                    string s2 = new string(num22);
                    ////check the equal of i and j 
                    if (s1.Equals(s2))
                    {
                        stack.Push(num1);
                        stack.Push(num2);
                    }
                }
            }
            Console.WriteLine("THE PRIME NUMBER ANAGRAM FROM 1 TO 1000");
             foreach (string num in stack)
            {
                Console.WriteLine(num + "\t");
            }
        }
    }
}
