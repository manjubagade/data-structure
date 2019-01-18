using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStrucure
{
    class Program
    {
        static void Main(string[] args)
        {
            char flag;
            do
            {
                Console.WriteLine("PRESS 1 : FOR UNORDEREDLIST IN GIVEN FILE");
                Console.WriteLine("PRESS 2  : FOR ORDEREdLIST IN GIVEN FILE");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        UnOrderedList unl = new UnOrderedList();
                        unl.AddAndRemoveFile();
                        break;
                    case 2:
                        OrderedList ol = new OrderedList();
                        ol.AddAndSort();
                        break;
                }

                Console.WriteLine("ENTER YES FOR Y AND NO FOR N");
                flag = Convert.ToChar(Console.ReadLine());
            }
            while (flag == 'y');
  
        }
    }
}

       
