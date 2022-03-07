using System;
using Aula_146_Assignment.Entities.Exceptions;

namespace Aula_146_Assignment.Entities
{
    internal class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; private set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0) { throw new DomainException("Invalid deposit value."); }

            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0) { throw new DomainException("Invalid withdraw value."); }
            if (amount > WithdrawLimit) { throw new DomainException($"You can't withdraw more than ${WithdrawLimit} at a time."); }
            if (Balance < amount) { throw new DomainException("Not enough money in the account."); }

            Balance -= amount;
        }
    }
}
