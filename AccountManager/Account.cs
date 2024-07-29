using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManager
{
    internal class Account
    {   
        public static double MIN_BALANCE = 500;
        public int Id { get; set; }
        public string Name { get; set; }

        private double balance;
        public double Balance {
            get { return balance; } 
            set { balance = (value < MIN_BALANCE) ? MIN_BALANCE : value;}
        }

        public Account()
        { 
        }
    }
}
