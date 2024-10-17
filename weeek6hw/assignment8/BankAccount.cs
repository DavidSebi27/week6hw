using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment8
{
    internal class BankAccount
    {
        public string AccountNumber { get; private set; }
        public double Balance { get; set; }

        public BankAccount(string accountNumber, double initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposit Successful. New balance: {Balance}");
        }

        public void Withdraw(double amount)
        {
            if (Balance < amount)
            {
                Console.WriteLine("Withdrawal unsuccessful, reason: lack of funds.");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawal successful. New balance: {Balance}");
            }
        }

        public void AccountDetails()
        {
            Console.Write($"\nAccount Details:\nAccount Number: {AccountNumber}\nBalance: {Balance}");
        }
    }
}
