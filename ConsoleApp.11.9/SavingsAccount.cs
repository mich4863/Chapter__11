using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp._11._9
{
    public class SavingsAccount : Account
    {
        // Field
        private decimal percentage;

        // Constructor
        public SavingsAccount(decimal accountBalance, decimal percentage) 
            : base(accountBalance)
        {
            Percentage = percentage;
        }

        // Property
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

        // Interest rate
        public decimal CalculateInterest()
        {
            return AccountBalance * percentage / 100m;
        }
    }
}
