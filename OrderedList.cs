using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
namespace DataStrucure
{
    class OrderedList
    {
        public void AddAndSort()
        {
            Utility util = new Utility();
            
            LinkedList<int> ll = new LinkedList<int>();
            
            string names = System.IO.File.ReadAllText(util.FileForOrderedList());
            string[] StrForNum = names.Split(' ');
            Console.WriteLine("BEFORE SORTED THE ELEMENT IN GIVEN FILE");
            foreach (String list in StrForNum)
            {
                Console.WriteLine(list);
            }
           
            int[] StrToNum = Array.ConvertAll(StrForNum, int.Parse);
            Array.Sort(StrToNum);
            Console.WriteLine("AFTER SORTED THE ELEMENT IN FILE");
            foreach (int list in StrToNum)
            {
                ll.AddLast(list);
            }

            foreach (int list in ll)
            {
                Console.WriteLine(list);
            }
            Console.WriteLine("THE SIZE OF ELEMENT IN GIVEN FILE " + names.Length);

            Console.WriteLine("ENTER SEARCH FOR ELEMENT IN GIVEN FILE");
            try
            {
                
                int searnum = Convert.ToInt32(Console.ReadLine());
               
                if (ll.Contains(searnum))
                {
                    Console.WriteLine("SEARCH ELEMENT CONTAIN IN THE FILE AND REMOVE FROM FILE");
                    ll.Remove(searnum);
                }
                else
                {
                    Console.WriteLine("SEARCH ELEMENT DO NOT IN FILE and ADDED IN THE FILE");
                    ll.AddLast(searnum);
                }
                foreach (int list in ll)
                {
                    Console.WriteLine(list);
                }
                string resultString = string.Join(" ", ll);
                using (StreamWriter sw = new StreamWriter(util.ResultForlist()))
                {
                    sw.WriteLine(resultString + " ");
                }
            }
            catch (System.FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
