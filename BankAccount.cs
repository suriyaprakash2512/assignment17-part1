using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17_part1
{
    public class BankAccount
    {
        private static double nextAccountNumber = 123456789822;

        public double AccountNumber { get; }
        public string AccountHolderName { get; set; }

        private double balance;

       public double Balance
        {
            get { return balance; }
        }

        public BankAccount(string accountHolderName)
        {
            AccountNumber = nextAccountNumber++;
            AccountHolderName = accountHolderName;
            balance = 0;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited: ${amount}. New balance: ${balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be greater than zero.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn: ${amount}. New balance: ${balance}");
            }
            else if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be greater than zero.");
            }
            else
            {
                Console.WriteLine("Insufficient funds for withdrawal.");
            }

        }
    }
}
