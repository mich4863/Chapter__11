using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp._11._9
{
    public class SavingsAccount : Account
    {
        private decimal percentage;

        public SavingsAccount(decimal accountBalance, decimal percentage) 
            : base(accountBalance)
        {
            Percentage = percentage;
        }

        public decimal Percentage
        {
            get
            {
                return percentage;
            }

            set
            {
                if(value < 0.0m)
                {
                    throw new ArgumentOutOfRangeException("The value must be greater or equal to 0.0");
                }
                percentage = value;
            }
        }

        public decimal CalculateInterest()
        {
            decimal earnedAmount = AccountBalance * percentage;
            return earnedAmount;
        }
    }
}
