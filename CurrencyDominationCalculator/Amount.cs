using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrenctCalculator
{
    internal class Amount
    {
        private int amount;
        private const int maxAmount = 50000;

        public int Value
        {
            get { return amount; }
            set
            {
                if (value > maxAmount)
                {
                    throw new ArgumentException("Amount should not exceed 50000.");
                }
                if (value % 100 != 0)
                {
                    throw new ArgumentException("Amount should be a multiple of 100.");
                }
                amount = value;
            }
        }

        public void CalculateDenominations(int amount)
        {
            int[] denominations = { 2000, 500, 200, 100 };
            int remainingAmount = amount;

            Console.WriteLine("Denominations for amount: " + amount);
            foreach (int denomination in denominations)
            {
                int count = remainingAmount / denomination;
                remainingAmount %= denomination;
                Console.WriteLine(denomination + ": " + count);
            }
        }
    }
}
