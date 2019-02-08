//-----------------------------------------------------------------------
// <copyright file="UnOrderedList.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStrucure
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    /// <summary>
    /// the class name  should be unoderedlist
    /// </summary>
    
      public class UnOrderedList
      {
        /// <summary>
        /// the add and moving the file 
        /// </summary>
        public void AddAndRemoveFile()  
        {
            //// creating the utility object class
            Utility utility = new Utility();
            //// creating the linked list object 
            LinkedListClass ll1 = new LinkedListClass();
            LinkedList<string> ll = new LinkedList<string>();
            //// creating one file path object 
            string text = File.ReadAllText(utility.FileForUnoderedList());
            //// spliting the text in spaces
            string[] word = text.Split(new char[] { ' ' });
            Console.WriteLine("LINKED LIST FILE");
            foreach (string list in word)
            {
                ll1.AddFirst(list);
            }
            ll1.Print();

            foreach (string list in ll)
            {
                Console.WriteLine(list);
            }

            //// check the length of character in text file 
            Console.WriteLine("THE LENGTH  CHARATER IN FILE  " + text.Length);
            Console.WriteLine("Enetr the String To the Search in  file");
            string search = Console.ReadLine();

            if (Regex.IsMatch(search.Replace(" ", string.Empty), @"^[a-zA-Z]+$"))
            {
                //// searching the element in present in the file
                if (ll.Contains(search))
                {
                    Console.WriteLine("seaching the word contain in file and remove from file");
                    ll.Remove(search);
                }
                else
                {
                    Console.WriteLine("contain word is not Seaching From File and added in the list");
                    ll.AddLast(search.Replace(" ", string.Empty));
                }
            }
            else
            {
                Console.WriteLine("FILE ONLY CHARATER AND LETTER ACCEPERD");
            }

            foreach (string list in ll)
            {
                Console.WriteLine(list);
            }

            string resultStr = string.Join(" ", ll);
            using (StreamWriter streamWriter = new StreamWriter(utility.ResultForUnderedlist()))
            {
                streamWriter.WriteLine(resultStr + " ");
            }
            Console.ReadLine();
        }
    }
}
