using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp._11._9
{
    public class CheckingAccount : Account
    {
        private decimal feeCharged;

        public CheckingAccount(decimal accountBalance, decimal feeCharged) 
            : base(accountBalance)
        {
            FeeCharged = feeCharged;
        }

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

        public override bool Withdraw(decimal amount)
        {      
            bool check = base.Withdraw(amount);

            if(check == true)
            {
                decimal result = AccountBalance * FeeCharged;
                AccountBalance = AccountBalance - result;
            }
            return check;
        }


    }
}
