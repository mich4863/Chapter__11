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
            Account account = new Account(1000);
            CheckingAccount checkingAccount = new CheckingAccount(1000, 0.10m);
            checkingAccount.Debit(100);

            Console.WriteLine(checkingAccount.AccountBalance);

            Console.ReadLine();
        }
    }
}
