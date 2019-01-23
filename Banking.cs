//-----------------------------------------------------------------------
// <copyright file="Banking.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStrucure
{
    using System;
    using System.Collections;

    /// <summary>
    /// this program is banking cash systems
    /// </summary>
    public class Banking
    {
        private Queue queue = new Queue();
        private int totalCash = 10000;
        private int count = 0;
        /// <summary>
        /// banking system thin instance
        /// </summary>
        public void BankOperations()
        {
                ////ch variable is used inside the do while loop to stop the execution of program
                char ch = 'n';
                ////starting do while loop
                do
                {
                    ////asking user his choice of operations
                    Console.WriteLine("ENTER PRESS 1 TO ADDING THE CUSTOMER NAME");
                    Console.WriteLine("ENTER PRESS 2 TO DEPOSITED THE CASH");
                    Console.WriteLine("ENTER PRESS 3 TO WITHDRAW THE CASH");
                    Console.WriteLine("ENTER PRSSS 4 TO BALANCE CHECKING");
                    Console.WriteLine("ENTER PRESS 5 TO VIEW THE CUSTOMER");
                    int n = Convert.ToInt32(Console.ReadLine());
                    
                    switch (n)
                    {
                        case 1:
                            this.AddCustomer();
                            break;
                        case 2:
                            this.DepositCash();
                            break;
                        case 3:
                            this.WithDrawCash();
                            break;
                        case 4:
                            this.CheckBalance();
                            break;
                        case 5:
                            this.ViewCustomer();
                            break;
                        default:
                            Console.WriteLine("CHOOSE VALID OPTION ");
                            break;
                    }

                    Console.WriteLine("Do you want to Continue");
                    ch = Convert.ToChar(Console.ReadLine());
                }
                while (ch != 'n');
         
        }
         public void AddCustomer()
        {
                Console.WriteLine("ENTER THE SIZE OF CUSTOMER NAME TO BE ADDED");
                int cust = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= cust; i++)
                {
                    this.count++;
                    Console.WriteLine("Enter " + i + " name");
                    string name = Console.ReadLine();
                    this.queue.Enqueue(name);
                }
                this.BankOperations();
        }

        /// <summary>
        /// Deposit cash method will help user to deposit cash in bank
        /// </summary>
        public void DepositCash()
        {
                Console.WriteLine("ENTER THE HOW MUCH AMOUNT TO BE DEPOSITED");
                int cash = Convert.ToInt32(Console.ReadLine());
                if (cash > 0)
                {
                    this.totalCash = this.totalCash + cash;
                    Console.WriteLine(cash + "CASH IS ADDED");
                    Console.WriteLine("Total Cash in Bank = "  + this.totalCash);
                    this.queue.Dequeue();
                }
                else
                {
                    Console.WriteLine("ENTER THE VALID AMOUNT:");
                }
                ////using recursive method
                this.BankOperations();
        }

        /// <summary>
        /// withdraw method will withdraw money from the bank
        /// </summary>
        public void WithDrawCash()
        {
                Console.WriteLine("ENTER THE HOW MUCH AMOUNT TO BE WITHDRAW");
                int withdraw = Convert.ToInt32(Console.ReadLine());
                if (withdraw >= 0 && withdraw <= this.totalCash)
                {
                    this.totalCash = this.totalCash - withdraw;
                    Console.WriteLine(withdraw + " CASH TO BE WITHDRAW");
                    Console.WriteLine("CASH IS LEFT  IN THE BANK  " + this.totalCash);
                    this.queue.Dequeue();
                }
                else
                {
                    Console.WriteLine("THERE is no Sufficent amount in bank");
                }
                this.BankOperations();
        }

        /// <summary>
        /// this method will check the total balance of the bank
        /// </summary>
        public void CheckBalance()
        {
                Console.WriteLine("Balance = " + this.totalCash);
                this.BankOperations();
        }

        /// <summary>
        /// the method check which all customer are in the queue
        /// </summary>
        public void ViewCustomer()
        {
                if (this.queue != null)
                {
                    foreach (string cust in this.queue)
                    {
                        Console.WriteLine(cust);
                    }
                }
                else
                {
                    Console.WriteLine("NO ONE IN THE QUEUE");
                }
                ////using recursive method
                this.BankOperations();
            }
        }
  }


