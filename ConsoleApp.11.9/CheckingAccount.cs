using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp._11._9
{
    public class CheckingAccount : Account
    {
        // Field
        private decimal fee;

        // Constructor
        public CheckingAccount(decimal accountBalance, decimal fee) 
            : base(accountBalance)
        {
            Fee = fee;
        }

        // Property
        public decimal Fee
        {
            get
            {
                return fee;
            }

            set
            {
                fee = value;
            }
        }

        // Override withdraw method. Charges fee if amount is withdraw from account.
        public override void Credit(decimal amount)
        {
            base.Credit(amount);
            AccountBalance = fee;
        }

        public override bool Debit(decimal amount)
        {
            if(base.Debit(amount))
            {
                AccountBalance = fee;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
