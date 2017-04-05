using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Account
    {
        private decimal balance;

        private decimal minimumBalance;

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            balance -= amount;
        }

        public void TransferFunds(Account destination, decimal amount)
        {
            if (balance - amount < minimumBalance)
                throw new InsufficientFundsException();

            this.Withdraw(amount);
            destination.Deposit(amount);
        }

        public decimal Balance
        {
            get { return balance; }
        }

        public decimal MinimumBalance
        {
            get { return minimumBalance; }
        }
    }
}
