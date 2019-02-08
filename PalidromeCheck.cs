//-----------------------------------------------------------------------
// <copyright file="PalidromeCheck.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStrucure
{
    using System;
    using System.Collections;

    /// <summary>
    /// finding the palindrome program using queue 
    /// </summary>
    public class PalidromeCheck
    {
        /// <summary>
        /// palindrome this instance
        /// </summary>
        public void PaliCheck()
        {
            LinkedListClass linklist1 = new LinkedListClass();
            LinkedListClass linklist2=new LinkedListClass();
            //// creating first queue objects
            Queue fqueue = new Queue();
            //// creating second queue objects
            Queue squeue = new Queue();
            //// take the input from usr
            Console.WriteLine("ENTER THE STRING");
            string s = Console.ReadLine();
            int flag = 0;
            //// string is converting into the tolower and character array
            char[] strToChar = s.ToLower().ToCharArray();
            int lenofchar = strToChar.Length;
            for (int i = 0; i < lenofchar; i++)
            {
                fqueue.Enqueue(strToChar[i]);
            }

            for (int i = lenofchar - 1; i >= 0; i--)
            {
                squeue.Enqueue(strToChar[i]);
            }

            while ((fqueue.Count != 0) && (squeue.Count != 0))
            {
                if ((char)fqueue.Dequeue() != (char)squeue.Dequeue())
                {
                    flag++;
                }
            }

            if (flag > 0)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }
}
