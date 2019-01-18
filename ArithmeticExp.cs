using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStrucure
{
    class ArithmeticExp
    {
        public void Airthexp()
        { 
            Utility u = new Utility();
            Stack<char> sl = new Stack<char>();
            Console.WriteLine("enter expression ");
            string s1 = Console.ReadLine();
            char[] ch = s1.ToCharArray();
            for(int i=0; i<ch.Length;i++)
            {
                if(ch[i]=='(')
                {
                    sl.Push(ch[i]);
                }
                else if(ch[i]==')')
                {
                    sl.Pop();
                }
            }
            if(sl.Count == 0)
            {
                Console.WriteLine("Balanced expression");
            }
            else
            {
                Console.WriteLine("Expression is not Balance Expressin");
            }
        }
    }
}
