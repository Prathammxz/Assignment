using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class BankAccount
    {
        private string accountNumber;
        private decimal balance;

        public BankAccount(string accountNumber)
        {
            this.accountNumber = accountNumber;
            this.balance = 0;
        }

        public string AccountNumber { get { return accountNumber; } }
        public decimal Balance { get { return balance; } }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Cannot Withdraw. Funds insufficient");
            }
            else
            {
                balance -= amount;
            }
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Final Balance: {balance}");

        }
    }

    
}
