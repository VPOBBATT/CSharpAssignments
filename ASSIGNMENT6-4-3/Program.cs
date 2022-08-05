using System;

namespace Bank
{
    class Banks
    {
        public delegate void Accounts(int x);

        public class Account
        {
            public int accountNumber { get; set; }
            public string customerName { get; set; }
            public decimal balance = 1500;

            public event Accounts UnderBalance;
            public event Accounts ZeroBalance;

            public void Insufficient(int x)
            {
                UnderBalance(x);
            }

            public void DepositeAmount(int y)
            {
                ZeroBalance(y);
            }
            public void WithDraw(int x)
            {
                if (x < balance && balance != 0)
                {
                    Console.WriteLine("Transaction Successfull");
                    Console.WriteLine("Remaining Balance is:" + (balance - x));
                }
                else if (x > balance && balance != 0)
                {
                    Console.WriteLine("Insufficient Amount");
                    Console.WriteLine("Your Current Balance is:" + balance + "only");
                }
                else
                {
                    Console.WriteLine("Zero Balance:" + balance);
                }
            }
            public void Deposite(int x)
            {
                Console.WriteLine("Balance after depositing:" + (balance + x));
            }
        }

        static void Main(string[] args)
        {
            Account obj = new Account();
            Console.WriteLine("What you want to do.Withdraw Amount or Deposite:w or d");
            string wd = Console.ReadLine();
            if (wd == "w")
            {
                Console.WriteLine("Enter amount to be Withdrawn");
                int wdbalance = Convert.ToInt32(Console.ReadLine());
                obj.UnderBalance += new Accounts(obj.WithDraw);
                obj.Insufficient(wdbalance);
            }
            else
            {
                Console.WriteLine("Enter the amount to be Deposite:");
                int dpbalance = Convert.ToInt32(Console.ReadLine());
                obj.ZeroBalance += new Accounts(obj.Deposite);
                obj.Deposite(dpbalance);
            }
            Console.ReadKey();
        }
    }
}