using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp._11._9
{
    public class Account
    {
        private decimal accountBalance;

        public Account(decimal accountBalance)
        {
            AccountBalance = accountBalance;
        }

        public decimal AccountBalance
        {
            get
            {
                return accountBalance;
            }

            set
            {
                if(value < 0.0m)
                {
                    throw new ArgumentOutOfRangeException("The value must be greater or equal to 0.0");
                }
                else
                {
                    accountBalance = value;
                }        
            }
        }

        public void Credit(decimal amount)
        {
            AccountBalance = AccountBalance + amount;
        }

        public virtual bool Withdraw(decimal amount)
        {
            bool check = false;
            if(amount < AccountBalance)
            {
                AccountBalance = AccountBalance - amount;
                check = true;
            }
            else
            {
                Console.WriteLine("Debit amount exceeded account balance.");
            }
            return check;
        }
    }
}
