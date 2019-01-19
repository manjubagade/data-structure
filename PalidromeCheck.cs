using System;

namespace DataStrucure
{
    using System;
    using System.Collections;

    class PalidromeCheck
    {

        public void PaliCheck()
        { 
            Queue fqueue = new Queue();
            Queue squeue = new Queue();
            Console.WriteLine("ENTER THE STRING");
            string s = Console.ReadLine();
            int Flag = 0;
            char[] StrToChar = s.ToLower().ToCharArray();
            int lenofchar = StrToChar.Length;
            for(int i=0; i<lenofchar;i++)
            {
                fqueue.Enqueue(StrToChar[i]);
            }
            for(int i=lenofchar-1; i>=0;i--)
            {
                squeue.Enqueue(StrToChar[i]);
            }

            while((fqueue.Count !=0) &&  (squeue.Count != 0))
            {
                if((char)fqueue.Dequeue() != (char)squeue.Dequeue())
                {
                    Flag++;
                }
            }
            if (Flag > 0)
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
