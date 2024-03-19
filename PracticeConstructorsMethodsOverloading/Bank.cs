using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConstructorsMethodsOverloading
{
    public class Bank
    {
        string _accountNumber;
        string _customerName;
        double _balance;

        public Bank(string accountNumber, string customerName, double balance)
        {
            _accountNumber = accountNumber;
            _customerName = customerName;
            _balance = balance;
        }

        public string AccountNumber { get => _accountNumber; set => _accountNumber = value; }
        public string CustomerName { get => _customerName; set => _customerName = value; }
        public double Balance { get => _balance;}

        public void Deposit(double amount)
        {

            if (amount < 0)
            {
                Console.WriteLine("Cannot deposit a negative amount.");
            }
            else
            {
                _balance += amount;
                Console.WriteLine($"Deposited {amount:C}. New balance: {_balance:C}");
            }

        }


        public void Withdraw(double amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Cannot withdraw a negative amount.");
            }
            else if (amount > _balance)
            {
                Console.WriteLine("Insufficient funds.");
            }
            else
            {
                _balance -= amount;
                Console.WriteLine($"Withdrawn {amount:C}. New balance: {_balance:C}");
            }



        }

        public override string ToString()
        {
            return $"{_accountNumber} - {_customerName} - Current Balance: {_balance:C}";
        }



    }
}
