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
                Console.WriteLine("PRESS 3 : FOR BALANCED EXPRESSION");
                Console.WriteLine("PRESS 4 : FOR PALIDROME CHECKING");
                Console.WriteLine("PRESS 5 : FOR THE CALENDER ");
                Console.WriteLine("PRESS 6 : FOR THE STACKTHOUTH CALENDER");
                Console.WriteLine("PRESS 7 : FOR THE QUEUE THOUTH THE CALENDER");
                Console.WriteLine("PRESS 8 : FOR PRIME NUMBER IN  2 D ARRAy");

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
                    case 3:
                        ArithmeticExp ax = new ArithmeticExp();
                        ax.Airthexp();
                        break;
                    case 4:
                        PalidromeCheck pc = new PalidromeCheck();
                        pc.PaliCheck();
                        break;
                    case 5:
                        Calender c = new Calender();
                        c.Cal();
                        break;
                    case 6:
                        CalenderThouthStack cs = new CalenderThouthStack();
                        cs.StackImp();
                        break;
                    case 7:
                        CalenderThouthQueue cq = new CalenderThouthQueue();
                        cq.CalToQue();
                        break;
                    case 8:
                        PrimeNum pn = new PrimeNum();
                        pn.PrimeNum1();
                        break;

                }

                Console.WriteLine("ENTER YES FOR Y AND NO FOR N");
                flag = Convert.ToChar(Console.ReadLine());
            }
            while (flag == 'y' || flag== 'Y');
  
        }
    }
}

       
