using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp._11._9
{
    public class Account
    {
        // Field
        private decimal accountBalance;

        // Constructor
        public Account(decimal accountBalance)
        {
            AccountBalance = accountBalance;
        }

        // Property
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

        // Add amount to account
        public virtual void Credit(decimal amount)
        {
            AccountBalance = AccountBalance + amount;
        }

        // WithDraw amount from account
        public virtual bool Debit(decimal amount)
        {
            if(amount < AccountBalance)
            {
                AccountBalance = AccountBalance - amount;
                return true;
            }
            else
            {
                Console.WriteLine("Debit amount exceeded account balance.");
                return false;
            }
        }
    }
}
