using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleAppOne.src.OopPrinciples.Encapsulation
{
    public class BackAccount
    {
        private decimal balance;

        public BackAccount(decimal balance)
        {
            Deposit(balance);
        }

        public decimal GetBalance()
        {
            return balance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposite must be positive");
            }

            this.balance += amount;
        }

        public void WithDraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("WithDraw amount must be positive");
            }

            if (amount > balance)
            {
                throw new ArgumentException("WithDraw is exceeded by the balance ammount");
            }

            this.balance -= amount;
        }
    }
}