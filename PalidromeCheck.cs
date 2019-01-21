using System;

namespace DataStrucure
{
    using System;
    using System.Collections;

    public class PalidromeCheck
    {
        public void PaliCheck()
        {
            Queue fqueue = new Queue();
            Queue squeue = new Queue();
            Console.WriteLine("ENTER THE STRING");
            string s = Console.ReadLine();
            int flag = 0;
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
