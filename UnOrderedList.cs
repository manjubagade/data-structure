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
    /// the class name  should be underedlist
    /// </summary>
      public class UnOrderedList
      {
        /// <summary>
        /// the add and moving the file 
        /// </summary>
        public void AddAndRemoveFile()  
        {
            Utility utility = new Utility();
            LinkedList<String> ll = new LinkedList<string>();
            string text = System.IO.File.ReadAllText(utility.FileForUnoderedList());
            string[] word = text.Split(new char[] { ' ' });
            Console.WriteLine("Linked list for file");
            foreach(string list in word)
            {
                ll.AddLast(list);
            }
            foreach(string list in ll)
            {
                Console.WriteLine(list);
            }
            
            Console.WriteLine("THE LENGTH  CHARATER IN FILE  "  +text.Length);
            Console.WriteLine("Enetr the String To the Search in  file");
            String search = Console.ReadLine();

            if (Regex.IsMatch(search.Replace(" ", string.Empty), @"^[a-zA-Z]+$"))
            {
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
            foreach(string list in ll)
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
