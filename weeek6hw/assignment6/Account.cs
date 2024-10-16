using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment6
{
    internal class Account
    {
        private string _accountholder;
        private double _amount = 0.0;
        public double Amount { get { return _amount; } }

        public Account(string accountHolder)
        {
            _accountholder = accountHolder;
            LogTransaction($"Account created for {accountHolder}, initial balance is: {Amount} zoogleborp\n");
        }

        public void Deposit(double amount)
        {
            _amount += amount;
            LogTransaction($"Deposit of {amount} zoogleborp successful. New balance: {Amount} zoogleborp\n");
        }

        public void DisplayAccountInfo()
        {
            Console.Write($"Account holder: {_accountholder}\nBalance: {Amount} zoogleborp");
        }

        private void LogTransaction(string message)
        {
            Console.WriteLine($"\nTransaction log: {message}");
        }
    }
}
