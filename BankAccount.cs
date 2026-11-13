using System;
using System.Collections.Generic;
using System.Text;

namespace cs4_hw
{
    internal class BankAccount
    {
        private double _balance;

        public BankAccount(double balance)
        {
            if (balance < 0)
            {
                throw new Exception("Amount must be > 0");
            }

            _balance = balance;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new Exception("Amount must be > 0");
            }

            _balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount must be > 0");
            }

            if (amount > _balance)
            {
                throw new Exception("Not enough money brokie");
            }

            _balance -= amount;
        }

        public void ShowBalance()
        {
            Console.WriteLine($"Balance: {_balance}");
        }
    }
}
