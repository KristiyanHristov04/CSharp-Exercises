using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesting_Exercisev2
{
    public class BankAccount
    {
        private const double MaxBalance = 10_000;
        private string firstName;
        public string FirstName 
        { 
            get { return firstName; }
            protected set
            {
                if (value.Length < 4)
                {
                    throw new ArgumentException("First name must contains at least 4 characters!");
                }
                this.firstName = value;
            }
        }
        private string lastName;
        public string LastName
        { 
            get { return lastName; }
            protected set
            {
                if (value.Length < 4)
                {
                    throw new ArgumentException("Last name must contains at least 4 characters!");
                }
                this.lastName = value;
            }
        }

        private double balance;

        public double Balance
        {
            get 
            { 
                return balance;
            }
            private set
            {
                this.balance = value;
            }
        }
        public BankAccount(string firstName, string lastName, double balance)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Balance = balance;
        }

        public void AddBalance(double amount)
        {
            if (this.Balance + amount > MaxBalance)
            {
                throw new InvalidOperationException("You don't have enough space to store the money!");
            }
            this.Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (this.Balance - amount < 0 && amount <= 10_000)
            {
                throw new InvalidOperationException("You don't have enough money to withdraw!");
            }

            if (amount > 10_000)
            {
                throw new ArgumentException("You've exceeded the maximum limit!");
            }

            this.Balance -= amount;
        }
    }
}
