using System;

namespace ConsoleApp4.Encapsulation
{
    internal class BankAccount
    {
        private string accountNumber;
        private double balance;

        public string AccountNumber
        {
            get { return accountNumber; }
        }

        public double Balance
        {
            get { return balance; }
            private set
            {
                if (value <= 0)
                    throw new ArgumentException("Balance must be greater than zero.");
                balance = value;
            }
        }

        public BankAccount(string accountNumber, double balance)
        {
            if (string.IsNullOrWhiteSpace(accountNumber))
                throw new ArgumentException("Account number cannot be empty.");

            this.accountNumber = accountNumber;
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Deposit must be greater than zero.");

            balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Withdraw amount must be greater than zero.");

            if (amount > balance)
                throw new InvalidOperationException("Insufficient balance.");

            balance -= amount;
        }
    }
}