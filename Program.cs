//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStrucure
{
    using System;


    /// <summary>
    /// this class is used to run all the programs
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application
        /// </summary>
        /// <param name="args">The arguments.</param>
     public static void Main(string[] args)
        {
            try
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
                    Console.WriteLine("PRESS 9 : FOR BANKING ");
                    Console.WriteLine("PRESS 10: FOR PRIME NUMBER ANAGRAM USING STACK");
                    Console.WriteLine("PRESS 11: FOR PRIME NUMBER ANAGRAM USING QUEUE");
                    Console.WriteLine("PRESS 12: FOR BINARY SEARCH TREE ");
                    Console.WriteLine("PRESS 13: FOR HASHING");
                    Console.WriteLine("PRESS 14 balance expression");
                    Console.WriteLine("Presss 15 prime anagram using stack");
                    Console.WriteLine("PRESS 16 prime anagram using queue");


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
                        case 9:
                            Banking bank = new Banking();
                            bank.BankOperations();
                            break;
                        case 10:
                            AddPrimeNumStack pnas = new AddPrimeNumStack();
                            pnas.AddAnagramStack();
                            break;
                        case 11:
                            AddPrimeNumQueue pnaq = new AddPrimeNumQueue();
                            pnaq.AddPrimeQueue();
                            break;
                        case 12:
                            BinarySearchTree bst = new BinarySearchTree();
                            Console.WriteLine("ENTER THE ONE NUMBER");
                            int number = Convert.ToInt32(Console.ReadLine());
                            bst.CountBst(number);
                            break;
                        case 13:
                            HashMap h = new HashMap();
                            h.StoringAndRetrievingNumbers();
                            break;
                        case 14:
                            Balance b = new Balance();
                            b.BalancedParenthesisDemo();
                            break;
                        case 15:
                            PrimeAnagramStack pnr = new PrimeAnagramStack();
                            pnr.PrimeAnagramStackDemo();
                            break;
                        case 16:
                            PrimeAnagramQueue prq = new PrimeAnagramQueue();
                            prq.PrimeAnagramQueueDemo();
                            break;

                    }

                    Console.WriteLine("ENTER YES FOR Y AND NO FOR N");
                    flag = Convert.ToChar(Console.ReadLine());
                }
                while (flag == 'y' || flag == 'Y');
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
