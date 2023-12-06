using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise1
{
    class BankAccount
    {
        private string accountNumber;
        private decimal balance;

        public BankAccount(string accountNumber)
        {
            this.accountNumber = accountNumber; 
            this.balance = 0;   

        }

        public void Deposit(decimal amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited Amount: {amount}");
        }

        public void Withdraw(decimal amount)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn Amount: {amount}");
        }

        public decimal GetBalance()
        {
            Console.WriteLine($"Total Balance: {balance}");
            return balance;
        }
    }


}
