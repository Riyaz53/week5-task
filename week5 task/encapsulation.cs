using System;

namespace Week5
{
    // ========================= TASK 1: Encapsulation =========================
    // This class demonstrates encapsulation using private fields,
    // public getters, and controlled updating of balance.
    class BankAccount
    {
        private readonly string accountNumber;   // Readonly value, cannot be changed later
        private double balance;                  // Private field to protect balance

        // Public read-only property
        public string AccountNumber => accountNumber;

        // Balance can only be changed inside the class
        public double Balance
        {
            get => balance;
            private set
            {
                if (value <= 0)
                    throw new InvalidOperationException("Balance cannot be zero or negative.");
                balance = value;
            }
        }

        public BankAccount(string accountNumber, double initialBalance)
        {
            this.accountNumber = accountNumber;
            Balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0) throw new ArgumentException("Deposit amount must be positive.");
            balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0) throw new ArgumentException("Withdraw amount must be positive.");
            if (amount > balance) throw new InvalidOperationException("Insufficient funds.");
            balance -= amount;
        }
    }
}
