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
            try
            {
                //-------------- Creates the account with 900, adds 300 and withdraw 100. ---------------
                Account account = new Account(900);
                Console.WriteLine($"Account balance: {account.AccountBalance:C}");
                account.Credit(300);
                account.Debit(100);
                Console.WriteLine($"New account balance: {account.AccountBalance:C}\n");

                // ----------- Creates the accountSave with 1000 and interest rate with 10 percentage. -------------- 
                SavingsAccount accountSave = new SavingsAccount(900, 10);
                Console.WriteLine($"AccountSave balance: {accountSave.AccountBalance:C}");
                accountSave.Credit(200);
                accountSave.Debit(100);
                Console.WriteLine($"AccountSave current balance: {accountSave.AccountBalance:C}");

                // Find interest earned and add it to account balance
                decimal interestEarned = accountSave.CalculateInterest();
                accountSave.Credit(interestEarned);
                Console.WriteLine($"AccountSave balance with added interest earned: {accountSave.AccountBalance:C}\n");

                //----------- Creates the accountCheck with 200 and fee with 20. Adds 200 or withdraw 100. ----------------
                CheckingAccount accountCheck = new CheckingAccount(200, 20);
                Console.WriteLine($"AccountCheck balance: {accountCheck.AccountBalance:C}");

                // Credit 200
                accountCheck.Credit(200);
                Console.WriteLine($"AccountCheck balance (Credit 200): {accountCheck.AccountBalance:C}");

                // Debit 100
                accountCheck.Debit(100);
                Console.WriteLine($"AccountCheck balance (Debit 100): {accountCheck.AccountBalance:C}");
            }
            catch
            {
                Console.WriteLine("Account must be equal or grater than 0.");
            }
            Console.ReadLine();
        }
    }
}
