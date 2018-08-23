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

            

            Console.ReadLine();
        }
    }
}
