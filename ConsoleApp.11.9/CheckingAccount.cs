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
        private decimal feeCharged;

        // Constructor
        public CheckingAccount(decimal accountBalance, decimal feeCharged) 
            : base(accountBalance)
        {
            FeeCharged = feeCharged;
        }

        // Property
        public decimal FeeCharged
        {
            get
            {
                return feeCharged;
            }

            set
            {
                feeCharged = value;
            }
        }

        // Override withdraw method. Charges fee if amount is withdraw from account.
        public override bool Debit(decimal amount)
        {      
            bool check = base.Debit(amount);

            if(check == true)
            {
                decimal result = AccountBalance * FeeCharged;
                AccountBalance = AccountBalance - result;
            }
            return check;
        }


    }
}
