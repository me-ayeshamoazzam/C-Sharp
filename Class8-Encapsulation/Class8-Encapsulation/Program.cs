using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class8_Encapsulation
{
    class BankAccount
    {
        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
        }
        public void deposit(decimal amount)
        {
            if(amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited: {amount}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive");
            }
        }
        public void withDraw(decimal amount)
        {
            if(balance > 0 && amount > 0)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew: {amount}");
            }
            else
            {
                Console.WriteLine("Insufficient balance or Invalid amount of funds");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount();

            bankAccount.deposit(100);
            Console.WriteLine($"Current Balance =  {bankAccount.Balance}");

            bankAccount.withDraw(20);
            Console.WriteLine($"Current Balance = {bankAccount.Balance}");
            Console.ReadKey();
        }
    }
}
