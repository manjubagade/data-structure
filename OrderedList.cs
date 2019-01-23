//-----------------------------------------------------------------------
// <copyright file=" OrderedList.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStrucure
{
    using System;
    using System.Collections.Generic;
    using System.IO;


    /// <summary>
    /// this class is sorting the number from files
    /// </summary>
    public class OrderedList
    {
        /// <summary>
        /// orderedklist in given file this instance.
        /// </summary>
        public void AddAndSort()
        {
            //// creating the utility object
            Utility util = new Utility();
            //// creating the linked list object 
            LinkedList<int> ll = new LinkedList<int>();
            //// take the path of file
            string names = System.IO.File.ReadAllText(util.FileForOrderedList());
            //// string is spliting by the comma 
            string[] strForNum = names.Split(',');
            Console.WriteLine("BEFORE SORTED THE ELEMENT IN GIVEN FILE");
            foreach (String list in strForNum)
            {
                Console.WriteLine(list);
            }  
            int[] strToNum = Array.ConvertAll(strForNum, int.Parse);
            Array.Sort(strToNum);
            Console.WriteLine("AFTER SORTED THE ELEMENT IN FILE");
            foreach (int list in strToNum)
            {
                ll.AddLast(list);
            }

            foreach (int list in ll)
            {
                Console.WriteLine(list);
            }
            ////the check the total size of length of charater present in file
            Console.WriteLine("THE SIZE OF ELEMENT IN GIVEN FILE " + names.Length);
            //// searching one particular element in given file
            Console.WriteLine("ENTER SEARCH FOR ELEMENT IN GIVEN FILE");
            try
            {
                int searnum = Convert.ToInt32(Console.ReadLine());
               //// searching the elements in the file
                if (ll.Contains(searnum))
                {
                    Console.WriteLine("SEARCH ELEMENT CONTAIN IN THE FILE AND REMOVE FROM FILE");
                    //// if the file is searching the remove from file
                    ll.Remove(searnum);
                }
                else
                {
                    Console.WriteLine("SEARCH ELEMENT DO NOT IN FILE and ADDED IN THE FILE");
                    //// if the file is not searching then add to the list
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
