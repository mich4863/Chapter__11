using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp._11._9
{
    class AccountTest
    {
        static void Main(string[] args)
        {
            Account account = new Account(900);
            Console.WriteLine($"Account: {account.AccountBalance:C}");
            account.Credit(300);
            account.Debit(100);
            Console.WriteLine($"New account balance: {account.AccountBalance}");


           /* Account acc1 = new Account(100);
            Console.WriteLine("The intial balance of account 1 is {0:C}", acc1.Balance);
            acc1.Credit(100);
            acc1.Debit(50);
            Console.WriteLine("The final balance of account 1 is {0:C}", acc1.Balance);
            Console.WriteLine();
            Account acc2 = new Account(-100);
            Console.WriteLine("The intial balance of account 2 is {0:C}", acc2.Balance);
            acc2.Credit(30);
            acc2.Debit(40);
            Console.WriteLine("The final balance of account 2 is {0:C}", acc2.Balance);
            Console.WriteLine();

            SavingsAccount acc3 = new SavingsAccount(100, 5);
            Console.WriteLine("The intial balance of account 3 is {0:C}", acc3.Balance);
            acc3.Credit(200);
            acc3.Debit(40);
            Console.WriteLine("The current balance of account 3 is {0:C}", acc3.Balance);
            decimal interest = acc3.CalculateInterest();
            acc3.Credit(interest);
            Console.WriteLine("The final balance of account 3 is {0:C}", acc3.Balance);
            Console.WriteLine();

            CheckingAccount acc4 = new CheckingAccount(100, 2.5M);
            Console.WriteLine("The intial balance of account 4 is {0:C}", acc4.Balance);
            acc4.Credit(100);
            acc4.Debit(70);
            Console.WriteLine("The final balance of account 4 is {0:C}", acc4.Balance);

            Console.ReadKey();*/
            Console.ReadLine();
        }
    }
}
