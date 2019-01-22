using System;

namespace DataStrucure
{
    using System;
    using System.Collections;

    public class PalidromeCheck
    {
        public void PaliCheck()
        {
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
