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
                //// creating one utility object
                Utility u = new Utility();
                //// creating one stack objects 
                Stack<char> sl = new Stack<char>();
                Console.WriteLine("enter expression ");
                string s1 = Console.ReadLine();
                //// string is converting into the charater array
                char[] ch = s1.ToCharArray();
                for (int i = 0; i < ch.Length; i++)
                {
                    if (ch[i] == '(')
                    {
                        sl.Push(ch[i]);
                    }
                    else if (ch[i] == ')')
                    {
                        sl.Pop();
                    }
                }
                if (sl.Count == 0)
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
