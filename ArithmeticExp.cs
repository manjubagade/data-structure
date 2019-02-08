//-----------------------------------------------------------------------
// <copyright file="ArithmeticExp.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStrucure
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// finding the balance expressetion true or false
    /// </summary>
  public class ArithmeticExp
    {
        /// <summary>
        /// this airthmetic expressetion using balance this instance
        /// </summary>
      public void Airthexp()
        {
            try
            {
                int count = 0;
                //// creating one utility object
                Utility u = new Utility();
                //// creating one stack objects 
               //// Stack<char> sl = new Stack<char>();
                LinkedListClass list = new LinkedListClass();
                Console.WriteLine("enter expression ");
                string s1 = Console.ReadLine();
                //// string is converting into the charater array
                char[] ch = s1.ToCharArray();
                for (int i = 0; i < ch.Length; i++)
                {
                    if (ch[i] == '(')
                    {
                        list.Push(ch[i]);
                    }
                    else if (ch[i] == ')')
                    {
                        list.Pop();
                    }
                }
                if (list.Equals(s1))
                {
                    Console.WriteLine("Balanced expression");
                }
                else
                {
                    Console.WriteLine("Expression is not Balance Expressin");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
